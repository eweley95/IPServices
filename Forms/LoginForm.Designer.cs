namespace IPService.Forms
{
    partial class LoginForm
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
            textUsername = new TextBox();
            textPassword = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.Font = new Font("Segoe UI", 20F);
            textUsername.Location = new Point(75, 75);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(250, 43);
            textUsername.TabIndex = 0;
            textUsername.Text = "demo";
            textUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Segoe UI", 20F);
            textPassword.Location = new Point(75, 184);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(250, 43);
            textPassword.TabIndex = 1;
            textPassword.Text = "demo123";
            textPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 20F);
            labelUsername.Location = new Point(75, 35);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(142, 37);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 20F);
            labelPassword.Location = new Point(75, 144);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(134, 37);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(125, 277);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 411);
            Controls.Add(button1);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsername;
        private TextBox textPassword;
        private Label labelUsername;
        private Label labelPassword;
        private Button button1;
    }
}