namespace LibraryManagement
{
    partial class BookView
    {
        //// <summary>
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
            this.book_cat_combo = new System.Windows.Forms.ComboBox();
            this.book_a_txt = new System.Windows.Forms.TextBox();
            this.book_count_txt = new System.Windows.Forms.TextBox();
            this.book_title_txt = new System.Windows.Forms.TextBox();
            this.book_id_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.book_grid = new System.Windows.Forms.DataGridView();
            this.grid_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid__cat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_a_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Refresh = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 315F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(508, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(311, 536);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.book_cat_combo);
            this.panel4.Controls.Add(this.book_a_txt);
            this.panel4.Controls.Add(this.book_count_txt);
            this.panel4.Controls.Add(this.book_title_txt);
            this.panel4.Controls.Add(this.book_id_txt);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 43);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 491);
            this.panel4.TabIndex = 2;
            // 
            // book_cat_combo
            // 
            this.book_cat_combo.FormattingEnabled = true;
            this.book_cat_combo.Location = new System.Drawing.Point(146, 67);
            this.book_cat_combo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.book_cat_combo.Name = "book_cat_combo";
            this.book_cat_combo.Size = new System.Drawing.Size(149, 21);
            this.book_cat_combo.TabIndex = 2;
            // 
            // book_a_txt
            // 
            this.book_a_txt.Location = new System.Drawing.Point(146, 225);
            this.book_a_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.book_a_txt.Multiline = true;
            this.book_a_txt.Name = "book_a_txt";
            this.book_a_txt.Size = new System.Drawing.Size(149, 23);
            this.book_a_txt.TabIndex = 1;
            // 
            // book_count_txt
            // 
            this.book_count_txt.Location = new System.Drawing.Point(147, 174);
            this.book_count_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.book_count_txt.Multiline = true;
            this.book_count_txt.Name = "book_count_txt";
            this.book_count_txt.Size = new System.Drawing.Size(149, 23);
            this.book_count_txt.TabIndex = 1;
            // 
            // book_title_txt
            // 
            this.book_title_txt.Location = new System.Drawing.Point(146, 117);
            this.book_title_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.book_title_txt.Multiline = true;
            this.book_title_txt.Name = "book_title_txt";
            this.book_title_txt.Size = new System.Drawing.Size(150, 23);
            this.book_title_txt.TabIndex = 1;
            // 
            // book_id_txt
            // 
            this.book_id_txt.Location = new System.Drawing.Point(146, 28);
            this.book_id_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label7.Location = new System.Drawing.Point(12, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "AVAILABLE COUNT :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "COUNT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "TITLE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "CATEGORY :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 30);
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
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 37);
            this.panel2.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Save.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(15, 4);
            this.Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(502, 536);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.book_grid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 491);
            this.panel3.TabIndex = 1;
            // 
            // book_grid
            // 
            this.book_grid.AllowUserToAddRows = false;
            this.book_grid.AllowUserToDeleteRows = false;
            this.book_grid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.book_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_Id,
            this.grid__cat_id,
            this.grid_title,
            this.grid_count,
            this.grid_a_count});
            this.book_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.book_grid.Location = new System.Drawing.Point(0, 0);
            this.book_grid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.book_grid.Name = "book_grid";
            this.book_grid.ReadOnly = true;
            this.book_grid.RowHeadersWidth = 51;
            this.book_grid.RowTemplate.Height = 24;
            this.book_grid.Size = new System.Drawing.Size(496, 489);
            this.book_grid.TabIndex = 0;
            this.book_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.book_grid_CellClick);
            this.book_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.book_grid_CellContentClick);
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
            // grid__cat_id
            // 
            this.grid__cat_id.DataPropertyName = "Category";
            this.grid__cat_id.HeaderText = "Category";
            this.grid__cat_id.MinimumWidth = 3;
            this.grid__cat_id.Name = "grid__cat_id";
            this.grid__cat_id.ReadOnly = true;
            this.grid__cat_id.Width = 110;
            // 
            // grid_title
            // 
            this.grid_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grid_title.DataPropertyName = "Title";
            this.grid_title.HeaderText = "Title";
            this.grid_title.MinimumWidth = 3;
            this.grid_title.Name = "grid_title";
            this.grid_title.ReadOnly = true;
            // 
            // grid_count
            // 
            this.grid_count.DataPropertyName = "Count";
            this.grid_count.HeaderText = "Count";
            this.grid_count.MinimumWidth = 3;
            this.grid_count.Name = "grid_count";
            this.grid_count.ReadOnly = true;
            this.grid_count.Width = 50;
            // 
            // grid_a_count
            // 
            this.grid_a_count.DataPropertyName = "A_count";
            this.grid_a_count.HeaderText = "Avaiable Count";
            this.grid_a_count.MinimumWidth = 3;
            this.grid_a_count.Name = "grid_a_count";
            this.grid_a_count.ReadOnly = true;
            this.grid_a_count.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.New);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 37);
            this.panel1.TabIndex = 0;
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Refresh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(329, 4);
            this.Refresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(59, 28);
            this.Refresh.TabIndex = 0;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(212, 4);
            this.Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(50, 28);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.Color.PaleTurquoise;
            this.New.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(101, 4);
            this.New.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(50, 28);
            this.New.TabIndex = 0;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(149, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back To Hame";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookView";
            this.Load += new System.EventHandler(this.BookView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.book_grid)).EndInit();
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
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox book_a_txt;
        private System.Windows.Forms.TextBox book_count_txt;
        private System.Windows.Forms.TextBox book_title_txt;
        private System.Windows.Forms.TextBox book_id_txt;
        private System.Windows.Forms.DataGridView book_grid;

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
        private System.Windows.Forms.ComboBox book_cat_combo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid__cat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_a_count;
        private System.Windows.Forms.Button button1;
    }
}