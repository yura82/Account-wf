namespace Account_wf
{
    partial class NewAccountForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbLasctName = new System.Windows.Forms.Label();
            this.cbAccountTipe = new System.Windows.Forms.ComboBox();
            this.lbAccountTipe = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(97, 85);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 17);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "NAME";
            // 
            // lbLasctName
            // 
            this.lbLasctName.AutoSize = true;
            this.lbLasctName.Location = new System.Drawing.Point(91, 128);
            this.lbLasctName.Name = "lbLasctName";
            this.lbLasctName.Size = new System.Drawing.Size(86, 17);
            this.lbLasctName.TabIndex = 1;
            this.lbLasctName.Text = "LAST NAME";
            // 
            // cbAccountTipe
            // 
            this.cbAccountTipe.FormattingEnabled = true;
            this.cbAccountTipe.Location = new System.Drawing.Point(183, 167);
            this.cbAccountTipe.Name = "cbAccountTipe";
            this.cbAccountTipe.Size = new System.Drawing.Size(121, 24);
            this.cbAccountTipe.TabIndex = 2;
            // 
            // lbAccountTipe
            // 
            this.lbAccountTipe.AutoSize = true;
            this.lbAccountTipe.Location = new System.Drawing.Point(100, 173);
            this.lbAccountTipe.Name = "lbAccountTipe";
            this.lbAccountTipe.Size = new System.Drawing.Size(75, 17);
            this.lbAccountTipe.TabIndex = 3;
            this.lbAccountTipe.Text = "ACCOUNT";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 5;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(384, 199);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 23);
            this.btCreate.TabIndex = 6;
            this.btCreate.Text = "CREATE";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // NewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbAccountTipe);
            this.Controls.Add(this.cbAccountTipe);
            this.Controls.Add(this.lbLasctName);
            this.Controls.Add(this.lbName);
            this.Name = "NewAccountForm";
            this.Text = "NewAccountForm";
            this.Load += new System.EventHandler(this.NewAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLasctName;
        private System.Windows.Forms.ComboBox cbAccountTipe;
        private System.Windows.Forms.Label lbAccountTipe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btCreate;
    }
}