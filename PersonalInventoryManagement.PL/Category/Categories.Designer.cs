﻿namespace PersonalInventoryManagement.PL
{
    partial class Categories
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            button2 = new Button();
            btn_menu = new PictureBox();
            button1 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sidebar = new Panel();
            pictureBox2 = new PictureBox();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            txt_search = new TextBox();
            pictureBox1 = new PictureBox();
            btn_search = new Button();
            dataGridView1 = new DataGridView();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            button8 = new Button();
            button7 = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_menu).BeginInit();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btn_menu);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(921, 40);
            panel2.TabIndex = 1;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(821, 2);
            button2.Name = "button2";
            button2.Size = new Size(44, 37);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_menu
            // 
            btn_menu.Image = (Image)resources.GetObject("btn_menu.Image");
            btn_menu.Location = new Point(8, 2);
            btn_menu.Name = "btn_menu";
            btn_menu.Size = new Size(49, 36);
            btn_menu.SizeMode = PictureBoxSizeMode.CenterImage;
            btn_menu.TabIndex = 2;
            btn_menu.TabStop = false;
            btn_menu.Click += btn_menu_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(874, 1);
            button1.Name = "button1";
            button1.Size = new Size(44, 37);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Black;
            sidebar.Controls.Add(pictureBox2);
            sidebar.Controls.Add(button6);
            sidebar.Controls.Add(button4);
            sidebar.Controls.Add(button3);
            sidebar.Controls.Add(button5);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 40);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(261, 567);
            sidebar.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(48, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 135);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.White;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(218, 182, 73);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 458);
            button6.Name = "button6";
            button6.Padding = new Padding(15, 0, 0, 0);
            button6.Size = new Size(258, 81);
            button6.TabIndex = 7;
            button6.Text = "       Reportes";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(218, 182, 73);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 296);
            button4.Name = "button4";
            button4.Padding = new Padding(15, 0, 0, 0);
            button4.Size = new Size(258, 81);
            button4.TabIndex = 5;
            button4.Text = "       Products";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderColor = Color.FromArgb(218, 182, 73);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(218, 182, 73);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 215);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 0, 0);
            button3.Size = new Size(255, 81);
            button3.TabIndex = 4;
            button3.Text = "       Dashboard";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatAppearance.BorderColor = Color.FromArgb(218, 182, 73);
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatAppearance.MouseDownBackColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(218, 182, 73);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 377);
            button5.Name = "button5";
            button5.Padding = new Padding(15, 0, 0, 0);
            button5.Size = new Size(255, 81);
            button5.TabIndex = 6;
            button5.Text = "       Categories";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.White;
            txt_search.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_search.ForeColor = Color.Black;
            txt_search.Location = new Point(278, 114);
            txt_search.Multiline = true;
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Search...";
            txt_search.Size = new Size(250, 37);
            txt_search.TabIndex = 3;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(499, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.Black;
            btn_search.Location = new Point(554, 115);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(106, 34);
            btn_search.TabIndex = 5;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(278, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Size = new Size(429, 407);
            dataGridView1.TabIndex = 6;
            // 
            // btn_add
            // 
            btn_add.FlatAppearance.BorderColor = Color.Black;
            btn_add.FlatAppearance.BorderSize = 3;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btn_add.Location = new Point(719, 261);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(187, 46);
            btn_add.TabIndex = 7;
            btn_add.Text = "Add category";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.FlatAppearance.BorderColor = Color.Black;
            btn_update.FlatAppearance.BorderSize = 3;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btn_update.Location = new Point(719, 368);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(187, 46);
            btn_update.TabIndex = 8;
            btn_update.Text = "Update category";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.FlatAppearance.BorderColor = Color.Black;
            btn_delete.FlatAppearance.BorderSize = 3;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btn_delete.Location = new Point(719, 471);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(187, 46);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete category";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe Script", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(741, 62);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 11;
            label1.Text = "Khaled Ayman";
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(691, 54);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(888, 69);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Location = new Point(694, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(210, 114);
            panel3.TabIndex = 16;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.FlatAppearance.BorderSize = 3;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            button8.Location = new Point(2, 59);
            button8.Name = "button8";
            button8.Size = new Size(205, 46);
            button8.TabIndex = 16;
            button8.Text = "Log Out";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatAppearance.BorderSize = 3;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            button7.Location = new Point(2, 7);
            button7.Name = "button7";
            button7.Size = new Size(205, 46);
            button7.TabIndex = 15;
            button7.Text = "profile";
            button7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(692, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 118);
            panel1.TabIndex = 15;
            // 
            // Categories
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(921, 607);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(dataGridView1);
            Controls.Add(btn_search);
            Controls.Add(pictureBox1);
            Controls.Add(txt_search);
            Controls.Add(sidebar);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Categories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoriesForm";
            Load += CategoriesForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_menu).EndInit();
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Button button1;
        private PictureBox btn_menu;
        private Button button2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel sidebar;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private TextBox txt_search;
        private PictureBox pictureBox1;
        private Button btn_search;
        private DataGridView dataGridView1;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Button button8;
        private Button button7;
        private Panel panel1;
    }
}