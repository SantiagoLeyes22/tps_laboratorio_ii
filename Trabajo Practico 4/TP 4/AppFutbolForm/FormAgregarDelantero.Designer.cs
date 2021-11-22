
namespace AppFutbolForm
{
    partial class FormAgregarDelantero
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
            this.txtCantGoles = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalRegates = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRegatesCorrectos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad de goles:";
            // 
            // txtCantGoles
            // 
            this.txtCantGoles.Location = new System.Drawing.Point(12, 253);
            this.txtCantGoles.Name = "txtCantGoles";
            this.txtCantGoles.Size = new System.Drawing.Size(171, 23);
            this.txtCantGoles.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total regates intentados:";
            // 
            // txtTotalRegates
            // 
            this.txtTotalRegates.Location = new System.Drawing.Point(12, 308);
            this.txtTotalRegates.Name = "txtTotalRegates";
            this.txtTotalRegates.Size = new System.Drawing.Size(171, 23);
            this.txtTotalRegates.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cantidad regates correctos:";
            // 
            // txtRegatesCorrectos
            // 
            this.txtRegatesCorrectos.Location = new System.Drawing.Point(12, 361);
            this.txtRegatesCorrectos.Name = "txtRegatesCorrectos";
            this.txtRegatesCorrectos.Size = new System.Drawing.Size(171, 23);
            this.txtRegatesCorrectos.TabIndex = 16;
            // 
            // FormAgregarDelantero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 504);
            this.Controls.Add(this.txtRegatesCorrectos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalRegates);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCantGoles);
            this.Controls.Add(this.label6);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormAgregarDelantero";
            this.Text = "FormAgregarDelantero";
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
            this.Controls.SetChildIndex(this.txtCantGoles, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtTotalRegates, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtRegatesCorrectos, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantGoles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalRegates;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRegatesCorrectos;
    }
}