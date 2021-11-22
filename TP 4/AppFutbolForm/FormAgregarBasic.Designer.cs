
namespace AppFutbolForm
{
    partial class FormAgregarBasic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtEdadP = new System.Windows.Forms.TextBox();
            this.txtCantPatidosJugadosP = new System.Windows.Forms.TextBox();
            this.cmbPosicion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(181, 469);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad partidos jugados:";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(12, 32);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(171, 23);
            this.txtNombreP.TabIndex = 6;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(12, 86);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(171, 23);
            this.txtApellidoP.TabIndex = 7;
            // 
            // txtEdadP
            // 
            this.txtEdadP.Location = new System.Drawing.Point(12, 146);
            this.txtEdadP.Name = "txtEdadP";
            this.txtEdadP.Size = new System.Drawing.Size(171, 23);
            this.txtEdadP.TabIndex = 8;
            // 
            // txtCantPatidosJugadosP
            // 
            this.txtCantPatidosJugadosP.Location = new System.Drawing.Point(12, 199);
            this.txtCantPatidosJugadosP.Name = "txtCantPatidosJugadosP";
            this.txtCantPatidosJugadosP.Size = new System.Drawing.Size(171, 23);
            this.txtCantPatidosJugadosP.TabIndex = 9;
            // 
            // cmbPosicion
            // 
            this.cmbPosicion.FormattingEnabled = true;
            this.cmbPosicion.Location = new System.Drawing.Point(12, 259);
            this.cmbPosicion.Name = "cmbPosicion";
            this.cmbPosicion.Size = new System.Drawing.Size(171, 23);
            this.cmbPosicion.TabIndex = 10;
            this.cmbPosicion.SelectedIndexChanged += new System.EventHandler(this.cmbPosicion_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Posicion ";
            // 
            // FormAgregarBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 504);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPosicion);
            this.Controls.Add(this.txtCantPatidosJugadosP);
            this.Controls.Add(this.txtEdadP);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FormAgregarBasic";
            this.Text = "Agregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txtNombreP;
        protected System.Windows.Forms.TextBox txtApellidoP;
        protected System.Windows.Forms.TextBox txtEdadP;
        protected System.Windows.Forms.TextBox txtCantPatidosJugadosP;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbPosicion;
        private System.Windows.Forms.Label label5;
    }
}