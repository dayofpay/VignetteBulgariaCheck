namespace ViggneteCheckBG
{
    partial class katResult
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(katResult));
            this.bordForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.mainPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.closeButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.info = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // bordForm
            // 
            this.bordForm.AnimateWindow = true;
            this.bordForm.ContainerControl = this;
            this.bordForm.DockIndicatorTransparencyValue = 0.6D;
            this.bordForm.TransparentWhileDrag = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.BorderColor = System.Drawing.Color.Gray;
            this.mainPanel.BorderRadius = 5;
            this.mainPanel.BorderThickness = 2;
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Controls.Add(this.info);
            this.mainPanel.Controls.Add(this.img);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShowBorders = true;
            this.mainPanel.Size = new System.Drawing.Size(468, 139);
            this.mainPanel.TabIndex = 8;
            this.mainPanel.Click += new System.EventHandler(this.mainPanel_Click);
            // 
            // closeButton
            // 
            this.closeButton.BorderRadius = 7;
            this.closeButton.CheckedState.Parent = this.closeButton;
            this.closeButton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 55, 1);
            this.closeButton.CustomImages.Parent = this.closeButton;
            this.closeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeButton.DisabledState.Parent = this.closeButton;
            this.closeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.closeButton.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Aqua;
            this.closeButton.HoverState.Parent = this.closeButton;
            this.closeButton.Location = new System.Drawing.Point(3, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.ShadowDecoration.Parent = this.closeButton;
            this.closeButton.Size = new System.Drawing.Size(107, 26);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "ЗАТВОРИ";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(161, 88);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(112, 14);
            this.info.TabIndex = 9;
            this.info.Text = "Невалидни данни";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // img
            // 
            this.img.Image = global::ViggneteCheckBG.Properties.Resources.id_not_verified_40px;
            this.img.Location = new System.Drawing.Point(164, 3);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(78, 64);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 0;
            this.img.TabStop = false;
            this.img.Click += new System.EventHandler(this.img_Click);
            // 
            // katResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(492, 163);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "katResult";
            this.Text = "Резултат за глоби от КАТ";
            this.Load += new System.EventHandler(this.katResult_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm bordForm;
        private Bunifu.UI.WinForms.BunifuPanel mainPanel;
        private System.Windows.Forms.Label info;
        public System.Windows.Forms.PictureBox img;
        private Guna.UI2.WinForms.Guna2GradientButton closeButton;
    }
}