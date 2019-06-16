namespace WindowsFormsApp1
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtLast = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPass1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPass2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCity = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtUsr = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(380, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(38, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "REGISTRACIJA RADNIKA";
            // 
            // txtName
            // 
            this.txtName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtName.BorderThickness = 3;
            this.txtName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(38, 90);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 44);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "Ime";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLast
            // 
            this.txtLast.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtLast.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtLast.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtLast.BorderThickness = 3;
            this.txtLast.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLast.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLast.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLast.ForeColor = System.Drawing.Color.White;
            this.txtLast.isPassword = false;
            this.txtLast.Location = new System.Drawing.Point(214, 90);
            this.txtLast.Margin = new System.Windows.Forms.Padding(4);
            this.txtLast.MaxLength = 32767;
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(159, 44);
            this.txtLast.TabIndex = 10;
            this.txtLast.Text = "Prezime";
            this.txtLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtEmail.BorderThickness = 3;
            this.txtEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(38, 229);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(335, 44);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Text = "E-mail";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPass1
            // 
            this.txtPass1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtPass1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtPass1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtPass1.BorderThickness = 3;
            this.txtPass1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPass1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPass1.ForeColor = System.Drawing.Color.White;
            this.txtPass1.isPassword = false;
            this.txtPass1.Location = new System.Drawing.Point(38, 303);
            this.txtPass1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass1.MaxLength = 32767;
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Size = new System.Drawing.Size(335, 44);
            this.txtPass1.TabIndex = 12;
            this.txtPass1.Text = "Šifra";
            this.txtPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPass2
            // 
            this.txtPass2.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtPass2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtPass2.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtPass2.BorderThickness = 3;
            this.txtPass2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPass2.ForeColor = System.Drawing.Color.White;
            this.txtPass2.isPassword = false;
            this.txtPass2.Location = new System.Drawing.Point(38, 382);
            this.txtPass2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass2.MaxLength = 32767;
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(335, 44);
            this.txtPass2.TabIndex = 13;
            this.txtPass2.Text = "Ponoviti šifru";
            this.txtPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNum
            // 
            this.txtNum.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtNum.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtNum.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtNum.BorderThickness = 3;
            this.txtNum.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNum.ForeColor = System.Drawing.Color.White;
            this.txtNum.isPassword = false;
            this.txtNum.Location = new System.Drawing.Point(38, 460);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.MaxLength = 32767;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(159, 44);
            this.txtNum.TabIndex = 14;
            this.txtNum.Text = "Broj telefona";
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCity
            // 
            this.txtCity.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtCity.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtCity.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtCity.BorderThickness = 3;
            this.txtCity.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.isPassword = false;
            this.txtCity.Location = new System.Drawing.Point(214, 460);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.MaxLength = 32767;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(159, 44);
            this.txtCity.TabIndex = 15;
            this.txtCity.Text = "Grad";
            this.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Registruj radnika";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(38, 538);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(335, 48);
            this.bunifuFlatButton1.TabIndex = 16;
            this.bunifuFlatButton1.Text = "Registruj radnika";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // txtUsr
            // 
            this.txtUsr.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtUsr.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtUsr.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtUsr.BorderThickness = 3;
            this.txtUsr.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsr.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsr.ForeColor = System.Drawing.Color.White;
            this.txtUsr.isPassword = false;
            this.txtUsr.Location = new System.Drawing.Point(38, 160);
            this.txtUsr.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsr.MaxLength = 32767;
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.Size = new System.Drawing.Size(335, 44);
            this.txtUsr.TabIndex = 17;
            this.txtUsr.Text = "Korisničko ime";
            this.txtUsr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(420, 629);
            this.Controls.Add(this.txtUsr);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLast;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPass1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPass2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNum;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCity;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsr;
    }
}