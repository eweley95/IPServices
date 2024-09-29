namespace IPService.Forms
{
    partial class MainForm
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
            buttonLoginForm = new Button();
            buttonAppForm = new Button();
            SuspendLayout();
            // 
            // buttonLoginForm
            // 
            buttonLoginForm.Font = new Font("Segoe UI", 20F);
            buttonLoginForm.Location = new Point(100, 55);
            buttonLoginForm.Name = "buttonLoginForm";
            buttonLoginForm.Size = new Size(200, 70);
            buttonLoginForm.TabIndex = 0;
            buttonLoginForm.Text = "Login";
            buttonLoginForm.UseVisualStyleBackColor = true;
            buttonLoginForm.Click += buttonLoginForm_Click;
            // 
            // buttonAppForm
            // 
            buttonAppForm.Font = new Font("Segoe UI", 20F);
            buttonAppForm.Location = new Point(100, 181);
            buttonAppForm.Name = "buttonAppForm";
            buttonAppForm.Size = new Size(200, 70);
            buttonAppForm.TabIndex = 1;
            buttonAppForm.Text = "App";
            buttonAppForm.UseVisualStyleBackColor = true;
            buttonAppForm.Click += buttonAppForm_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 411);
            Controls.Add(buttonAppForm);
            Controls.Add(buttonLoginForm);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLoginForm;
        private Button buttonAppForm;
    }
}