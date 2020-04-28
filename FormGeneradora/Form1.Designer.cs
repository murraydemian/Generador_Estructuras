namespace FormGeneradora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCampo = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbArray = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbReferencia = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lbEjemplo = new System.Windows.Forms.ListBox();
            this.bntCrear = new System.Windows.Forms.Button();
            this.gbCampo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre estructura";
            // 
            // gbCampo
            // 
            this.gbCampo.Controls.Add(this.txtCantidad);
            this.gbCampo.Controls.Add(this.btnAgregar);
            this.gbCampo.Controls.Add(this.btnLimpiar);
            this.gbCampo.Controls.Add(this.label6);
            this.gbCampo.Controls.Add(this.label5);
            this.gbCampo.Controls.Add(this.cbArray);
            this.gbCampo.Controls.Add(this.label4);
            this.gbCampo.Controls.Add(this.cbReferencia);
            this.gbCampo.Controls.Add(this.label3);
            this.gbCampo.Controls.Add(this.txtId);
            this.gbCampo.Controls.Add(this.label2);
            this.gbCampo.Controls.Add(this.cboTipo);
            this.gbCampo.Location = new System.Drawing.Point(12, 65);
            this.gbCampo.Name = "gbCampo";
            this.gbCampo.Size = new System.Drawing.Size(249, 373);
            this.gbCampo.TabIndex = 2;
            this.gbCampo.TabStop = false;
            this.gbCampo.Text = "Crear campo";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(79, 130);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(156, 20);
            this.txtCantidad.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(160, 344);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(9, 344);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Es array";
            // 
            // cbArray
            // 
            this.cbArray.AutoSize = true;
            this.cbArray.Location = new System.Drawing.Point(79, 111);
            this.cbArray.Name = "cbArray";
            this.cbArray.Size = new System.Drawing.Size(15, 14);
            this.cbArray.TabIndex = 9;
            this.cbArray.UseVisualStyleBackColor = true;
            this.cbArray.CheckedChanged += new System.EventHandler(this.CbArray_CheckedChanged);
            this.cbArray.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbArray_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Es referencia";
            // 
            // cbReferencia
            // 
            this.cbReferencia.AutoSize = true;
            this.cbReferencia.Location = new System.Drawing.Point(79, 91);
            this.cbReferencia.Name = "cbReferencia";
            this.cbReferencia.Size = new System.Drawing.Size(15, 14);
            this.cbReferencia.TabIndex = 7;
            this.cbReferencia.UseVisualStyleBackColor = true;
            this.cbReferencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbReferencia_KeyDown);
            this.cbReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbReferencia_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Identificador";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(79, 65);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(156, 20);
            this.txtId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de dato";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(79, 38);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(156, 21);
            this.cboTipo.TabIndex = 3;
            // 
            // lbEjemplo
            // 
            this.lbEjemplo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbEjemplo.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbEjemplo.FormattingEnabled = true;
            this.lbEjemplo.Location = new System.Drawing.Point(280, 10);
            this.lbEjemplo.Name = "lbEjemplo";
            this.lbEjemplo.Size = new System.Drawing.Size(1042, 433);
            this.lbEjemplo.TabIndex = 3;
            // 
            // bntCrear
            // 
            this.bntCrear.Location = new System.Drawing.Point(172, 27);
            this.bntCrear.Name = "bntCrear";
            this.bntCrear.Size = new System.Drawing.Size(75, 23);
            this.bntCrear.TabIndex = 4;
            this.bntCrear.Text = "Crear";
            this.bntCrear.UseVisualStyleBackColor = true;
            this.bntCrear.Click += new System.EventHandler(this.BntCrear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 450);
            this.Controls.Add(this.bntCrear);
            this.Controls.Add(this.lbEjemplo);
            this.Controls.Add(this.gbCampo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCampo.ResumeLayout(false);
            this.gbCampo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCampo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbArray;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbReferencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ListBox lbEjemplo;
        private System.Windows.Forms.Button bntCrear;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}

