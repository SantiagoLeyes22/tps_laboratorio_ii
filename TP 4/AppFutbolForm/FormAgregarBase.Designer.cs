
namespace AppFutbolForm
{
    partial class FormAgregarBase
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
            this.lblPos = new System.Windows.Forms.Label();
            this.cmbPosicion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(13, 28);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(55, 15);
            this.lblPos.TabIndex = 0;
            this.lblPos.Text = "Posición ";
            // 
            // cmbPosicion
            // 
            this.cmbPosicion.FormattingEnabled = true;
            this.cmbPosicion.Location = new System.Drawing.Point(13, 59);
            this.cmbPosicion.Name = "cmbPosicion";
            this.cmbPosicion.Size = new System.Drawing.Size(260, 23);
            this.cmbPosicion.TabIndex = 1;
            this.cmbPosicion.SelectedIndexChanged += new System.EventHandler(this.cmbPosicion_SelectedIndexChanged);
            // 
            // FormAgregarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 122);
            this.Controls.Add(this.cmbPosicion);
            this.Controls.Add(this.lblPos);
            this.Name = "FormAgregarBase";
            this.Text = "FormAgregarBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.ComboBox cmbPosicion;
    }
}