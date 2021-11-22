
namespace AppFutbolForm
{
    partial class FormAgregarDefensor
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtDistanciaRecorrida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoDefensor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalQuites = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuitesCorrectos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 6);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 60);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 120);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 173);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Distancia recorrida:";
            // 
            // txtDistanciaRecorrida
            // 
            this.txtDistanciaRecorrida.Location = new System.Drawing.Point(12, 242);
            this.txtDistanciaRecorrida.Multiline = true;
            this.txtDistanciaRecorrida.Name = "txtDistanciaRecorrida";
            this.txtDistanciaRecorrida.Size = new System.Drawing.Size(171, 23);
            this.txtDistanciaRecorrida.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo de defensor:";
            // 
            // cmbTipoDefensor
            // 
            this.cmbTipoDefensor.FormattingEnabled = true;
            this.cmbTipoDefensor.Location = new System.Drawing.Point(12, 297);
            this.cmbTipoDefensor.Name = "cmbTipoDefensor";
            this.cmbTipoDefensor.Size = new System.Drawing.Size(171, 23);
            this.cmbTipoDefensor.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Intentos quites:";
            // 
            // txtTotalQuites
            // 
            this.txtTotalQuites.Location = new System.Drawing.Point(12, 351);
            this.txtTotalQuites.Name = "txtTotalQuites";
            this.txtTotalQuites.Size = new System.Drawing.Size(171, 23);
            this.txtTotalQuites.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Quites correctos:";
            // 
            // txtQuitesCorrectos
            // 
            this.txtQuitesCorrectos.Location = new System.Drawing.Point(12, 406);
            this.txtQuitesCorrectos.Name = "txtQuitesCorrectos";
            this.txtQuitesCorrectos.Size = new System.Drawing.Size(171, 23);
            this.txtQuitesCorrectos.TabIndex = 18;
            // 
            // FormAgregarDefensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 504);
            this.Controls.Add(this.txtQuitesCorrectos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalQuites);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTipoDefensor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDistanciaRecorrida);
            this.Controls.Add(this.label6);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormAgregarDefensor";
            this.Text = "FormAgregarDefensor";
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtCantPatidosJugados, 0);
            this.Controls.SetChildIndex(this.txtEdad, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtDistanciaRecorrida, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cmbTipoDefensor, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtTotalQuites, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtQuitesCorrectos, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDistanciaRecorrida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoDefensor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalQuites;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuitesCorrectos;
    }
}