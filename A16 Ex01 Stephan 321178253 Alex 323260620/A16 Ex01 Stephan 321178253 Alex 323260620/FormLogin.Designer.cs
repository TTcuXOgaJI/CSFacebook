namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    partial class FormLogin
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
            this.buttonSlidePanel = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonDeletFromUsersList = new System.Windows.Forms.Button();
            this.listBoxRememberedUsers = new System.Windows.Forms.ListBox();
            this.checkBoxRememberNewUser = new System.Windows.Forms.CheckBox();
            this.labelRememberedUsers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSlidePanel
            // 
            this.buttonSlidePanel.BackColor = System.Drawing.Color.White;
            this.buttonSlidePanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSlidePanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSlidePanel.Location = new System.Drawing.Point(12, 5);
            this.buttonSlidePanel.Name = "buttonSlidePanel";
            this.buttonSlidePanel.Size = new System.Drawing.Size(132, 46);
            this.buttonSlidePanel.TabIndex = 0;
            this.buttonSlidePanel.Text = "Remembered Users >>";
            this.buttonSlidePanel.UseVisualStyleBackColor = false;
            this.buttonSlidePanel.Click += new System.EventHandler(this.buttonSlidePanel_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(11, 103);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(133, 88);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonDeletFromUsersList
            // 
            this.buttonDeletFromUsersList.BackColor = System.Drawing.Color.White;
            this.buttonDeletFromUsersList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeletFromUsersList.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletFromUsersList.Location = new System.Drawing.Point(176, 145);
            this.buttonDeletFromUsersList.Name = "buttonDeletFromUsersList";
            this.buttonDeletFromUsersList.Size = new System.Drawing.Size(184, 46);
            this.buttonDeletFromUsersList.TabIndex = 2;
            this.buttonDeletFromUsersList.Text = "Delete From List";
            this.buttonDeletFromUsersList.UseVisualStyleBackColor = false;
            // 
            // listBoxRememberedUsers
            // 
            this.listBoxRememberedUsers.FormattingEnabled = true;
            this.listBoxRememberedUsers.Location = new System.Drawing.Point(176, 31);
            this.listBoxRememberedUsers.Name = "listBoxRememberedUsers";
            this.listBoxRememberedUsers.Size = new System.Drawing.Size(184, 108);
            this.listBoxRememberedUsers.TabIndex = 3;
            this.listBoxRememberedUsers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // checkBoxRememberNewUser
            // 
            this.checkBoxRememberNewUser.AutoSize = true;
            this.checkBoxRememberNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(146)))));
            this.checkBoxRememberNewUser.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberNewUser.Location = new System.Drawing.Point(12, 80);
            this.checkBoxRememberNewUser.Name = "checkBoxRememberNewUser";
            this.checkBoxRememberNewUser.Size = new System.Drawing.Size(119, 20);
            this.checkBoxRememberNewUser.TabIndex = 5;
            this.checkBoxRememberNewUser.Text = "Remember Me";
            this.checkBoxRememberNewUser.UseVisualStyleBackColor = false;
            // 
            // labelRememberedUsers
            // 
            this.labelRememberedUsers.AutoSize = true;
            this.labelRememberedUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(146)))));
            this.labelRememberedUsers.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRememberedUsers.Location = new System.Drawing.Point(195, 12);
            this.labelRememberedUsers.Name = "labelRememberedUsers";
            this.labelRememberedUsers.Size = new System.Drawing.Size(133, 16);
            this.labelRememberedUsers.TabIndex = 6;
            this.labelRememberedUsers.Text = "Remembered Users";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A16_Ex01_Stephan_321178253_Alex_323260620.Properties.Resources.LogIn;
            this.ClientSize = new System.Drawing.Size(155, 195);
            this.Controls.Add(this.labelRememberedUsers);
            this.Controls.Add(this.checkBoxRememberNewUser);
            this.Controls.Add(this.listBoxRememberedUsers);
            this.Controls.Add(this.buttonDeletFromUsersList);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonSlidePanel);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSlidePanel;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonDeletFromUsersList;
        private System.Windows.Forms.ListBox listBoxRememberedUsers;
        private System.Windows.Forms.CheckBox checkBoxRememberNewUser;
        private System.Windows.Forms.Label labelRememberedUsers;
    }
}

