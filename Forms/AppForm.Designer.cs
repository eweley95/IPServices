namespace IPService.Forms
{
    partial class AppForm
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
            labelIpAddress = new Label();
            textIpAddress = new TextBox();
            labelRegion = new Label();
            textRegion = new TextBox();
            labelStatus = new Label();
            textStatus = new TextBox();
            SuspendLayout();
            // 
            // labelIpAddress
            // 
            labelIpAddress.AutoSize = true;
            labelIpAddress.Font = new Font("Segoe UI", 20F);
            labelIpAddress.Location = new Point(34, 42);
            labelIpAddress.Name = "labelIpAddress";
            labelIpAddress.Size = new Size(146, 37);
            labelIpAddress.TabIndex = 0;
            labelIpAddress.Text = "IP Address:";
            // 
            // textIpAddress
            // 
            textIpAddress.Font = new Font("Segoe UI", 20F);
            textIpAddress.Location = new Point(197, 36);
            textIpAddress.Name = "textIpAddress";
            textIpAddress.ReadOnly = true;
            textIpAddress.Size = new Size(287, 43);
            textIpAddress.TabIndex = 1;
            textIpAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // labelRegion
            // 
            labelRegion.AutoSize = true;
            labelRegion.Font = new Font("Segoe UI", 20F);
            labelRegion.Location = new Point(34, 101);
            labelRegion.Name = "labelRegion";
            labelRegion.Size = new Size(106, 37);
            labelRegion.TabIndex = 2;
            labelRegion.Text = "Region:";
            // 
            // textRegion
            // 
            textRegion.Font = new Font("Segoe UI", 20F);
            textRegion.Location = new Point(197, 96);
            textRegion.Name = "textRegion";
            textRegion.ReadOnly = true;
            textRegion.Size = new Size(287, 43);
            textRegion.TabIndex = 3;
            textRegion.TextAlign = HorizontalAlignment.Center;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 20F);
            labelStatus.Location = new Point(34, 163);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(94, 37);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Status:";
            // 
            // textStatus
            // 
            textStatus.Font = new Font("Segoe UI", 20F);
            textStatus.Location = new Point(197, 161);
            textStatus.Name = "textStatus";
            textStatus.ReadOnly = true;
            textStatus.Size = new Size(287, 43);
            textStatus.TabIndex = 5;
            textStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 257);
            Controls.Add(textStatus);
            Controls.Add(labelStatus);
            Controls.Add(textRegion);
            Controls.Add(labelRegion);
            Controls.Add(textIpAddress);
            Controls.Add(labelIpAddress);
            Name = "AppForm";
            Text = "AppForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIpAddress;
        private TextBox textIpAddress;
        private Label labelRegion;
        private TextBox textRegion;
        private Label labelStatus;
        private TextBox textStatus;
    }
}