namespace PersonalInventoryManagement.PL
{
    partial class ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            label4 = new Label();
            panel9 = new Panel();
            txt_email = new TextBox();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel2 = new LinkLabel();
            panel12 = new Panel();
            button2 = new Button();
            button3 = new Button();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel12.SuspendLayout();
            SuspendLayout();
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
            // panel9
            // 
            panel9.Controls.Add(label4);
            panel9.Location = new Point(31, 284);
            panel9.Name = "panel9";
            panel9.Size = new Size(473, 29);
            panel9.TabIndex = 69;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.White;
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_email.ForeColor = Color.Black;
            txt_email.Location = new Point(62, 244);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Email";
            txt_email.Size = new Size(442, 28);
            txt_email.TabIndex = 67;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(218, 182, 73);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(114, 340);
            button1.Name = "button1";
            button1.Size = new Size(284, 43);
            button1.TabIndex = 65;
            button1.Text = "SEND CODE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(31, 244);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 60;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(218, 182, 73);
            panel4.Location = new Point(31, 279);
            panel4.Name = "panel4";
            panel4.Size = new Size(473, 2);
            panel4.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(218, 182, 73);
            label1.Location = new Point(98, 159);
            label1.Name = "label1";
            label1.Size = new Size(322, 45);
            label1.TabIndex = 59;
            label1.Text = "Forget Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(203, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Black;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.FromArgb(218, 182, 73);
            linkLabel2.Location = new Point(198, 400);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(117, 22);
            linkLabel2.TabIndex = 70;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Back to login";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // panel12
            // 
            panel12.Controls.Add(button2);
            panel12.Controls.Add(button3);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(519, 40);
            panel12.TabIndex = 71;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(419, 1);
            button2.Name = "button2";
            button2.Size = new Size(44, 37);
            button2.TabIndex = 73;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(472, 1);
            button3.Name = "button3";
            button3.Size = new Size(44, 37);
            button3.TabIndex = 72;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(519, 453);
            Controls.Add(panel12);
            Controls.Add(linkLabel2);
            Controls.Add(panel9);
            Controls.Add(txt_email);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgetPassword";
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel12.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Panel panel9;
        private TextBox txt_email;
        private Button button1;
        private PictureBox pictureBox4;
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel2;
        private Panel panel12;
        private Button button2;
        private Button button3;
    }
}