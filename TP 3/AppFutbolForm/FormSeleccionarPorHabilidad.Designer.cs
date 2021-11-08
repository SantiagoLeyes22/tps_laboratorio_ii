
namespace AppFutbolForm
{
    partial class FormSeleccionarPorHabilidad
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
            this.lstHabilidadesJ = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstHabilidadesJ
            // 
            this.lstHabilidadesJ.FormattingEnabled = true;
            this.lstHabilidadesJ.ItemHeight = 15;
            this.lstHabilidadesJ.Location = new System.Drawing.Point(13, 13);
            this.lstHabilidadesJ.Name = "lstHabilidadesJ";
            this.lstHabilidadesJ.Size = new System.Drawing.Size(775, 394);
            this.lstHabilidadesJ.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(713, 415);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FormSeleccionarPorHabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 446);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstHabilidadesJ);
            this.Name = "FormSeleccionarPorHabilidad";
            this.Text = "FormSeleccionarPorHabilidad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstHabilidadesJ;
        private System.Windows.Forms.Button btnAgregar;
    }
}