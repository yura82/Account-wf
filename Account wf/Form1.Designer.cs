namespace Account_wf
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
            this.btNewAccount = new System.Windows.Forms.Button();
            this.btCheckAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNewAccount
            // 
            this.btNewAccount.Location = new System.Drawing.Point(205, 121);
            this.btNewAccount.Name = "btNewAccount";
            this.btNewAccount.Size = new System.Drawing.Size(138, 23);
            this.btNewAccount.TabIndex = 0;
            this.btNewAccount.Text = "NEW ACCOUNT";
            this.btNewAccount.UseVisualStyleBackColor = true;
            this.btNewAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCheckAccount
            // 
            this.btCheckAccount.Location = new System.Drawing.Point(470, 121);
            this.btCheckAccount.Name = "btCheckAccount";
            this.btCheckAccount.Size = new System.Drawing.Size(75, 23);
            this.btCheckAccount.TabIndex = 1;
            this.btCheckAccount.Text = "CHECK";
            this.btCheckAccount.UseVisualStyleBackColor = true;
            this.btCheckAccount.Click += new System.EventHandler(this.btCheckAccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCheckAccount);
            this.Controls.Add(this.btNewAccount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNewAccount;
        private System.Windows.Forms.Button btCheckAccount;
    }
}

