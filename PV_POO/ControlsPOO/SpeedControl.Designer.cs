namespace ControlsPOO
{
    partial class SpeedControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txtBoxSpeed = new System.Windows.Forms.TextBox();
            this.pctBoxSpeed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(4, 36);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(72, 13);
            this.lblSpeed.TabIndex = 0;
            this.lblSpeed.Text = "Speed (Km/s)";
            // 
            // txtBoxSpeed
            // 
            this.txtBoxSpeed.Location = new System.Drawing.Point(95, 33);
            this.txtBoxSpeed.Name = "txtBoxSpeed";
            this.txtBoxSpeed.ReadOnly = true;
            this.txtBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSpeed.TabIndex = 1;
            this.txtBoxSpeed.TextChanged += new System.EventHandler(this.txtBoxSpeed_TextChanged);
            // 
            // pctBoxSpeed
            // 
            this.pctBoxSpeed.BackColor = System.Drawing.Color.Black;
            this.pctBoxSpeed.Image = global::ControlsPOO.Properties.Resources.unknown;
            this.pctBoxSpeed.Location = new System.Drawing.Point(215, 3);
            this.pctBoxSpeed.Name = "pctBoxSpeed";
            this.pctBoxSpeed.Size = new System.Drawing.Size(98, 90);
            this.pctBoxSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxSpeed.TabIndex = 2;
            this.pctBoxSpeed.TabStop = false;
            // 
            // SpeedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pctBoxSpeed);
            this.Controls.Add(this.txtBoxSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Name = "SpeedControl";
            this.Size = new System.Drawing.Size(320, 102);
            this.Load += new System.EventHandler(this.SpeedControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.PictureBox pctBoxSpeed;
        public System.Windows.Forms.TextBox txtBoxSpeed;
    }
}
