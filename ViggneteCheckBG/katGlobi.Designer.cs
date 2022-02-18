namespace ViggneteCheckBG
{
    partial class katGlobi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(katGlobi));
            this.bordForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.exitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sumpsNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.egn = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // bordForm
            // 
            this.bordForm.AnimateWindow = true;
            this.bordForm.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.bordForm.ContainerControl = this;
            this.bordForm.DockIndicatorTransparencyValue = 0.6D;
            this.bordForm.TransparentWhileDrag = true;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.IconColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(491, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(61, 33);
            this.exitButton.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер на СУМПС * : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "ЕГН/ЛНЧ/ЛН * :";
            // 
            // sumpsNumber
            // 
            this.sumpsNumber.Animated = true;
            this.sumpsNumber.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.sumpsNumber.BorderRadius = 10;
            this.sumpsNumber.BorderThickness = 2;
            this.sumpsNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sumpsNumber.DefaultText = "";
            this.sumpsNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sumpsNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sumpsNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sumpsNumber.DisabledState.Parent = this.sumpsNumber;
            this.sumpsNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sumpsNumber.FillColor = System.Drawing.Color.Gainsboro;
            this.sumpsNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sumpsNumber.FocusedState.Parent = this.sumpsNumber;
            this.sumpsNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sumpsNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sumpsNumber.HoverState.Parent = this.sumpsNumber;
            this.sumpsNumber.Location = new System.Drawing.Point(162, 12);
            this.sumpsNumber.Name = "sumpsNumber";
            this.sumpsNumber.PasswordChar = '\0';
            this.sumpsNumber.PlaceholderText = "";
            this.sumpsNumber.SelectedText = "";
            this.sumpsNumber.ShadowDecoration.Parent = this.sumpsNumber;
            this.sumpsNumber.Size = new System.Drawing.Size(200, 21);
            this.sumpsNumber.TabIndex = 4;
            // 
            // egn
            // 
            this.egn.Animated = true;
            this.egn.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.egn.BorderRadius = 10;
            this.egn.BorderThickness = 2;
            this.egn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.egn.DefaultText = "";
            this.egn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.egn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.egn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.egn.DisabledState.Parent = this.egn;
            this.egn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.egn.FillColor = System.Drawing.Color.Gainsboro;
            this.egn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.egn.FocusedState.Parent = this.egn;
            this.egn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.egn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.egn.HoverState.Parent = this.egn;
            this.egn.Location = new System.Drawing.Point(140, 59);
            this.egn.Name = "egn";
            this.egn.PasswordChar = '\0';
            this.egn.PlaceholderText = "";
            this.egn.SelectedText = "";
            this.egn.ShadowDecoration.Parent = this.egn;
            this.egn.Size = new System.Drawing.Size(200, 21);
            this.egn.TabIndex = 5;
            // 
            // checkButton
            // 
            this.checkButton.Animated = true;
            this.checkButton.BorderRadius = 15;
            this.checkButton.CheckedState.Parent = this.checkButton;
            this.checkButton.CustomImages.Parent = this.checkButton;
            this.checkButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkButton.DisabledState.Parent = this.checkButton;
            this.checkButton.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.checkButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkButton.ForeColor = System.Drawing.Color.DimGray;
            this.checkButton.HoverState.Parent = this.checkButton;
            this.checkButton.Location = new System.Drawing.Point(140, 105);
            this.checkButton.Name = "checkButton";
            this.checkButton.ShadowDecoration.Parent = this.checkButton;
            this.checkButton.Size = new System.Drawing.Size(180, 45);
            this.checkButton.TabIndex = 6;
            this.checkButton.Text = "Провери";
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // katGlobi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(549, 188);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.egn);
            this.Controls.Add(this.sumpsNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "katGlobi";
            this.Text = "Проверка за глови в кат";
            this.Load += new System.EventHandler(this.katGlobi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm bordForm;
        private Guna.UI2.WinForms.Guna2ControlBox exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button checkButton;
        private Guna.UI2.WinForms.Guna2TextBox egn;
        private Guna.UI2.WinForms.Guna2TextBox sumpsNumber;
    }
}