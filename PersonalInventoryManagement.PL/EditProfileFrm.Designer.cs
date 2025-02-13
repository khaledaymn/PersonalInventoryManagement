namespace PersonalInventoryManagement.PL
{
    partial class EditProfileFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfileFrm));
            panel4 = new Panel();
            txt_username = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txt_email = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            txt_name = new TextBox();
            panel1 = new Panel();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel10 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel10.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(218, 182, 73);
            panel4.Controls.Add(txt_username);
            panel4.Location = new Point(427, 361);
            panel4.Name = "panel4";
            panel4.Size = new Size(404, 47);
            panel4.TabIndex = 35;
            // 
            // txt_username
            // 
            txt_username.BorderStyle = BorderStyle.FixedSingle;
            txt_username.Enabled = false;
            txt_username.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_username.ForeColor = Color.Black;
            txt_username.Location = new Point(3, 3);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(398, 41);
            txt_username.TabIndex = 4;
            txt_username.TextChanged += txt_username_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(302, 373);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 34;
            label4.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(305, 247);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 32;
            label3.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.BorderStyle = BorderStyle.FixedSingle;
            txt_email.Enabled = false;
            txt_email.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_email.ForeColor = Color.Black;
            txt_email.Location = new Point(3, 3);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(398, 41);
            txt_email.TabIndex = 4;
            txt_email.TextChanged += txt_email_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(218, 182, 73);
            panel3.Controls.Add(txt_email);
            panel3.Location = new Point(430, 235);
            panel3.Name = "panel3";
            panel3.Size = new Size(404, 47);
            panel3.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(305, 134);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 30;
            label2.Text = "Full Name";
            // 
            // txt_name
            // 
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.Enabled = false;
            txt_name.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_name.ForeColor = Color.Black;
            txt_name.Location = new Point(3, 3);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(398, 41);
            txt_name.TabIndex = 4;
            txt_name.TextChanged += txt_name_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(218, 182, 73);
            panel1.Controls.Add(txt_name);
            panel1.Location = new Point(430, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 47);
            panel1.TabIndex = 31;
            // 
            // button3
            // 
            button3.BackColor = Color.SkyBlue;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 530);
            button3.Name = "button3";
            button3.Size = new Size(234, 64);
            button3.TabIndex = 29;
            button3.Text = "Change Password";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 40);
            panel2.TabIndex = 26;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(746, 0);
            button2.Name = "button2";
            button2.Size = new Size(44, 37);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(799, 0);
            button1.Name = "button1";
            button1.Size = new Size(44, 37);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            // 
            // timer2
            // 
            timer2.Interval = 10;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(409, 508);
            button4.Name = "button4";
            button4.Size = new Size(234, 64);
            button4.TabIndex = 36;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(79, 409);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(151, 409);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(label5);
            panel10.Location = new Point(431, 170);
            panel10.Name = "panel10";
            panel10.Size = new Size(322, 29);
            panel10.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(5, 4);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 0;
            label5.Text = "Error Message";
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Location = new Point(431, 283);
            panel5.Name = "panel5";
            panel5.Size = new Size(322, 29);
            panel5.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(6, 5);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Error Message";
            // 
            // panel6
            // 
            panel6.Controls.Add(label6);
            panel6.Location = new Point(428, 409);
            panel6.Name = "panel6";
            panel6.Size = new Size(322, 29);
            panel6.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(5, 4);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 0;
            label6.Text = "Error Message";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditProfileFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 605);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel10);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(button4);
            Controls.Add(panel4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProfileFrm";
            Text = "ShowProfileFrm";
            Load += EditProfileFrm_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private TextBox txt_username;
        private Label label4;
        private Label label3;
        private TextBox txt_email;
        private Panel panel3;
        private Label label2;
        private TextBox txt_name;
        private Panel panel1;
        private Button button3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button button4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel10;
        private Label label5;
        private Panel panel5;
        private Label label1;
        private Panel panel6;
        private Label label6;
        private OpenFileDialog openFileDialog1;
    }
}