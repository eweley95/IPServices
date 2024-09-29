namespace IPService.Forms
{
    partial class SettingForm
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
            panelIp = new Panel();
            textIpAddress = new TextBox();
            buttonUnblockIp = new Button();
            buttonBlockIp = new Button();
            labelIp = new Label();
            panel1 = new Panel();
            buttonUnblockRegion = new Button();
            buttonBLockRegion = new Button();
            textRegion = new TextBox();
            labelRegion = new Label();
            panelIp.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelIp
            // 
            panelIp.Controls.Add(textIpAddress);
            panelIp.Controls.Add(buttonUnblockIp);
            panelIp.Controls.Add(buttonBlockIp);
            panelIp.Controls.Add(labelIp);
            panelIp.Location = new Point(41, 21);
            panelIp.Name = "panelIp";
            panelIp.Size = new Size(320, 299);
            panelIp.TabIndex = 0;
            // 
            // textIpAddress
            // 
            textIpAddress.Font = new Font("Segoe UI", 20F);
            textIpAddress.Location = new Point(23, 72);
            textIpAddress.Name = "textIpAddress";
            textIpAddress.Size = new Size(262, 43);
            textIpAddress.TabIndex = 4;
            textIpAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonUnblockIp
            // 
            buttonUnblockIp.Font = new Font("Segoe UI", 20F);
            buttonUnblockIp.Location = new Point(70, 209);
            buttonUnblockIp.Name = "buttonUnblockIp";
            buttonUnblockIp.Size = new Size(180, 43);
            buttonUnblockIp.TabIndex = 3;
            buttonUnblockIp.Text = "Unblock IP";
            buttonUnblockIp.UseVisualStyleBackColor = true;
            buttonUnblockIp.Click += buttonUnblockIp_Click;
            // 
            // buttonBlockIp
            // 
            buttonBlockIp.Font = new Font("Segoe UI", 20F);
            buttonBlockIp.Location = new Point(70, 141);
            buttonBlockIp.Name = "buttonBlockIp";
            buttonBlockIp.Size = new Size(180, 43);
            buttonBlockIp.TabIndex = 2;
            buttonBlockIp.Text = "Block IP";
            buttonBlockIp.UseVisualStyleBackColor = true;
            buttonBlockIp.Click += buttonBlockIp_Click;
            // 
            // labelIp
            // 
            labelIp.AutoSize = true;
            labelIp.Font = new Font("Segoe UI", 20F);
            labelIp.Location = new Point(20, 32);
            labelIp.Name = "labelIp";
            labelIp.Size = new Size(146, 37);
            labelIp.TabIndex = 0;
            labelIp.Text = "IP Address:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(buttonUnblockRegion);
            panel1.Controls.Add(buttonBLockRegion);
            panel1.Controls.Add(textRegion);
            panel1.Controls.Add(labelRegion);
            panel1.Location = new Point(421, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 299);
            panel1.TabIndex = 1;
            // 
            // buttonUnblockRegion
            // 
            buttonUnblockRegion.Font = new Font("Segoe UI", 20F);
            buttonUnblockRegion.Location = new Point(50, 203);
            buttonUnblockRegion.Name = "buttonUnblockRegion";
            buttonUnblockRegion.Size = new Size(220, 49);
            buttonUnblockRegion.TabIndex = 3;
            buttonUnblockRegion.Text = "Unblock Region";
            buttonUnblockRegion.UseVisualStyleBackColor = true;
            buttonUnblockRegion.Click += buttonUnblockRegion_Click;
            // 
            // buttonBLockRegion
            // 
            buttonBLockRegion.Font = new Font("Segoe UI", 20F);
            buttonBLockRegion.Location = new Point(51, 141);
            buttonBLockRegion.Name = "buttonBLockRegion";
            buttonBLockRegion.Size = new Size(220, 44);
            buttonBLockRegion.TabIndex = 2;
            buttonBLockRegion.Text = "Block Region";
            buttonBLockRegion.UseVisualStyleBackColor = true;
            buttonBLockRegion.Click += buttonBLockRegion_Click;
            // 
            // textRegion
            // 
            textRegion.Font = new Font("Segoe UI", 18F);
            textRegion.Location = new Point(23, 72);
            textRegion.Name = "textRegion";
            textRegion.Size = new Size(262, 39);
            textRegion.TabIndex = 1;
            textRegion.TextAlign = HorizontalAlignment.Center;
            // 
            // labelRegion
            // 
            labelRegion.AutoSize = true;
            labelRegion.Font = new Font("Segoe UI", 20F);
            labelRegion.Location = new Point(20, 32);
            labelRegion.Name = "labelRegion";
            labelRegion.Size = new Size(106, 37);
            labelRegion.TabIndex = 0;
            labelRegion.Text = "Region:";
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 357);
            Controls.Add(panel1);
            Controls.Add(panelIp);
            Name = "SettingForm";
            Text = "SettingForm";
            panelIp.ResumeLayout(false);
            panelIp.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelIp;
        private Label labelIp;
        private Panel panel1;
        private TextBox textRegion;
        private Label labelRegion;
        private Button buttonUnblockIp;
        private Button buttonBlockIp;
        private Button buttonBLockRegion;
        private Button buttonUnblockRegion;
        private TextBox textIpAddress;
    }
}