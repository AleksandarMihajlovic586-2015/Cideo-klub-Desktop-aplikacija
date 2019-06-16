namespace WindowsFormsApp1
{
    partial class Racun
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
            this.txtIgrica = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtIme = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPrezime = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAdresa = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtBroj = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuFlatButton11 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIznos = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.comboRadnik = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtFilm = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(155, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Račun";
            // 
            // txtIgrica
            // 
            this.txtIgrica.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtIgrica.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtIgrica.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtIgrica.BorderThickness = 3;
            this.txtIgrica.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIgrica.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIgrica.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIgrica.ForeColor = System.Drawing.Color.White;
            this.txtIgrica.isPassword = false;
            this.txtIgrica.Location = new System.Drawing.Point(86, 155);
            this.txtIgrica.Margin = new System.Windows.Forms.Padding(4);
            this.txtIgrica.MaxLength = 32767;
            this.txtIgrica.Name = "txtIgrica";
            this.txtIgrica.Size = new System.Drawing.Size(224, 44);
            this.txtIgrica.TabIndex = 22;
            this.txtIgrica.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtIme
            // 
            this.txtIme.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtIme.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtIme.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtIme.BorderThickness = 3;
            this.txtIme.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIme.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIme.ForeColor = System.Drawing.Color.White;
            this.txtIme.isPassword = false;
            this.txtIme.Location = new System.Drawing.Point(88, 365);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.MaxLength = 32767;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(224, 44);
            this.txtIme.TabIndex = 25;
            this.txtIme.Text = "Ime kupca";
            this.txtIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPrezime
            // 
            this.txtPrezime.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtPrezime.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtPrezime.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtPrezime.BorderThickness = 3;
            this.txtPrezime.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrezime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrezime.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrezime.ForeColor = System.Drawing.Color.White;
            this.txtPrezime.isPassword = false;
            this.txtPrezime.Location = new System.Drawing.Point(87, 434);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.MaxLength = 32767;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(224, 44);
            this.txtPrezime.TabIndex = 26;
            this.txtPrezime.Text = "Prezime kupca";
            this.txtPrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAdresa
            // 
            this.txtAdresa.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtAdresa.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtAdresa.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtAdresa.BorderThickness = 3;
            this.txtAdresa.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAdresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdresa.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAdresa.ForeColor = System.Drawing.Color.White;
            this.txtAdresa.isPassword = false;
            this.txtAdresa.Location = new System.Drawing.Point(87, 506);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdresa.MaxLength = 32767;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(224, 44);
            this.txtAdresa.TabIndex = 27;
            this.txtAdresa.Text = "Adresa kupca";
            this.txtAdresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBroj
            // 
            this.txtBroj.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtBroj.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtBroj.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtBroj.BorderThickness = 3;
            this.txtBroj.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBroj.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBroj.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBroj.ForeColor = System.Drawing.Color.White;
            this.txtBroj.isPassword = false;
            this.txtBroj.Location = new System.Drawing.Point(87, 578);
            this.txtBroj.Margin = new System.Windows.Forms.Padding(4);
            this.txtBroj.MaxLength = 32767;
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(224, 44);
            this.txtBroj.TabIndex = 28;
            this.txtBroj.Text = "Broj telefona kupca";
            this.txtBroj.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton11
            // 
            this.bunifuFlatButton11.Active = false;
            this.bunifuFlatButton11.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton11.BorderRadius = 0;
            this.bunifuFlatButton11.ButtonText = "Račun";
            this.bunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.Iconimage = null;
            this.bunifuFlatButton11.Iconimage_right = null;
            this.bunifuFlatButton11.Iconimage_right_Selected = null;
            this.bunifuFlatButton11.Iconimage_Selected = null;
            this.bunifuFlatButton11.IconMarginLeft = 0;
            this.bunifuFlatButton11.IconMarginRight = 0;
            this.bunifuFlatButton11.IconRightVisible = true;
            this.bunifuFlatButton11.IconRightZoom = 0D;
            this.bunifuFlatButton11.IconVisible = true;
            this.bunifuFlatButton11.IconZoom = 90D;
            this.bunifuFlatButton11.IsTab = false;
            this.bunifuFlatButton11.Location = new System.Drawing.Point(126, 791);
            this.bunifuFlatButton11.Name = "bunifuFlatButton11";
            this.bunifuFlatButton11.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton11.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton11.selected = false;
            this.bunifuFlatButton11.Size = new System.Drawing.Size(151, 48);
            this.bunifuFlatButton11.TabIndex = 30;
            this.bunifuFlatButton11.Text = "Račun";
            this.bunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton11.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton11.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuFlatButton11.Click += new System.EventHandler(this.bunifuFlatButton11_Click);
            // 
            // date1
            // 
            this.date1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.date1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.date1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.date1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.date1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.date1.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold);
            this.date1.Location = new System.Drawing.Point(87, 236);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(223, 23);
            this.date1.TabIndex = 31;
            // 
            // date2
            // 
            this.date2.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.date2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.date2.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.date2.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.date2.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.date2.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold);
            this.date2.Location = new System.Drawing.Point(88, 305);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(223, 23);
            this.date2.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(83, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Današnji datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(83, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Datum vraćanja proizvoda:";
            // 
            // txtIznos
            // 
            this.txtIznos.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtIznos.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtIznos.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtIznos.BorderThickness = 3;
            this.txtIznos.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIznos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIznos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIznos.ForeColor = System.Drawing.Color.White;
            this.txtIznos.isPassword = false;
            this.txtIznos.Location = new System.Drawing.Point(87, 655);
            this.txtIznos.Margin = new System.Windows.Forms.Padding(4);
            this.txtIznos.MaxLength = 32767;
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(224, 44);
            this.txtIznos.TabIndex = 29;
            this.txtIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboRadnik
            // 
            this.comboRadnik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.comboRadnik.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboRadnik.ForeColor = System.Drawing.Color.White;
            this.comboRadnik.FormattingEnabled = true;
            this.comboRadnik.Location = new System.Drawing.Point(86, 748);
            this.comboRadnik.Name = "comboRadnik";
            this.comboRadnik.Size = new System.Drawing.Size(224, 25);
            this.comboRadnik.TabIndex = 36;
            this.comboRadnik.SelectedIndexChanged += new System.EventHandler(this.comboRadnik_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(81, 710);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Radnik:";
            // 
            // txtID
            // 
            this.txtID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtID.BorderThickness = 3;
            this.txtID.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.isPassword = false;
            this.txtID.Location = new System.Drawing.Point(332, 653);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(37, 33);
            this.txtID.TabIndex = 38;
            this.txtID.Text = "0";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtID.Visible = false;
            // 
            // txtFilm
            // 
            this.txtFilm.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtFilm.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.txtFilm.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.txtFilm.BorderThickness = 3;
            this.txtFilm.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFilm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFilm.ForeColor = System.Drawing.Color.White;
            this.txtFilm.isPassword = false;
            this.txtFilm.Location = new System.Drawing.Point(86, 78);
            this.txtFilm.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilm.MaxLength = 32767;
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(224, 44);
            this.txtFilm.TabIndex = 39;
            this.txtFilm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(83, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Video igrica";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(83, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Film";
            // 
            // Racun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(406, 851);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFilm);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboRadnik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.bunifuFlatButton11);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtIgrica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Racun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Racun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIgrica;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIme;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPrezime;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAdresa;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBroj;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton11;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIznos;
        private System.Windows.Forms.ComboBox comboRadnik;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtID;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFilm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}