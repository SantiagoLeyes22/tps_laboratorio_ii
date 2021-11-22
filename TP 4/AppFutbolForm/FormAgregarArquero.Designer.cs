
namespace AppFutbolForm
{
    partial class FormAgregarArquero
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
            this.txtVallasInvictas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPenalesAtajados = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalPenales = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad vallas invictas:";
            // 
            // txtVallasInvictas
            // 
            this.txtVallasInvictas.Location = new System.Drawing.Point(12, 315);
            this.txtVallasInvictas.Name = "txtVallasInvictas";
            this.txtVallasInvictas.Size = new System.Drawing.Size(171, 23);
            this.txtVallasInvictas.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Numero de penales atajados:";
            // 
            // txtPenalesAtajados
            // 
            this.txtPenalesAtajados.Location = new System.Drawing.Point(10, 359);
            this.txtPenalesAtajados.Name = "txtPenalesAtajados";
            this.txtPenalesAtajados.Size = new System.Drawing.Size(171, 23);
            this.txtPenalesAtajados.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Numero de penales que le patearon:";
            // 
            // txtTotalPenales
            // 
            this.txtTotalPenales.Location = new System.Drawing.Point(10, 414);
            this.txtTotalPenales.Name = "txtTotalPenales";
            this.txtTotalPenales.Size = new System.Drawing.Size(171, 23);
            this.txtTotalPenales.TabIndex = 16;
            // 
            // FormAgregarArquero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 504);
            this.Controls.Add(this.txtTotalPenales);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPenalesAtajados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVallasInvictas);
            this.Controls.Add(this.label6);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormAgregarArquero";
            this.Text = "AgregarArquero";
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.txtNombreP, 0);
            this.Controls.SetChildIndex(this.txtCantPatidosJugadosP, 0);
            this.Controls.SetChildIndex(this.txtEdadP, 0);
            this.Controls.SetChildIndex(this.txtApellidoP, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtVallasInvictas, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtPenalesAtajados, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtTotalPenales, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVallasInvictas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPenalesAtajados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalPenales;
    }
}