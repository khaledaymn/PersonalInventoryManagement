namespace PersonalInventoryManagement.PL
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            panel11 = new Panel();
            label6 = new Label();
            panel10 = new Panel();
            label5 = new Label();
            txt_confirmpassword = new TextBox();
            txt_password = new TextBox();
            button1 = new Button();
            panel6 = new Panel();
            pictureBox6 = new PictureBox();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(468, 272);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(34, 29);
            pictureBox10.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox10.TabIndex = 41;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(468, 272);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(34, 29);
            pictureBox9.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox9.TabIndex = 40;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(468, 200);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(34, 29);
            pictureBox8.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox8.TabIndex = 39;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(468, 200);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(34, 29);
            pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox7.TabIndex = 38;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(label6);
            panel11.Location = new Point(35, 311);
            panel11.Name = "panel11";
            panel11.Size = new Size(473, 29);
            panel11.TabIndex = 37;
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
            // panel10
            // 
            panel10.Controls.Add(label5);
            panel10.Location = new Point(35, 239);
            panel10.Name = "panel10";
            panel10.Size = new Size(473, 29);
            panel10.TabIndex = 36;
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
            // txt_confirmpassword
            // 
            txt_confirmpassword.BackColor = Color.White;
            txt_confirmpassword.BorderStyle = BorderStyle.None;
            txt_confirmpassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_confirmpassword.ForeColor = Color.FromArgb(51, 153, 255);
            txt_confirmpassword.Location = new Point(66, 273);
            txt_confirmpassword.Multiline = true;
            txt_confirmpassword.Name = "txt_confirmpassword";
            txt_confirmpassword.PasswordChar = '*';
            txt_confirmpassword.PlaceholderText = "Confirm Password";
            txt_confirmpassword.Size = new Size(442, 28);
            txt_confirmpassword.TabIndex = 35;
            txt_confirmpassword.TextChanged += txt_confirmpassword_TextChanged;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.White;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_password.ForeColor = Color.FromArgb(51, 153, 255);
            txt_password.Location = new Point(66, 200);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(442, 28);
            txt_password.TabIndex = 34;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(218, 182, 73);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(132, 356);
            button1.Name = "button1";
            button1.Size = new Size(284, 43);
            button1.TabIndex = 33;
            button1.Text = "Reset Password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(218, 182, 73);
            panel6.Location = new Point(35, 308);
            panel6.Name = "panel6";
            panel6.Size = new Size(473, 2);
            panel6.TabIndex = 32;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(35, 277);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(218, 182, 73);
            panel5.Location = new Point(35, 235);
            panel5.Name = "panel5";
            panel5.Size = new Size(473, 2);
            panel5.TabIndex = 30;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(35, 204);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(218, 182, 73);
            label1.Location = new Point(125, 135);
            label1.Name = "label1";
            label1.Size = new Size(305, 45);
            label1.TabIndex = 61;
            label1.Text = "Reset Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(210, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(555, 435);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(txt_confirmpassword);
            Controls.Add(txt_password);
            Controls.Add(button1);
            Controls.Add(panel6);
            Controls.Add(pictureBox6);
            Controls.Add(panel5);
            Controls.Add(pictureBox5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private Panel panel11;
        private Label label6;
        private Panel panel10;
        private Label label5;
        private TextBox txt_confirmpassword;
        private TextBox txt_password;
        private Button button1;
        private Panel panel6;
        private PictureBox pictureBox6;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label label1;
        private PictureBox pictureBox1;
    }
}