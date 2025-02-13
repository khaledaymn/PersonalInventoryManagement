using PersonalInventoryManagement.BL.Interface;
using PersonalInventoryManagement.BL.Repository;
using PersonalInventoryManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInventoryManagement.PL
{
    public partial class ChangePasswordFrm : Form
    {
        private readonly User _user;
        private readonly IUserRepository _userRepository;
        public ChangePasswordFrm(User user)
        {
            InitializeComponent();
            panel6.Visible = false;
            panel5.Visible = false;
            panel10.Visible = false;
            pictureBox10.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox8.Visible = false;
            pictureBox10.Visible = false;
            _user = user;
            _userRepository = new UserRepository();
        }


        #region Current Password

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            HideAndShowPassword(pictureBox5, pictureBox4, txt_password);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HideAndShowPassword(pictureBox5, pictureBox4, txt_password);
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
        }

        #endregion


        #region New Password

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region Confirm Password



        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region Hide / show password

        bool isVisible = true;

        private void HideAndShowPassword(PictureBox hideIcon, PictureBox showIcon, TextBox passwordTextBox)
        {
            isVisible = !isVisible;

            if (isVisible)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                hideIcon.Visible = true;
                showIcon.Visible = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                hideIcon.Visible = false;
                showIcon.Visible = true;
            }
        }




        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowProfileFrm showProfileFrm = new ShowProfileFrm(_user);
            showProfileFrm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string oldPassword = txt_password.Text;
            string newPassword = txt_newPassword.Text;
            string confirmPassword = txt_confirmPassword.Text;

            // Validate input fields
            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirmation do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call ChangePassword method from _userRepository
            bool isPasswordChanged = _userRepository.ChangePassword(_user, oldPassword, newPassword);

            if (isPasswordChanged)
            {
                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ShowProfileFrm showProfileFrm = new ShowProfileFrm(_user);
                showProfileFrm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to change password! Old password may be incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
