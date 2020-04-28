using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generadora;

namespace FormGeneradora
{
    public partial class Form1 : Form
    {
        private Estructura estructura;
        public Form1()
        {
            InitializeComponent();
            this.estructura = new Estructura();
            this.cboTipo.Items.Add("char");
            this.cboTipo.Items.Add("int");
            this.cboTipo.Items.Add("float");
            this.cboTipo.Items.Add("double");
            this.cboTipo.Items.Add("short");
            this.txtCantidad.Enabled = false;
            this.LimpiarGrilla();
        }

        private void CbArray_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbArray.Checked)
            {
                this.txtCantidad.Enabled = true;
                this.txtCantidad.Text = "50";
            }
            else
            {
                this.txtCantidad.Enabled = false;
            }
        }
        private void LimpiarGrilla()
        {
            this.txtId.Clear();
            this.cbReferencia.Checked = false;
            this.cboTipo.SelectedIndex = 0;
            this.cbArray.Checked = false;
            this.txtCantidad.Text = "0";
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                                        "¿Limpiar grilla?",
                                        "Confirmar", 
                                        MessageBoxButtons.OKCancel);
            if(resultado == DialogResult.OK)
            {
                this.LimpiarGrilla();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (this.VerificarInputs())
            {
                this.estructura.AgregarCampos(new Campo(
                    this.cboTipo.Text,
                    this.txtId.Text,
                    this.cbReferencia.Checked,
                    this.cbArray.Checked,
                    int.Parse(this.txtCantidad.Text)));
                this.LimpiarGrilla();                
            }
            else
            {
                MessageBox.Show("Campos invalidos.","Error",MessageBoxButtons.OK);
            }
            this.MostrarEstructura();
        }
        private bool VerificarInputs()
        {
            bool todoOk = false;
            try
            {
                if (!string.IsNullOrWhiteSpace(this.txtId.Text) &&
                 !string.IsNullOrWhiteSpace(this.cboTipo.Text))
                {
                    todoOk = true;
                    if (this.cbArray.Checked)
                    {
                        if(int.Parse(this.txtCantidad.Text)<= 0)
                        {
                            todoOk = false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return todoOk;
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            this.estructura.Nombre = this.txtNombre.Text;
            this.MostrarEstructura();
        }
        
        private void MostrarEstructura()
        {
            this.lbEjemplo.Items.Clear();
            string[] struc = this.estructura.ToString().Split('\n');//this.estructura.HeadString().Split('\n');
            for(int i = 0; i < struc.Length; i++)
            {
                this.lbEjemplo.Items.Add(struc[i]);
            }
        }

        private void CbReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CbReferencia_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                this.cbReferencia.Checked = !this.cbReferencia.Checked;
            }
        }

        private void CbArray_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                this.cbArray.Checked = !this.cbArray.Checked;
            }
        }

        private void BntCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.estructura.Guardar();
                MessageBox.Show("Los archivos fueron creados con exito. Se encuentran en el escitorio.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error. Por favor pongase en contacto con el creador.");
            }
        }
    }
}
