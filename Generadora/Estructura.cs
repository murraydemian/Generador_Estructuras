using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Generadora
{
    public class Estructura
    {
        private string _nombre;
        private List<Campo> _campos;

        public Estructura()
        {
            this._campos = new List<Campo>();
        }
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                string nombre = Regex.Replace(value, @"\b(\w)", m => m.Value.ToUpper());
                nombre = Regex.Replace(nombre, @"\s+", "");
                try
                {
                    int.Parse(nombre.Substring(0, 1));
                    nombre = "_" + nombre;
                    this._nombre = nombre;
                }
                catch (Exception)
                {
                    this._nombre = nombre;
                }
            }
        }
        public List<Campo> Campos
        {
            get
            {
                return this._campos;
            }            
        }
        public bool AgregarCampos(Campo cam)
        {
            bool seAgrego = false;
            if (!VerificarRepetido(cam))
            {
                this._campos.Add(cam);
                seAgrego = true;
            }
            return seAgrego;
        }
        private bool VerificarRepetido(Campo cam)
        {
            bool repetidos = false;
            foreach(Campo item in this.Campos)
            {
                if(cam.Identificador == item.Identificador)
                {
                    repetidos = true;
                    break;
                }
            }
            return repetidos;
        }
        public override string ToString()
        {
            string struc = this.HeadString();
            struc += "\n\n" + this.BuildString();
            struc += "\n\n" + this.SetGetString();
            return struc;
        }
        public string CFileString()
        {
            string completeC = this.BuildFunc() + "\n" + this.BuildFuncParam() + "\n";
            foreach(Campo item in this.Campos)
            {
                completeC += item.FuncGet(this.Nombre) + "\n" +
                    item.FuncSet(this.Nombre) + "\n";

            }
            return completeC;
        }
        public string HeadString()
        {
            string head = "typedef struct \n{\n";
            foreach(Campo item in this.Campos)
            {
                head += item.ToString() + "\n";
            }
            head += "}" + this.Nombre + ";";
            return head;
        }
        public string BuildString()
        {
            string builder = this.Nombre + "* " + this.Nombre.ToLower() + "_new";
            builder += "();\n" + builder + "Parametros(";
            foreach(Campo item in this.Campos)
            {
                builder += item.Tipo;
                if (item.Referencia)
                {
                    builder += "*";
                }
                if (item.Array)
                {
                    builder += "[]";
                }
                builder += " " + item.ParametroId + ", ";
            }
            if(this.Campos.Count > 0)
            {
                builder = builder.Substring(0, builder.Length - 2);
            }
            builder += ");";
            return builder;
        }
        public string SetGetString()
        {
            string campos = "";
            foreach(Campo item in this.Campos)
            {
                campos += item.FirmaGet(this.Nombre) + "\n";
                campos += item.FirmaSet(this.Nombre) + "\n\n";
            }
            return campos;
        }
        public string BuildFunc()
        {
            string func = this.Nombre + "* " + this.Nombre.ToLower() + "_new()\n{\n\t" +
                "return (" + this.Nombre + ")malloc(sizeof(" + this.Nombre + "));\n}";
            return func;
        }
        public string BuildFuncParam()
        {
            string func = this.Nombre + "* " + this.Nombre.ToLower() + "_newParametros(";
            foreach(Campo item in this.Campos)
            {
                func += item.ParametroId + ", ";
            }
            func = func.Substring(0, func.Length - 2);
            func += ")\n{\n\t" + this.Nombre + "* " + this.Nombre.ToLower() + "_P " +
                " = " + this.Nombre.ToLower() + "_new();\n\t";
            foreach(Campo item in this.Campos)
            {
                func += item.SetCall(this.Nombre) + "\n\t";
            }
            func += "return " + Nombre.ToLower() + "_P;\n}";
            return func;
        }
        public void Guardar()
        {
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                + "/" + this.Nombre + ".h", this.ToString());
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                + "/" + this.Nombre + ".c", this.CFileString());
        }
    }
}
