namespace oef_24
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
            this.lbxWorkers = new System.Windows.Forms.ListBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSalarie = new System.Windows.Forms.Label();
            this.lbLand = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxWorkers
            // 
            this.lbxWorkers.FormattingEnabled = true;
            this.lbxWorkers.ItemHeight = 16;
            this.lbxWorkers.Location = new System.Drawing.Point(84, 64);
            this.lbxWorkers.Name = "lbxWorkers";
            this.lbxWorkers.Size = new System.Drawing.Size(120, 84);
            this.lbxWorkers.TabIndex = 0;
            this.lbxWorkers.SelectedIndexChanged += new System.EventHandler(this.lbxWorkers_SelectedIndexChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(319, 54);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(46, 17);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label1";
            // 
            // lbSalarie
            // 
            this.lbSalarie.AutoSize = true;
            this.lbSalarie.Location = new System.Drawing.Point(319, 96);
            this.lbSalarie.Name = "lbSalarie";
            this.lbSalarie.Size = new System.Drawing.Size(46, 17);
            this.lbSalarie.TabIndex = 2;
            this.lbSalarie.Text = "label2";
            // 
            // lbLand
            // 
            this.lbLand.AutoSize = true;
            this.lbLand.Location = new System.Drawing.Point(319, 131);
            this.lbLand.Name = "lbLand";
            this.lbLand.Size = new System.Drawing.Size(46, 17);
            this.lbLand.TabIndex = 3;
            this.lbLand.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salarie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Land";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLand);
            this.Controls.Add(this.lbSalarie);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbxWorkers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxWorkers;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSalarie;
        private System.Windows.Forms.Label lbLand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

