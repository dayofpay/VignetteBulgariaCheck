namespace ViggneteCheckBG
{
    partial class Error
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
            this.abs = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.errorId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // abs
            // 
            this.abs.AnimateWindow = true;
            this.abs.BorderRadius = 3;
            this.abs.ContainerControl = this;
            this.abs.DockIndicatorTransparencyValue = 0.6D;
            this.abs.TransparentWhileDrag = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(381, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.IconColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(497, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(52, 31);
            this.exitButton.TabIndex = 1;
            // 
            // errorId
            // 
            this.errorId.AutoSize = true;
            this.errorId.Location = new System.Drawing.Point(34, 57);
            this.errorId.Name = "errorId";
            this.errorId.Size = new System.Drawing.Size(49, 14);
            this.errorId.TabIndex = 2;
            this.errorId.Text = "label1";
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(556, 160);
            this.Controls.Add(this.errorId);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Error";
            this.Padding = new System.Windows.Forms.Padding(3, 5, 6, 1);
            this.Text = "Error";
            this.Load += new System.EventHandler(this.Error_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm abs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label errorId;
        private Guna.UI2.WinForms.Guna2ControlBox exitButton;
    }
}