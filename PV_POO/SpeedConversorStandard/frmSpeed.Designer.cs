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
            this.speedControl1 = new ControlsPOO.SpeedControl();
            this.SuspendLayout();
            // 
            // speedControl1
            // 
            this.speedControl1.Location = new System.Drawing.Point(81, 207);
            this.speedControl1.Name = "speedControl1";
            this.speedControl1.Size = new System.Drawing.Size(320, 102);
            this.speedControl1.TabIndex = 0;
            this.speedControl1.Valor = "0";
            // 
            // frmSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.speedControl1);
            this.Name = "frmSpeed";
            this.Text = "frmSpeed";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsPOO.SpeedControl speedControl1;
    }
}