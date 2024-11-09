namespace LearnEnglish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signin_bttn = new System.Windows.Forms.Button();
            this.newaccount_bttn = new System.Windows.Forms.Button();
            this.rules_bttn = new System.Windows.Forms.Button();
            this.exit_bttn = new System.Windows.Forms.Button();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Learn English Game!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(284, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(252, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password: ";
            // 
            // signin_bttn
            // 
            this.signin_bttn.Location = new System.Drawing.Point(270, 188);
            this.signin_bttn.Name = "signin_bttn";
            this.signin_bttn.Size = new System.Drawing.Size(114, 35);
            this.signin_bttn.TabIndex = 3;
            this.signin_bttn.Text = "Sign In";
            this.signin_bttn.UseVisualStyleBackColor = true;
            this.signin_bttn.Click += new System.EventHandler(this.signin_bttn_Click);
            // 
            // newaccount_bttn
            // 
            this.newaccount_bttn.Location = new System.Drawing.Point(390, 188);
            this.newaccount_bttn.Name = "newaccount_bttn";
            this.newaccount_bttn.Size = new System.Drawing.Size(156, 35);
            this.newaccount_bttn.TabIndex = 5;
            this.newaccount_bttn.Text = "Create an Account";
            this.newaccount_bttn.UseVisualStyleBackColor = true;
            this.newaccount_bttn.Click += new System.EventHandler(this.newaccount_bttn_Click);
            // 
            // rules_bttn
            // 
            this.rules_bttn.Location = new System.Drawing.Point(350, 229);
            this.rules_bttn.Name = "rules_bttn";
            this.rules_bttn.Size = new System.Drawing.Size(114, 30);
            this.rules_bttn.TabIndex = 6;
            this.rules_bttn.Text = "Rules";
            this.rules_bttn.UseVisualStyleBackColor = true;
            this.rules_bttn.Click += new System.EventHandler(this.rules_bttn_Click);
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.White;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_bttn.Location = new System.Drawing.Point(776, 2);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(33, 27);
            this.exit_bttn.TabIndex = 7;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(364, 104);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(182, 27);
            this.name_txtbox.TabIndex = 1;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(364, 144);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(182, 27);
            this.password_txtbox.TabIndex = 2;
            this.password_txtbox.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(811, 280);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.exit_bttn);
            this.Controls.Add(this.rules_bttn);
            this.Controls.Add(this.newaccount_bttn);
            this.Controls.Add(this.signin_bttn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signin_bttn;
        private System.Windows.Forms.Button newaccount_bttn;
        private System.Windows.Forms.Button rules_bttn;
        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
    }
}

