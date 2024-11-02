namespace LibraryManagement
{
    partial class BookBorrowView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbkname = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.return_no = new System.Windows.Forms.RadioButton();
            this.return_yes = new System.Windows.Forms.RadioButton();
            this.return_date = new System.Windows.Forms.DateTimePicker();
            this.due_date = new System.Windows.Forms.DateTimePicker();
            this.aiub_id_txt = new System.Windows.Forms.TextBox();
            this.book_id_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bookBorrow_grid = new System.Windows.Forms.DataGridView();
            this.grid_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid__cat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_a_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Refresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBorrow_grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(821, 540);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(523, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(296, 536);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtbkname);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.return_date);
            this.panel4.Controls.Add(this.due_date);
            this.panel4.Controls.Add(this.aiub_id_txt);
            this.panel4.Controls.Add(this.book_id_txt);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 43);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 491);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Book Name :";
            // 
            // txtbkname
            // 
            this.txtbkname.Location = new System.Drawing.Point(131, 113);
            this.txtbkname.Name = "txtbkname";
            this.txtbkname.Size = new System.Drawing.Size(148, 20);
            this.txtbkname.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.return_no);
            this.panel5.Controls.Add(this.return_yes);
            this.panel5.Location = new System.Drawing.Point(131, 242);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 46);
            this.panel5.TabIndex = 3;
            // 
            // return_no
            // 
            this.return_no.AutoSize = true;
            this.return_no.Location = new System.Drawing.Point(111, 16);
            this.return_no.Margin = new System.Windows.Forms.Padding(2);
            this.return_no.Name = "return_no";
            this.return_no.Size = new System.Drawing.Size(41, 17);
            this.return_no.TabIndex = 0;
            this.return_no.TabStop = true;
            this.return_no.Text = "NO";
            this.return_no.UseVisualStyleBackColor = true;
            // 
            // return_yes
            // 
            this.return_yes.AutoSize = true;
            this.return_yes.Location = new System.Drawing.Point(13, 17);
            this.return_yes.Margin = new System.Windows.Forms.Padding(2);
            this.return_yes.Name = "return_yes";
            this.return_yes.Size = new System.Drawing.Size(46, 17);
            this.return_yes.TabIndex = 0;
            this.return_yes.TabStop = true;
            this.return_yes.Text = "YES";
            this.return_yes.UseVisualStyleBackColor = true;
            // 
            // return_date
            // 
            this.return_date.Location = new System.Drawing.Point(133, 201);
            this.return_date.Margin = new System.Windows.Forms.Padding(2);
            this.return_date.Name = "return_date";
            this.return_date.Size = new System.Drawing.Size(148, 20);
            this.return_date.TabIndex = 2;
            // 
            // due_date
            // 
            this.due_date.Location = new System.Drawing.Point(131, 155);
            this.due_date.Margin = new System.Windows.Forms.Padding(2);
            this.due_date.Name = "due_date";
            this.due_date.Size = new System.Drawing.Size(148, 20);
            this.due_date.TabIndex = 2;
            // 
            // aiub_id_txt
            // 
            this.aiub_id_txt.Location = new System.Drawing.Point(130, 70);
            this.aiub_id_txt.Margin = new System.Windows.Forms.Padding(2);
            this.aiub_id_txt.Multiline = true;
            this.aiub_id_txt.Name = "aiub_id_txt";
            this.aiub_id_txt.Size = new System.Drawing.Size(149, 23);
            this.aiub_id_txt.TabIndex = 1;
            // 
            // book_id_txt
            // 
            this.book_id_txt.Location = new System.Drawing.Point(131, 30);
            this.book_id_txt.Margin = new System.Windows.Forms.Padding(2);
            this.book_id_txt.Multiline = true;
            this.book_id_txt.Name = "book_id_txt";
            this.book_id_txt.ReadOnly = true;
            this.book_id_txt.Size = new System.Drawing.Size(150, 23);
            this.book_id_txt.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "DUE DATE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "RETURN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "BOOK RETURN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "User ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 37);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(144, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back To Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Save.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(9, 2);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(59, 28);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(517, 536);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.bookBorrow_grid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 491);
            this.panel3.TabIndex = 1;
            // 
            // bookBorrow_grid
            // 
            this.bookBorrow_grid.AllowUserToAddRows = false;
            this.bookBorrow_grid.AllowUserToDeleteRows = false;
            this.bookBorrow_grid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bookBorrow_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookBorrow_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_Id,
            this.usr_id,
            this.grid__cat_id,
            this.grid_count,
            this.grid_title,
            this.grid_a_count,
            this.book_return,
            this.report});
            this.bookBorrow_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookBorrow_grid.Location = new System.Drawing.Point(0, 0);
            this.bookBorrow_grid.Margin = new System.Windows.Forms.Padding(2);
            this.bookBorrow_grid.Name = "bookBorrow_grid";
            this.bookBorrow_grid.ReadOnly = true;
            this.bookBorrow_grid.RowHeadersWidth = 51;
            this.bookBorrow_grid.RowTemplate.Height = 24;
            this.bookBorrow_grid.Size = new System.Drawing.Size(511, 489);
            this.bookBorrow_grid.TabIndex = 0;
            this.bookBorrow_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookBorrow_grid_CellClick);
            this.bookBorrow_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookBorrow_grid_CellContentClick);
            // 
            // grid_Id
            // 
            this.grid_Id.DataPropertyName = "Id";
            this.grid_Id.HeaderText = "ID";
            this.grid_Id.MinimumWidth = 3;
            this.grid_Id.Name = "grid_Id";
            this.grid_Id.ReadOnly = true;
            this.grid_Id.Width = 50;
            // 
            // usr_id
            // 
            this.usr_id.DataPropertyName = "Aiub_Id";
            this.usr_id.HeaderText = "Aiub Id";
            this.usr_id.MinimumWidth = 3;
            this.usr_id.Name = "usr_id";
            this.usr_id.ReadOnly = true;
            this.usr_id.Width = 75;
            // 
            // grid__cat_id
            // 
            this.grid__cat_id.DataPropertyName = "Date_Borrowed";
            this.grid__cat_id.HeaderText = "Borrow Date";
            this.grid__cat_id.MinimumWidth = 3;
            this.grid__cat_id.Name = "grid__cat_id";
            this.grid__cat_id.ReadOnly = true;
            this.grid__cat_id.Width = 110;
            // 
            // grid_count
            // 
            this.grid_count.DataPropertyName = "Due_Date";
            this.grid_count.HeaderText = "Due Date";
            this.grid_count.MinimumWidth = 3;
            this.grid_count.Name = "grid_count";
            this.grid_count.ReadOnly = true;
            this.grid_count.Width = 110;
            // 
            // grid_title
            // 
            this.grid_title.DataPropertyName = "Date_Returned";
            this.grid_title.HeaderText = "Return Date";
            this.grid_title.MinimumWidth = 3;
            this.grid_title.Name = "grid_title";
            this.grid_title.ReadOnly = true;
            this.grid_title.Width = 110;
            // 
            // grid_a_count
            // 
            this.grid_a_count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grid_a_count.DataPropertyName = "Book_Edition_Id";
            this.grid_a_count.HeaderText = "Book Edition";
            this.grid_a_count.MinimumWidth = 3;
            this.grid_a_count.Name = "grid_a_count";
            this.grid_a_count.ReadOnly = true;
            // 
            // book_return
            // 
            this.book_return.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.book_return.DataPropertyName = "Is_Returned";
            this.book_return.HeaderText = "Book Return";
            this.book_return.MinimumWidth = 3;
            this.book_return.Name = "book_return";
            this.book_return.ReadOnly = true;
            // 
            // report
            // 
            this.report.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.report.DataPropertyName = "Report";
            this.report.HeaderText = "Report";
            this.report.MinimumWidth = 3;
            this.report.Name = "report";
            this.report.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 37);
            this.panel1.TabIndex = 0;
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Refresh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(10, 2);
            this.Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(59, 28);
            this.Refresh.TabIndex = 0;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // BookBorrowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookBorrowView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Borrow View";
            this.Load += new System.EventHandler(this.BookBorrowView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookBorrow_grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aiub_id_txt;
        private System.Windows.Forms.TextBox book_id_txt;
        private System.Windows.Forms.DataGridView bookBorrow_grid;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Text = "BookView";
        //}

        #endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // BookBorrowView
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(834, 508);
        //    this.Name = "BookBorrowView";
        //    this.Text = "BookBorrowView";
        //    this.ResumeLayout(false);

        //}

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker return_date;
        private System.Windows.Forms.DateTimePicker due_date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton return_no;
        private System.Windows.Forms.RadioButton return_yes;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usr_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid__cat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_a_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn report;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbkname;
    }
}