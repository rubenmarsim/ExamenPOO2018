namespace PV_POO
{
    partial class frmMain
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
            this.btnSCStandard = new System.Windows.Forms.Button();
            this.btnSCSpecial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSCStandard
            // 
            this.btnSCStandard.Location = new System.Drawing.Point(239, 160);
            this.btnSCStandard.Name = "btnSCStandard";
            this.btnSCStandard.Size = new System.Drawing.Size(92, 51);
            this.btnSCStandard.TabIndex = 0;
            this.btnSCStandard.Text = "Speed Conversor Standard";
            this.btnSCStandard.UseVisualStyleBackColor = true;
            this.btnSCStandard.Click += new System.EventHandler(this.btnSCStandard_Click);
            // 
            // btnSCSpecial
            // 
            this.btnSCSpecial.Location = new System.Drawing.Point(376, 160);
            this.btnSCSpecial.Name = "btnSCSpecial";
            this.btnSCSpecial.Size = new System.Drawing.Size(86, 51);
            this.btnSCSpecial.TabIndex = 1;
            this.btnSCSpecial.Text = "Speed Conversor Special";
            this.btnSCSpecial.UseVisualStyleBackColor = true;
            this.btnSCSpecial.Click += new System.EventHandler(this.btnSCSpecial_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSCSpecial);
            this.Controls.Add(this.btnSCStandard);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSCStandard;
        private System.Windows.Forms.Button btnSCSpecial;
    }
}

