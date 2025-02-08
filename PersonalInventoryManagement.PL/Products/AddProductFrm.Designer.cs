namespace PersonalInventoryManagement.PL.Category
{
    partial class AddProductFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductFrm));
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            txt_name = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            openFileDialog1 = new OpenFileDialog();
            button3 = new Button();
            label3 = new Label();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            txt_price = new TextBox();
            panel3 = new Panel();
            label5 = new Label();
            panel4 = new Panel();
            txt_quantity = new TextBox();
            label6 = new Label();
            button5 = new Button();
            panel5 = new Panel();
            comboBox2 = new ComboBox();
            dtp_expiredate = new DateTimePicker();
            panel6 = new Panel();
            label7 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(642, 1);
            button2.Name = "button2";
            button2.Size = new Size(44, 37);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(695, 0);
            button1.Name = "button1";
            button1.Size = new Size(44, 37);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(742, 40);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(218, 182, 73);
            label1.Location = new Point(203, 45);
            label1.Name = "label1";
            label1.Size = new Size(372, 50);
            label1.TabIndex = 3;
            label1.Text = "Add New Product";
            // 
            // txt_name
            // 
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_name.ForeColor = Color.Black;
            txt_name.Location = new Point(3, 3);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Name";
            txt_name.Size = new Size(464, 41);
            txt_name.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 125);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 5;
            label2.Text = "Category Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(218, 182, 73);
            panel1.Controls.Add(txt_name);
            panel1.Location = new Point(216, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 47);
            panel1.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.FromArgb(218, 182, 73);
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(206, 475);
            button3.Name = "button3";
            button3.Size = new Size(477, 100);
            button3.TabIndex = 7;
            button3.Text = "Choose Image";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 512);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 8;
            label3.Text = "Image";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(314, 719);
            button4.Name = "button4";
            button4.Size = new Size(137, 47);
            button4.TabIndex = 9;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(273, 475);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(332, 119);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(82, 220);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 11;
            label4.Text = "Price";
            // 
            // txt_price
            // 
            txt_price.BorderStyle = BorderStyle.FixedSingle;
            txt_price.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_price.ForeColor = Color.Black;
            txt_price.Location = new Point(3, 3);
            txt_price.Multiline = true;
            txt_price.Name = "txt_price";
            txt_price.PlaceholderText = "Price";
            txt_price.Size = new Size(464, 41);
            txt_price.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(218, 182, 73);
            panel3.Controls.Add(txt_price);
            panel3.Location = new Point(216, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 47);
            panel3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(66, 313);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 12;
            label5.Text = "Quantity";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(218, 182, 73);
            panel4.Controls.Add(txt_quantity);
            panel4.Location = new Point(216, 302);
            panel4.Name = "panel4";
            panel4.Size = new Size(470, 47);
            panel4.TabIndex = 9;
            // 
            // txt_quantity
            // 
            txt_quantity.BorderStyle = BorderStyle.FixedSingle;
            txt_quantity.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_quantity.ForeColor = Color.Black;
            txt_quantity.Location = new Point(3, 3);
            txt_quantity.Multiline = true;
            txt_quantity.Name = "txt_quantity";
            txt_quantity.PlaceholderText = "Quantity";
            txt_quantity.Size = new Size(464, 41);
            txt_quantity.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 639);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 14;
            label6.Text = "Category";
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(584, 635);
            button5.Name = "button5";
            button5.Size = new Size(139, 37);
            button5.TabIndex = 15;
            button5.Text = "Add Category";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(218, 182, 73);
            panel5.Controls.Add(comboBox2);
            panel5.Location = new Point(206, 631);
            panel5.Name = "panel5";
            panel5.Size = new Size(362, 43);
            panel5.TabIndex = 31;
            // 
            // comboBox2
            // 
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(3, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(356, 33);
            comboBox2.TabIndex = 28;
            // 
            // dtp_expiredate
            // 
            dtp_expiredate.CustomFormat = "dd/MM/yyyy";
            dtp_expiredate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtp_expiredate.Location = new Point(3, 3);
            dtp_expiredate.Name = "dtp_expiredate";
            dtp_expiredate.Size = new Size(464, 30);
            dtp_expiredate.TabIndex = 32;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(218, 182, 73);
            panel6.Controls.Add(dtp_expiredate);
            panel6.Location = new Point(216, 399);
            panel6.Name = "panel6";
            panel6.Size = new Size(469, 36);
            panel6.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(53, 402);
            label7.Name = "label7";
            label7.Size = new Size(118, 25);
            label7.TabIndex = 33;
            label7.Text = "ExpireDate";
            // 
            // AddProductFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(742, 782);
            Controls.Add(label7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProductFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCategoryFrm";
            Load += AddProductFrm_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label label1;
        private TextBox txt_name;
        private Label label2;
        private Panel panel1;
        private OpenFileDialog openFileDialog1;
        private Button button3;
        private Label label3;
        private Button button4;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txt_price;
        private Panel panel3;
        private Label label5;
        private Panel panel4;
        private TextBox txt_quantity;
        private Label label6;
        private Button button5;
        private Panel panel5;
        private ComboBox comboBox2;
        private DateTimePicker dtp_expiredate;
        private Panel panel6;
        private Label label7;
    }
}