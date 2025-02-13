namespace PersonalInventoryManagement.PL
{
    partial class ShowProfileFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowProfileFrm));
            timer2 = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            txt_name = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txt_email = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txt_username = new TextBox();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // timer2
            // 
            timer2.Interval = 10;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
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
            button2.Click += button2_Click;
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
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 40);
            panel2.TabIndex = 15;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 367);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 17;
            label1.Text = "Khaled Ayman";
            // 
            // button3
            // 
            button3.BackColor = Color.SkyBlue;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 457);
            button3.Name = "button3";
            button3.Size = new Size(234, 64);
            button3.TabIndex = 18;
            button3.Text = "Edit Profile";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(218, 182, 73);
            panel1.Controls.Add(txt_name);
            panel1.Location = new Point(427, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 47);
            panel1.TabIndex = 21;
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
            txt_name.Size = new Size(392, 41);
            txt_name.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(302, 99);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 20;
            label2.Text = "Full Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(218, 182, 73);
            panel3.Controls.Add(txt_email);
            panel3.Location = new Point(424, 202);
            panel3.Name = "panel3";
            panel3.Size = new Size(401, 47);
            panel3.TabIndex = 23;
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
            txt_email.Size = new Size(395, 41);
            txt_email.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(302, 212);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 22;
            label3.Text = "Email";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(218, 182, 73);
            panel4.Controls.Add(txt_username);
            panel4.Location = new Point(456, 328);
            panel4.Name = "panel4";
            panel4.Size = new Size(366, 47);
            panel4.TabIndex = 25;
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
            txt_username.Size = new Size(360, 41);
            txt_username.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(299, 338);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 24;
            label4.Text = "User Name";
            // 
            // ShowProfileFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(850, 547);
            Controls.Add(panel4);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowProfileFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowProfileFrm";
            Load += ShowProfileFrm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button3;
        private Panel panel1;
        private TextBox txt_name;
        private Label label2;
        private Panel panel3;
        private TextBox txt_email;
        private Label label3;
        private Panel panel4;
        private TextBox txt_username;
        private Label label4;
    }
}