
namespace LoginAPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.button = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.usernamebox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.passwordbox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(239, 26);
            this.metroSetControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // button
            // 
            this.button.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button.DisabledForeColor = System.Drawing.Color.Gray;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.button.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.button.HoverTextColor = System.Drawing.Color.White;
            this.button.IsDerivedStyle = true;
            this.button.Location = new System.Drawing.Point(104, 264);
            this.button.Name = "button";
            this.button.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button.NormalTextColor = System.Drawing.Color.White;
            this.button.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.button.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.button.PressTextColor = System.Drawing.Color.White;
            this.button.Size = new System.Drawing.Size(155, 66);
            this.button.Style = MetroSet_UI.Enums.Style.Light;
            this.button.StyleManager = null;
            this.button.TabIndex = 1;
            this.button.Text = "Login";
            this.button.ThemeAuthor = "Narwin";
            this.button.ThemeName = "MetroLite";
            this.button.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(17, 139);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(104, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 2;
            this.metroSetLabel1.Text = "User Name:";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(17, 176);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 4;
            this.metroSetLabel2.Text = "Password:";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // usernamebox
            // 
            this.usernamebox.AutoCompleteCustomSource = null;
            this.usernamebox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.usernamebox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.usernamebox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.usernamebox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.usernamebox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.usernamebox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.usernamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernamebox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.usernamebox.Image = null;
            this.usernamebox.IsDerivedStyle = true;
            this.usernamebox.Lines = null;
            this.usernamebox.Location = new System.Drawing.Point(124, 139);
            this.usernamebox.MaxLength = 32767;
            this.usernamebox.Multiline = false;
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.ReadOnly = false;
            this.usernamebox.Size = new System.Drawing.Size(135, 23);
            this.usernamebox.Style = MetroSet_UI.Enums.Style.Light;
            this.usernamebox.StyleManager = null;
            this.usernamebox.TabIndex = 5;
            this.usernamebox.Text = "admin";
            this.usernamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernamebox.ThemeAuthor = "Narwin";
            this.usernamebox.ThemeName = "MetroLite";
            this.usernamebox.UseSystemPasswordChar = false;
            this.usernamebox.WatermarkText = "";
            // 
            // passwordbox
            // 
            this.passwordbox.AutoCompleteCustomSource = null;
            this.passwordbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.passwordbox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordbox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.passwordbox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.passwordbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordbox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.passwordbox.Image = null;
            this.passwordbox.IsDerivedStyle = true;
            this.passwordbox.Lines = null;
            this.passwordbox.Location = new System.Drawing.Point(124, 176);
            this.passwordbox.MaxLength = 32767;
            this.passwordbox.Multiline = false;
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.ReadOnly = false;
            this.passwordbox.Size = new System.Drawing.Size(135, 23);
            this.passwordbox.Style = MetroSet_UI.Enums.Style.Light;
            this.passwordbox.StyleManager = null;
            this.passwordbox.TabIndex = 6;
            this.passwordbox.Text = "admin";
            this.passwordbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordbox.ThemeAuthor = "Narwin";
            this.passwordbox.ThemeName = "MetroLite";
            this.passwordbox.UseSystemPasswordChar = false;
            this.passwordbox.WatermarkText = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(355, 348);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.metroSetControlBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(14, 45, 14, 15);
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "Login";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton button;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetTextBox usernamebox;
        private MetroSet_UI.Controls.MetroSetTextBox passwordbox;
    }
}

