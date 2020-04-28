using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Generadora
{
    
    public class Campo
    {
        private string _tipo;
        private string _identificador;
        private bool _referencia;
        private bool _array;
        private int _cantidad;
        public Campo(string tipo, string identificador, bool referencia, bool array, int cantidad) {
            this._tipo = tipo;
            this._identificador = identificador;
            this._referencia = referencia;
            this._array = array;
            this._cantidad = cantidad;
        }
        public string ParametroId
        {
            get
            {
                return this.Identificador.ToLower() + "_P";
            }
        }
            
        public string Tipo
        {
            get
            {
                return this._tipo;
            }
            set
            {
                if(value != null)
                {
                    this._tipo = value;
                }
            }
        }
        public string Identificador
        {
            get
            {
                return this._identificador;
            }
            set
            {
                if (value != null)
                {
                    this._identificador = value;
                }
            }
        }
        public bool Referencia
        {
            get
            {
                return this._referencia;
            }
            set
            {
                this._referencia = value;
            }
        }
        public bool Array
        {
            get
            {
                return this._array;
            }
            set
            {
                this._array = value;
            }
        }
        public int Cantidad
        {
            get
            {
                return this._cantidad;
            }
            set
            {
                this._cantidad = value;
            }
        }
        public override string ToString()
        {
            string campo = "";
            campo += this.Tipo;
            if (this.Referencia)
            {
                campo += "*";
            }
            campo += " " + this.Identificador;
            if (this.Array)
            {
                campo += "[" + this.Cantidad.ToString() + "]";
            }
            campo += ";";
            return campo;
        }
        public string FirmaSet(string nombre)
        {
            string firma = "int " + nombre.ToLower() + "_Set" + this.Identificador 
                + "(" + nombre + "* " + nombre.ToLower() + "_P, " + this.Tipo;
            if (this.Referencia)
            {
                firma += "*";
            }
            if (this.Array)
            {
                firma += "[]";
            }
            firma += " " + this.Identificador.ToLower() + "_P);";
            return firma;
        }
        public string FirmaGet(string nombre)
        {
            string firma = "int " + nombre.ToLower() + "_Get" + this.Identificador
                + "(" + nombre + "* " + nombre.ToLower() + "_P, " + this.Tipo 
                + "* " + this.Identificador + "_P);";
            return firma;
        }
        public string FuncSet(string nombre)
        {
            string func = Regex.Replace(this.FirmaSet(nombre), ";", "");
            func += "\n{\n\t" + "int ret = 0;\n\t";
            if(this.Tipo == "char" && this.Array)
            {
                func += "if(" + nombre.ToLower() + "_P != NULL && " +
                    this.Identificador + "_P != NULL)\n\t{\n\t\t" + 
                    "strcpy(" + nombre.ToLower() + "_P->" + this.Identificador + 
                    ", " + this.Identificador + "_P);\n\t\t";
            }
            else
            {
                func += "if(" + nombre.ToLower() + "_P != NULL)\n\t{\n\t\t" +
                nombre.ToLower() + "_P->" + this.Identificador + " = " +
                this.Identificador + "_P;\n\t\t";                     
            }
            func += "ret = 1;\n\t}\n\t" + "return ret;\n}";
            return func;
        }
        public string FuncGet(string nombre)
        {
            string func = Regex.Replace(this.FirmaGet(nombre), ";", "");
            func += "\n{\n\t" + "int ret = 0;\n\t";
            if (this.Tipo == "char" && this.Array)
            {
                func += "if(" + nombre.ToLower() + "_P != NULL && " +
                    this.Identificador + "_P != NULL)\n\t{\n\t\t" +
                    "strcpy(" + this.Identificador + "_P, " + nombre.ToLower() +
                    "_P->" + this.Identificador + ");\n\t\t";
            }
            else
            {
                func += "if(" + nombre.ToLower() + "_P != NULL)\n\t{\n\t\t" +
                "*" + this.Identificador + "_P = " + this.Identificador + " = " +
                nombre.ToLower() + "_P->" + this.Identificador + ";\n\t\t";
            }
            func += "ret = 1;\n\t}\n\t" + "return ret;\n}";            
            return func;
        }
        public string SetCall(string nombre)
        {
            string call = nombre.ToLower() + "_Set" + this.Identificador
                + "(" + nombre.ToLower() + "_P, " + this.Identificador + "_P);";
            return call;
        }
    }
}
