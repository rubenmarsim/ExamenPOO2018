namespace SpeedConversorSpecial
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
            this.grpBoxSpecial = new System.Windows.Forms.GroupBox();
            this.btnUnknown = new System.Windows.Forms.Button();
            this.btnShuttle = new System.Windows.Forms.Button();
            this.btnXWings = new System.Windows.Forms.Button();
            this.grpBoxSpecial.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxSpecial
            // 
            this.grpBoxSpecial.Controls.Add(this.btnUnknown);
            this.grpBoxSpecial.Controls.Add(this.btnShuttle);
            this.grpBoxSpecial.Controls.Add(this.btnXWings);
            this.grpBoxSpecial.Location = new System.Drawing.Point(656, 36);
            this.grpBoxSpecial.Name = "grpBoxSpecial";
            this.grpBoxSpecial.Size = new System.Drawing.Size(200, 143);
            this.grpBoxSpecial.TabIndex = 0;
            this.grpBoxSpecial.TabStop = false;
            this.grpBoxSpecial.Text = "Special Calculation";
            // 
            // btnUnknown
            // 
            this.btnUnknown.Location = new System.Drawing.Point(35, 104);
            this.btnUnknown.Name = "btnUnknown";
            this.btnUnknown.Size = new System.Drawing.Size(129, 23);
            this.btnUnknown.TabIndex = 2;
            this.btnUnknown.Text = "Unknown regions";
            this.btnUnknown.UseVisualStyleBackColor = true;
            this.btnUnknown.Click += new System.EventHandler(this.btnUnknown_Click);
            // 
            // btnShuttle
            // 
            this.btnShuttle.Location = new System.Drawing.Point(103, 32);
            this.btnShuttle.Name = "btnShuttle";
            this.btnShuttle.Size = new System.Drawing.Size(91, 23);
            this.btnShuttle.TabIndex = 1;
            this.btnShuttle.Text = "Cargo Shuttle";
            this.btnShuttle.UseVisualStyleBackColor = true;
            this.btnShuttle.Click += new System.EventHandler(this.btnShuttle_Click);
            // 
            // btnXWings
            // 
            this.btnXWings.Location = new System.Drawing.Point(6, 32);
            this.btnXWings.Name = "btnXWings";
            this.btnXWings.Size = new System.Drawing.Size(75, 23);
            this.btnXWings.TabIndex = 0;
            this.btnXWings.Text = "X-Wings";
            this.btnXWings.UseVisualStyleBackColor = true;
            this.btnXWings.Click += new System.EventHandler(this.btnXWings_Click);
            // 
            // frmSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.grpBoxSpecial);
            this.Name = "frmSpeed";
            this.Controls.SetChildIndex(this.grpBoxSpecial, 0);
            this.grpBoxSpecial.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSpecial;
        private System.Windows.Forms.Button btnUnknown;
        private System.Windows.Forms.Button btnShuttle;
        private System.Windows.Forms.Button btnXWings;
    }
}