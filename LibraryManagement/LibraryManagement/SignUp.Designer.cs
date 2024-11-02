namespace LibraryManagement
{
    partial class SignUp
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
            this.Uname = new MetroFramework.Controls.MetroLabel();
            this.suadrs = new MetroFramework.Controls.MetroLabel();
            this.sueml = new MetroFramework.Controls.MetroLabel();
            this.sugndr = new MetroFramework.Controls.MetroLabel();
            this.supass = new MetroFramework.Controls.MetroLabel();
            this.sucpass = new MetroFramework.Controls.MetroLabel();
            this.sufntxt = new MetroFramework.Controls.MetroTextBox();
            this.supasstxt = new MetroFramework.Controls.MetroTextBox();
            this.sucpasstxt = new MetroFramework.Controls.MetroTextBox();
            this.suemailtx = new MetroFramework.Controls.MetroTextBox();
            this.subttn = new MetroFramework.Controls.MetroButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.suphn = new MetroFramework.Controls.MetroTextBox();
            this.sutxtb1 = new System.Windows.Forms.RichTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.female = new MetroFramework.Controls.MetroRadioButton();
            this.male = new MetroFramework.Controls.MetroRadioButton();
            this.suVbtn = new MetroFramework.Controls.MetroButton();
            this.suvlbl = new MetroFramework.Controls.MetroLabel();
            this.suvtxtbx = new MetroFramework.Controls.MetroTextBox();
            this.suvybtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.aiub_id_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.usr_type_com = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.usr_invalid = new MetroFramework.Controls.MetroRadioButton();
            this.usr_valid = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Uname
            // 
            this.Uname.AutoSize = true;
            this.Uname.BackColor = System.Drawing.Color.Black;
            this.Uname.Location = new System.Drawing.Point(78, 87);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(45, 19);
            this.Uname.Style = MetroFramework.MetroColorStyle.Green;
            this.Uname.TabIndex = 0;
            this.Uname.Text = "Name";
            this.Uname.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Uname.Click += new System.EventHandler(this.sufstnme_Click);
            // 
            // suadrs
            // 
            this.suadrs.AutoSize = true;
            this.suadrs.Location = new System.Drawing.Point(399, 172);
            this.suadrs.Name = "suadrs";
            this.suadrs.Size = new System.Drawing.Size(56, 19);
            this.suadrs.TabIndex = 0;
            this.suadrs.Text = "Address";
            // 
            // sueml
            // 
            this.sueml.AutoSize = true;
            this.sueml.Location = new System.Drawing.Point(400, 249);
            this.sueml.Name = "sueml";
            this.sueml.Size = new System.Drawing.Size(41, 19);
            this.sueml.TabIndex = 0;
            this.sueml.Text = "Email";
            // 
            // sugndr
            // 
            this.sugndr.AutoSize = true;
            this.sugndr.Location = new System.Drawing.Point(76, 259);
            this.sugndr.Name = "sugndr";
            this.sugndr.Size = new System.Drawing.Size(56, 19);
            this.sugndr.TabIndex = 0;
            this.sugndr.Text = "Gender:";
            // 
            // supass
            // 
            this.supass.AutoSize = true;
            this.supass.Location = new System.Drawing.Point(77, 431);
            this.supass.Name = "supass";
            this.supass.Size = new System.Drawing.Size(63, 19);
            this.supass.TabIndex = 0;
            this.supass.Text = "Password";
            // 
            // sucpass
            // 
            this.sucpass.AutoSize = true;
            this.sucpass.Location = new System.Drawing.Point(77, 499);
            this.sucpass.Name = "sucpass";
            this.sucpass.Size = new System.Drawing.Size(115, 19);
            this.sucpass.TabIndex = 0;
            this.sucpass.Text = "Confirm Password";
            // 
            // sufntxt
            // 
            this.sufntxt.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.sufntxt.CustomButton.Image = null;
            this.sufntxt.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.sufntxt.CustomButton.Name = "";
            this.sufntxt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.sufntxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sufntxt.CustomButton.TabIndex = 1;
            this.sufntxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sufntxt.CustomButton.UseSelectable = true;
            this.sufntxt.CustomButton.Visible = false;
            this.sufntxt.Lines = new string[0];
            this.sufntxt.Location = new System.Drawing.Point(78, 120);
            this.sufntxt.MaxLength = 32767;
            this.sufntxt.Multiline = true;
            this.sufntxt.Name = "sufntxt";
            this.sufntxt.PasswordChar = '\0';
            this.sufntxt.PromptText = "Enter Your First Name";
            this.sufntxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sufntxt.SelectedText = "";
            this.sufntxt.SelectionLength = 0;
            this.sufntxt.SelectionStart = 0;
            this.sufntxt.ShortcutsEnabled = true;
            this.sufntxt.Size = new System.Drawing.Size(200, 30);
            this.sufntxt.TabIndex = 1;
            this.sufntxt.UseSelectable = true;
            this.sufntxt.WaterMark = "Enter Your First Name";
            this.sufntxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sufntxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.sufntxt.Click += new System.EventHandler(this.sufntxt_Click);
            // 
            // supasstxt
            // 
            // 
            // 
            // 
            this.supasstxt.CustomButton.Image = null;
            this.supasstxt.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.supasstxt.CustomButton.Name = "";
            this.supasstxt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.supasstxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.supasstxt.CustomButton.TabIndex = 1;
            this.supasstxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.supasstxt.CustomButton.UseSelectable = true;
            this.supasstxt.CustomButton.Visible = false;
            this.supasstxt.Lines = new string[0];
            this.supasstxt.Location = new System.Drawing.Point(75, 454);
            this.supasstxt.MaxLength = 32767;
            this.supasstxt.Multiline = true;
            this.supasstxt.Name = "supasstxt";
            this.supasstxt.PasswordChar = '#';
            this.supasstxt.PromptText = "Enter a Password";
            this.supasstxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.supasstxt.SelectedText = "";
            this.supasstxt.SelectionLength = 0;
            this.supasstxt.SelectionStart = 0;
            this.supasstxt.ShortcutsEnabled = true;
            this.supasstxt.Size = new System.Drawing.Size(200, 30);
            this.supasstxt.TabIndex = 1;
            this.supasstxt.UseSelectable = true;
            this.supasstxt.WaterMark = "Enter a Password";
            this.supasstxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.supasstxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // sucpasstxt
            // 
            // 
            // 
            // 
            this.sucpasstxt.CustomButton.Image = null;
            this.sucpasstxt.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.sucpasstxt.CustomButton.Name = "";
            this.sucpasstxt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.sucpasstxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sucpasstxt.CustomButton.TabIndex = 1;
            this.sucpasstxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sucpasstxt.CustomButton.UseSelectable = true;
            this.sucpasstxt.CustomButton.Visible = false;
            this.sucpasstxt.Lines = new string[0];
            this.sucpasstxt.Location = new System.Drawing.Point(78, 532);
            this.sucpasstxt.MaxLength = 32767;
            this.sucpasstxt.Multiline = true;
            this.sucpasstxt.Name = "sucpasstxt";
            this.sucpasstxt.PasswordChar = '#';
            this.sucpasstxt.PromptText = "Enter Confirm Password";
            this.sucpasstxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sucpasstxt.SelectedText = "";
            this.sucpasstxt.SelectionLength = 0;
            this.sucpasstxt.SelectionStart = 0;
            this.sucpasstxt.ShortcutsEnabled = true;
            this.sucpasstxt.Size = new System.Drawing.Size(200, 30);
            this.sucpasstxt.TabIndex = 1;
            this.sucpasstxt.UseSelectable = true;
            this.sucpasstxt.WaterMark = "Enter Confirm Password";
            this.sucpasstxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sucpasstxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // suemailtx
            // 
            // 
            // 
            // 
            this.suemailtx.CustomButton.Image = null;
            this.suemailtx.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.suemailtx.CustomButton.Name = "";
            this.suemailtx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.suemailtx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.suemailtx.CustomButton.TabIndex = 1;
            this.suemailtx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.suemailtx.CustomButton.UseSelectable = true;
            this.suemailtx.CustomButton.Visible = false;
            this.suemailtx.Lines = new string[0];
            this.suemailtx.Location = new System.Drawing.Point(399, 272);
            this.suemailtx.MaxLength = 32767;
            this.suemailtx.Multiline = true;
            this.suemailtx.Name = "suemailtx";
            this.suemailtx.PasswordChar = '\0';
            this.suemailtx.PromptText = "Enter Your Email";
            this.suemailtx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.suemailtx.SelectedText = "";
            this.suemailtx.SelectionLength = 0;
            this.suemailtx.SelectionStart = 0;
            this.suemailtx.ShortcutsEnabled = true;
            this.suemailtx.Size = new System.Drawing.Size(200, 30);
            this.suemailtx.TabIndex = 1;
            this.suemailtx.UseSelectable = true;
            this.suemailtx.WaterMark = "Enter Your Email";
            this.suemailtx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.suemailtx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // subttn
            // 
            this.subttn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.subttn.Location = new System.Drawing.Point(204, 586);
            this.subttn.Name = "subttn";
            this.subttn.Size = new System.Drawing.Size(276, 40);
            this.subttn.TabIndex = 4;
            this.subttn.Text = "Sign Up";
            this.subttn.UseSelectable = true;
            this.subttn.Visible = false;
            this.subttn.Click += new System.EventHandler(this.subttn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel1.Location = new System.Drawing.Point(484, 652);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign In";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(76, 359);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Phone";
            // 
            // suphn
            // 
            // 
            // 
            // 
            this.suphn.CustomButton.Image = null;
            this.suphn.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.suphn.CustomButton.Name = "";
            this.suphn.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.suphn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.suphn.CustomButton.TabIndex = 1;
            this.suphn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.suphn.CustomButton.UseSelectable = true;
            this.suphn.CustomButton.Visible = false;
            this.suphn.Lines = new string[0];
            this.suphn.Location = new System.Drawing.Point(76, 382);
            this.suphn.MaxLength = 32767;
            this.suphn.Multiline = true;
            this.suphn.Name = "suphn";
            this.suphn.PasswordChar = '\0';
            this.suphn.PromptText = "Enter Your Phone Number";
            this.suphn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.suphn.SelectedText = "";
            this.suphn.SelectionLength = 0;
            this.suphn.SelectionStart = 0;
            this.suphn.ShortcutsEnabled = true;
            this.suphn.Size = new System.Drawing.Size(200, 30);
            this.suphn.TabIndex = 8;
            this.suphn.UseSelectable = true;
            this.suphn.WaterMark = "Enter Your Phone Number";
            this.suphn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.suphn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // sutxtb1
            // 
            this.sutxtb1.Location = new System.Drawing.Point(399, 196);
            this.sutxtb1.Name = "sutxtb1";
            this.sutxtb1.Size = new System.Drawing.Size(200, 50);
            this.sutxtb1.TabIndex = 9;
            this.sutxtb1.Text = "";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.female);
            this.metroPanel1.Controls.Add(this.male);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(142, 249);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(135, 47);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(62, 13);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(61, 15);
            this.female.TabIndex = 2;
            this.female.Text = "Female";
            this.female.UseSelectable = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(3, 13);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(49, 15);
            this.male.TabIndex = 2;
            this.male.Text = "Male";
            this.male.UseSelectable = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // suVbtn
            // 
            this.suVbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suVbtn.Location = new System.Drawing.Point(399, 320);
            this.suVbtn.Name = "suVbtn";
            this.suVbtn.Size = new System.Drawing.Size(97, 30);
            this.suVbtn.TabIndex = 11;
            this.suVbtn.Text = "Verify E-mail";
            this.suVbtn.UseSelectable = true;
            this.suVbtn.Click += new System.EventHandler(this.suVbtn_Click);
            // 
            // suvlbl
            // 
            this.suvlbl.AutoSize = true;
            this.suvlbl.Location = new System.Drawing.Point(499, 326);
            this.suvlbl.Name = "suvlbl";
            this.suvlbl.Size = new System.Drawing.Size(138, 19);
            this.suvlbl.TabIndex = 12;
            this.suvlbl.Text = "Code sent Successfully";
            this.suvlbl.Visible = false;
            // 
            // suvtxtbx
            // 
            // 
            // 
            // 
            this.suvtxtbx.CustomButton.Image = null;
            this.suvtxtbx.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.suvtxtbx.CustomButton.Name = "";
            this.suvtxtbx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.suvtxtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.suvtxtbx.CustomButton.TabIndex = 1;
            this.suvtxtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.suvtxtbx.CustomButton.UseSelectable = true;
            this.suvtxtbx.CustomButton.Visible = false;
            this.suvtxtbx.Lines = new string[0];
            this.suvtxtbx.Location = new System.Drawing.Point(400, 379);
            this.suvtxtbx.MaxLength = 32767;
            this.suvtxtbx.Multiline = true;
            this.suvtxtbx.Name = "suvtxtbx";
            this.suvtxtbx.PasswordChar = '\0';
            this.suvtxtbx.PromptText = "Enter Verification code";
            this.suvtxtbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.suvtxtbx.SelectedText = "";
            this.suvtxtbx.SelectionLength = 0;
            this.suvtxtbx.SelectionStart = 0;
            this.suvtxtbx.ShortcutsEnabled = true;
            this.suvtxtbx.Size = new System.Drawing.Size(200, 30);
            this.suvtxtbx.TabIndex = 13;
            this.suvtxtbx.UseSelectable = true;
            this.suvtxtbx.WaterMark = "Enter Verification code";
            this.suvtxtbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.suvtxtbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // suvybtn
            // 
            this.suvybtn.Location = new System.Drawing.Point(400, 431);
            this.suvybtn.Name = "suvybtn";
            this.suvybtn.Size = new System.Drawing.Size(96, 30);
            this.suvybtn.TabIndex = 14;
            this.suvybtn.Text = "Verify";
            this.suvybtn.UseSelectable = true;
            this.suvybtn.Click += new System.EventHandler(this.suvybtn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(76, 172);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Aiub Id";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.Click += new System.EventHandler(this.sufstnme_Click);
            // 
            // aiub_id_txt
            // 
            this.aiub_id_txt.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.aiub_id_txt.CustomButton.Image = null;
            this.aiub_id_txt.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.aiub_id_txt.CustomButton.Name = "";
            this.aiub_id_txt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.aiub_id_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aiub_id_txt.CustomButton.TabIndex = 1;
            this.aiub_id_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aiub_id_txt.CustomButton.UseSelectable = true;
            this.aiub_id_txt.CustomButton.Visible = false;
            this.aiub_id_txt.Lines = new string[0];
            this.aiub_id_txt.Location = new System.Drawing.Point(77, 196);
            this.aiub_id_txt.MaxLength = 32767;
            this.aiub_id_txt.Multiline = true;
            this.aiub_id_txt.Name = "aiub_id_txt";
            this.aiub_id_txt.PasswordChar = '\0';
            this.aiub_id_txt.PromptText = "Enter Your Valid Aiub Id";
            this.aiub_id_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aiub_id_txt.SelectedText = "";
            this.aiub_id_txt.SelectionLength = 0;
            this.aiub_id_txt.SelectionStart = 0;
            this.aiub_id_txt.ShortcutsEnabled = true;
            this.aiub_id_txt.Size = new System.Drawing.Size(200, 30);
            this.aiub_id_txt.TabIndex = 1;
            this.aiub_id_txt.UseSelectable = true;
            this.aiub_id_txt.WaterMark = "Enter Your Valid Aiub Id";
            this.aiub_id_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aiub_id_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.aiub_id_txt.Click += new System.EventHandler(this.sufntxt_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(76, 303);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "User Type";
            // 
            // usr_type_com
            // 
            this.usr_type_com.FormattingEnabled = true;
            this.usr_type_com.ItemHeight = 23;
            this.usr_type_com.Items.AddRange(new object[] {
            "Admin",
            "Librarian",
            "Student",
            "Faculty"});
            this.usr_type_com.Location = new System.Drawing.Point(76, 326);
            this.usr_type_com.Name = "usr_type_com";
            this.usr_type_com.Size = new System.Drawing.Size(200, 29);
            this.usr_type_com.TabIndex = 16;
            this.usr_type_com.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(399, 120);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Status :";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.usr_invalid);
            this.metroPanel2.Controls.Add(this.usr_valid);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(457, 110);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(156, 40);
            this.metroPanel2.TabIndex = 10;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // usr_invalid
            // 
            this.usr_invalid.AutoSize = true;
            this.usr_invalid.Location = new System.Drawing.Point(79, 13);
            this.usr_invalid.Name = "usr_invalid";
            this.usr_invalid.Size = new System.Drawing.Size(58, 15);
            this.usr_invalid.TabIndex = 2;
            this.usr_invalid.Text = "Invalid";
            this.usr_invalid.UseSelectable = true;
            // 
            // usr_valid
            // 
            this.usr_valid.AutoSize = true;
            this.usr_valid.Location = new System.Drawing.Point(3, 13);
            this.usr_valid.Name = "usr_valid";
            this.usr_valid.Size = new System.Drawing.Size(48, 15);
            this.usr_valid.TabIndex = 2;
            this.usr_valid.Text = "Valid";
            this.usr_valid.UseSelectable = true;
            this.usr_valid.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(756, 723);
            this.ControlBox = false;
            this.Controls.Add(this.usr_type_com);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.suvybtn);
            this.Controls.Add(this.suvtxtbx);
            this.Controls.Add(this.suvlbl);
            this.Controls.Add(this.suVbtn);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.sutxtb1);
            this.Controls.Add(this.suphn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.subttn);
            this.Controls.Add(this.suemailtx);
            this.Controls.Add(this.sucpasstxt);
            this.Controls.Add(this.supasstxt);
            this.Controls.Add(this.aiub_id_txt);
            this.Controls.Add(this.sufntxt);
            this.Controls.Add(this.sucpass);
            this.Controls.Add(this.supass);
            this.Controls.Add(this.sueml);
            this.Controls.Add(this.suadrs);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.sugndr);
            this.Controls.Add(this.Uname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SignUp";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Uname;
        private MetroFramework.Controls.MetroLabel suadrs;
        private MetroFramework.Controls.MetroLabel sueml;
        private MetroFramework.Controls.MetroLabel sugndr;
        private MetroFramework.Controls.MetroLabel supass;
        private MetroFramework.Controls.MetroLabel sucpass;
        private MetroFramework.Controls.MetroTextBox sufntxt;
        private MetroFramework.Controls.MetroTextBox supasstxt;
        private MetroFramework.Controls.MetroTextBox sucpasstxt;
        private MetroFramework.Controls.MetroTextBox suemailtx;
        private MetroFramework.Controls.MetroButton subttn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox suphn;
        private System.Windows.Forms.RichTextBox sutxtb1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton female;
        private MetroFramework.Controls.MetroRadioButton male;
        private MetroFramework.Controls.MetroButton suVbtn;
        private MetroFramework.Controls.MetroLabel suvlbl;
        private MetroFramework.Controls.MetroTextBox suvtxtbx;
        private MetroFramework.Controls.MetroButton suvybtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox aiub_id_txt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox usr_type_com;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroRadioButton usr_invalid;
        private MetroFramework.Controls.MetroRadioButton usr_valid;
    }
}