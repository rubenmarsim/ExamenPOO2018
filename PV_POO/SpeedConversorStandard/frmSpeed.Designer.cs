namespace SpeedConversorStandard
{
    partial class frmSpeed
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
            this.lblParsecs = new System.Windows.Forms.Label();
            this.txtBoxParsecs = new System.Windows.Forms.TextBox();
            this.grpBoxCalculation = new System.Windows.Forms.GroupBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.speedControl1 = new ControlsPOO.SpeedControl();
            this.grpBoxCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblParsecs
            // 
            this.lblParsecs.AutoSize = true;
            this.lblParsecs.Location = new System.Drawing.Point(31, 52);
            this.lblParsecs.Name = "lblParsecs";
            this.lblParsecs.Size = new System.Drawing.Size(84, 13);
            this.lblParsecs.TabIndex = 1;
            this.lblParsecs.Text = "Speed (parsecs)";
            // 
            // txtBoxParsecs
            // 
            this.txtBoxParsecs.Location = new System.Drawing.Point(130, 52);
            this.txtBoxParsecs.Name = "txtBoxParsecs";
            this.txtBoxParsecs.Size = new System.Drawing.Size(100, 20);
            this.txtBoxParsecs.TabIndex = 2;
            // 
            // grpBoxCalculation
            // 
            this.grpBoxCalculation.Controls.Add(this.btnConvert);
            this.grpBoxCalculation.Location = new System.Drawing.Point(414, 36);
            this.grpBoxCalculation.Name = "grpBoxCalculation";
            this.grpBoxCalculation.Size = new System.Drawing.Size(200, 100);
            this.grpBoxCalculation.TabIndex = 3;
            this.grpBoxCalculation.TabStop = false;
            this.grpBoxCalculation.Text = "Standard Calculation";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(57, 51);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert Speed";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // speedControl1
            // 
            this.speedControl1.Location = new System.Drawing.Point(33, 75);
            this.speedControl1.Name = "speedControl1";
            this.speedControl1.Size = new System.Drawing.Size(320, 102);
            this.speedControl1.TabIndex = 0;
            this.speedControl1.Valor = 0;
            // 
            // frmSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxCalculation);
            this.Controls.Add(this.txtBoxParsecs);
            this.Controls.Add(this.lblParsecs);
            this.Controls.Add(this.speedControl1);
            this.Name = "frmSpeed";
            this.Text = "frmSpeed";
            this.grpBoxCalculation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblParsecs;
        private System.Windows.Forms.GroupBox grpBoxCalculation;
        private System.Windows.Forms.Button btnConvert;
        public System.Windows.Forms.TextBox txtBoxParsecs;
        public ControlsPOO.SpeedControl speedControl1;
    }
}