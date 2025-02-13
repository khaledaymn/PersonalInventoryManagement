namespace PersonalInventoryManagement.PL
{
    partial class VerifyCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyCode));
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel9 = new Panel();
            label4 = new Label();
            txt_code = new TextBox();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            panel12 = new Panel();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(218, 182, 73);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(113, 344);
            button1.Name = "button1";
            button1.Size = new Size(284, 43);
            button1.TabIndex = 76;
            button1.Text = "VERIFY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(218, 182, 73);
            label1.Location = new Point(140, 177);
            label1.Name = "label1";
            label1.Size = new Size(241, 45);
            label1.TabIndex = 72;
            label1.Text = "Verify Code";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(202, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 71;
            pictureBox1.TabStop = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(label4);
            panel9.Location = new Point(22, 283);
            panel9.Name = "panel9";
            panel9.Size = new Size(473, 29);
            panel9.TabIndex = 80;
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
            // txt_code
            // 
            txt_code.BackColor = Color.White;
            txt_code.BorderStyle = BorderStyle.None;
            txt_code.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_code.ForeColor = Color.Black;
            txt_code.Location = new Point(53, 243);
            txt_code.Multiline = true;
            txt_code.Name = "txt_code";
            txt_code.PlaceholderText = "Code";
            txt_code.Size = new Size(442, 28);
            txt_code.TabIndex = 79;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(22, 243);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 77;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(218, 182, 73);
            panel4.Location = new Point(22, 278);
            panel4.Name = "panel4";
            panel4.Size = new Size(473, 2);
            panel4.TabIndex = 78;
            // 
            // panel12
            // 
            panel12.Controls.Add(button2);
            panel12.Controls.Add(button3);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(519, 40);
            panel12.TabIndex = 81;
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
            // VerifyCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(519, 413);
            Controls.Add(panel12);
            Controls.Add(panel9);
            Controls.Add(txt_code);
            Controls.Add(pictureBox4);
            Controls.Add(panel4);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerifyCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerifyCode";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel12.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel9;
        private Label label4;
        private TextBox txt_email;
        private PictureBox pictureBox4;
        private Panel panel4;
        private TextBox txt_code;
        private Panel panel12;
        private Button button2;
        private Button button3;
    }
}