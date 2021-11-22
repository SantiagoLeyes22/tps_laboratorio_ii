
namespace AppFutbolForm
{
    partial class FormConsultas
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
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.btnPQuites = new System.Windows.Forms.Button();
            this.btnPPASES = new System.Windows.Forms.Button();
            this.btnPGoles = new System.Windows.Forms.Button();
            this.progressConsulta = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPorcentajeProgreso = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(23, 22);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(607, 394);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = "";
            // 
            // btnPQuites
            // 
            this.btnPQuites.Location = new System.Drawing.Point(635, 108);
            this.btnPQuites.Name = "btnPQuites";
            this.btnPQuites.Size = new System.Drawing.Size(152, 23);
            this.btnPQuites.TabIndex = 2;
            this.btnPQuites.Text = "Porcentaje quites";
            this.btnPQuites.UseVisualStyleBackColor = true;
            this.btnPQuites.Click += new System.EventHandler(this.btnPQuites_Click);
            // 
            // btnPPASES
            // 
            this.btnPPASES.Location = new System.Drawing.Point(635, 146);
            this.btnPPASES.Name = "btnPPASES";
            this.btnPPASES.Size = new System.Drawing.Size(152, 23);
            this.btnPPASES.TabIndex = 3;
            this.btnPPASES.Text = "Porcentaje de pases";
            this.btnPPASES.UseVisualStyleBackColor = true;
            this.btnPPASES.Click += new System.EventHandler(this.btnPPASES_Click);
            // 
            // btnPGoles
            // 
            this.btnPGoles.Location = new System.Drawing.Point(635, 69);
            this.btnPGoles.Name = "btnPGoles";
            this.btnPGoles.Size = new System.Drawing.Size(152, 23);
            this.btnPGoles.TabIndex = 4;
            this.btnPGoles.Text = "Porcentaje de Goles";
            this.btnPGoles.UseVisualStyleBackColor = true;
            this.btnPGoles.Click += new System.EventHandler(this.btnPGoles_Click);
            // 
            // progressConsulta
            // 
            this.progressConsulta.Location = new System.Drawing.Point(636, 40);
            this.progressConsulta.Name = "progressConsulta";
            this.progressConsulta.Size = new System.Drawing.Size(151, 23);
            this.progressConsulta.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calculando consultas";
            // 
            // lblPorcentajeProgreso
            // 
            this.lblPorcentajeProgreso.AutoSize = true;
            this.lblPorcentajeProgreso.Location = new System.Drawing.Point(793, 48);
            this.lblPorcentajeProgreso.Name = "lblPorcentajeProgreso";
            this.lblPorcentajeProgreso.Size = new System.Drawing.Size(38, 15);
            this.lblPorcentajeProgreso.TabIndex = 7;
            this.lblPorcentajeProgreso.Text = "label2";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(747, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblPorcentajeProgreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressConsulta);
            this.Controls.Add(this.btnPGoles);
            this.Controls.Add(this.btnPPASES);
            this.Controls.Add(this.btnPQuites);
            this.Controls.Add(this.rtbTexto);
            this.Name = "FormConsultas";
            this.Text = "FormConsultas";
            this.Load += new System.EventHandler(this.FormConsultas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.Button btnPQuites;
        private System.Windows.Forms.Button btnPPASES;
        private System.Windows.Forms.Button btnPGoles;
        private System.Windows.Forms.ProgressBar progressConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPorcentajeProgreso;
        private System.Windows.Forms.Button btnSalir;
    }
}