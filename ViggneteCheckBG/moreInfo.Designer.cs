namespace ViggneteCheckBG
{
    partial class moreInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(moreInfo));
            this.bord = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.closeButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.mainPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.emisions = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bord
            // 
            this.bord.AnimateWindow = true;
            this.bord.ContainerControl = this;
            this.bord.DockIndicatorTransparencyValue = 0.6D;
            this.bord.TransparentWhileDrag = true;
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
            this.closeButton.Location = new System.Drawing.Point(227, 327);
            this.closeButton.Name = "closeButton";
            this.closeButton.ShadowDecoration.Parent = this.closeButton;
            this.closeButton.Size = new System.Drawing.Size(249, 31);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "ЗАТВОРИ";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.BorderColor = System.Drawing.Color.Gray;
            this.mainPanel.BorderRadius = 5;
            this.mainPanel.BorderThickness = 2;
            this.mainPanel.Controls.Add(this.bunifuPanel2);
            this.mainPanel.Location = new System.Drawing.Point(4, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShowBorders = true;
            this.mainPanel.Size = new System.Drawing.Size(722, 303);
            this.mainPanel.TabIndex = 7;
            this.mainPanel.Visible = false;
            this.mainPanel.Click += new System.EventHandler(this.mainPanel_Click);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.label3);
            this.bunifuPanel2.Controls.Add(this.emisions);
            this.bunifuPanel2.Controls.Add(this.pictureBox1);
            this.bunifuPanel2.Location = new System.Drawing.Point(37, 9);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(187, 112);
            this.bunifuPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Клас на емисиите:";
            // 
            // emisions
            // 
            this.emisions.AutoSize = true;
            this.emisions.Location = new System.Drawing.Point(32, 88);
            this.emisions.Name = "emisions";
            this.emisions.Size = new System.Drawing.Size(84, 14);
            this.emisions.TabIndex = 1;
            this.emisions.Text = "${response}";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ViggneteCheckBG.Properties.Resources.co2_64px;
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // moreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(174)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(729, 370);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.closeButton);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "moreInfo";
            this.Text = "Повече информация";
            this.Load += new System.EventHandler(this.moreInfo_Load);
            this.mainPanel.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm bord;
        private Guna.UI2.WinForms.Guna2GradientButton closeButton;
        private Bunifu.UI.WinForms.BunifuPanel mainPanel;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label emisions;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}