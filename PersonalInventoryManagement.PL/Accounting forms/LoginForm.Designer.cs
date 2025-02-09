namespace PersonalInventoryManagement.PL
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox7 = new PictureBox();
            panel9 = new Panel();
            label4 = new Label();
            pictureBox8 = new PictureBox();
            panel10 = new Panel();
            label5 = new Label();
            txt_password = new TextBox();
            linkLabel1 = new LinkLabel();
            txt_email = new TextBox();
            button1 = new Button();
            panel5 = new Panel();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(464, 316);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(34, 29);
            pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox7.TabIndex = 54;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(label4);
            panel9.Location = new Point(31, 269);
            panel9.Name = "panel9";
            panel9.Size = new Size(473, 29);
            panel9.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(5, 4);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 0;
            label4.Text = "Error Message";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(464, 316);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(34, 29);
            pictureBox8.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox8.TabIndex = 55;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(label5);
            panel10.Location = new Point(31, 358);
            panel10.Name = "panel10";
            panel10.Size = new Size(473, 29);
            panel10.TabIndex = 52;
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
            // txt_password
            // 
            txt_password.BackColor = Color.White;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_password.ForeColor = Color.FromArgb(51, 153, 255);
            txt_password.Location = new Point(62, 318);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(442, 28);
            txt_password.TabIndex = 47;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.Black;
            linkLabel1.LinkColor = Color.FromArgb(218, 182, 73);
            linkLabel1.Location = new Point(119, 548);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(307, 22);
            linkLabel1.TabIndex = 43;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't have an account? Sign up now!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.White;
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_email.ForeColor = Color.FromArgb(51, 153, 255);
            txt_email.Location = new Point(62, 229);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Email";
            txt_email.Size = new Size(442, 28);
            txt_email.TabIndex = 46;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(218, 182, 73);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(130, 487);
            button1.Name = "button1";
            button1.Size = new Size(284, 43);
            button1.TabIndex = 42;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(218, 182, 73);
            panel5.Location = new Point(31, 352);
            panel5.Name = "panel5";
            panel5.Size = new Size(473, 2);
            panel5.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 35;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(31, 321);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 34;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(31, 229);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 33;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(218, 182, 73);
            panel4.Location = new Point(31, 264);
            panel4.Name = "panel4";
            panel4.Size = new Size(473, 2);
            panel4.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(218, 182, 73);
            label1.Location = new Point(204, 143);
            label1.Name = "label1";
            label1.Size = new Size(117, 45);
            label1.TabIndex = 30;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(210, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(218, 182, 73);
            checkBox1.Location = new Point(31, 398);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(180, 29);
            checkBox1.TabIndex = 56;
            checkBox1.Text = "RemmemberMe";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Black;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.FromArgb(218, 182, 73);
            linkLabel2.Location = new Point(197, 443);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(150, 22);
            linkLabel2.TabIndex = 57;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forget Password";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(520, 590);
            Controls.Add(linkLabel2);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox7);
            Controls.Add(panel9);
            Controls.Add(pictureBox8);
            Controls.Add(panel10);
            Controls.Add(txt_password);
            Controls.Add(linkLabel1);
            Controls.Add(txt_email);
            Controls.Add(button1);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.Coral;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox7;
        private Panel panel9;
        private Label label4;
        private PictureBox pictureBox8;
        private Panel panel10;
        private Label label5;
        private TextBox txt_password;
        private LinkLabel linkLabel1;
        private TextBox txt_email;
        private Button button1;
        private Panel panel5;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private LinkLabel linkLabel2;
    }
}