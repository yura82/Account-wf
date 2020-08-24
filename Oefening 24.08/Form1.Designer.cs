namespace Oefening_24._08
{
    partial class Form1
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
            this.cbWerknemers = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbLand = new System.Windows.Forms.Label();
            this.lbSalarie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbWerknemers
            // 
            this.cbWerknemers.FormattingEnabled = true;
            this.cbWerknemers.Location = new System.Drawing.Point(62, 41);
            this.cbWerknemers.Name = "cbWerknemers";
            this.cbWerknemers.Size = new System.Drawing.Size(121, 24);
            this.cbWerknemers.TabIndex = 0;
            this.cbWerknemers.SelectedIndexChanged += new System.EventHandler(this.cbWernemers_SelectedIndexChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(265, 47);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 17);
            this.lbName.TabIndex = 1;
            // 
            // lbLand
            // 
            this.lbLand.AutoSize = true;
            this.lbLand.Location = new System.Drawing.Point(268, 88);
            this.lbLand.Name = "lbLand";
            this.lbLand.Size = new System.Drawing.Size(0, 17);
            this.lbLand.TabIndex = 2;
            // 
            // lbSalarie
            // 
            this.lbSalarie.AutoSize = true;
            this.lbSalarie.Location = new System.Drawing.Point(267, 134);
            this.lbSalarie.Name = "lbSalarie";
            this.lbSalarie.Size = new System.Drawing.Size(0, 17);
            this.lbSalarie.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSalarie);
            this.Controls.Add(this.lbLand);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.cbWerknemers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWerknemers;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLand;
        private System.Windows.Forms.Label lbSalarie;
    }
}

