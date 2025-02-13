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
    public partial class ResetPassword : Form
    {
        private readonly User _user;
        private readonly IUserRepository _userRepository;
        public ResetPassword(User user)
        {
            InitializeComponent();
            _user = user;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            _userRepository = new UserRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword = txt_password.Text;

            if (!IsValidPassword(newPassword, label5, panel10))
                return;
            if (newPassword != txt_confirmpassword.Text)
            {
                ShowErrorMessage(label6, panel11, "Passwords do not match.");
                return;
            }

            if (_userRepository.ResetPassword(newPassword, _user))
            {
                MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
            else
                MessageBox.Show("Failed to reset password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ClearFields();
        }

        private bool IsValidPassword(string password, Label label, Panel panel)
        {
            if (password.Length < 8)
            {
                ShowErrorMessage(label, panel, "Password must be at least 8 characters long.");
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                ShowErrorMessage(label, panel, "Password must contain at least one uppercase letter.");
                return false;
            }

            if (!password.Any(char.IsLower))
            {
                ShowErrorMessage(label, panel, "Password must contain at least one lowercase letter.");
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                ShowErrorMessage(label, panel, "Password must contain at least one digit.");
                return false;
            }

            if (!password.Any(ch => "!@#$%^&*()-_=+[]{}|;:'\",.<>?/`~".Contains(ch)))
            {
                ShowErrorMessage(label, panel, "Password must contain at least one special character (!@#...).");
                return false;
            }

            if (password.Contains(" "))
            {
                ShowErrorMessage(label, panel, "Password cannot contain spaces.");
                return false;
            }

            panel.Visible = false; // ✅ No error, hide panel
            return true; // ✅ Password is valid
        }

        private void ShowErrorMessage(Label label, Panel panel, string message)
        {
            label.Text = message;
            panel.Visible = true;
        }


        #region Confirm Password input
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            pictureBox10.Visible = false;
            txt_confirmpassword.PasswordChar = '\0';
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            pictureBox10.Visible = true;
            txt_confirmpassword.PasswordChar = '*';
        }
        #endregion


        #region Password input

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;
            txt_password.PasswordChar = '*';
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
            txt_password.PasswordChar = '\0';
        }
        #endregion


        #region Clear Fields

        private void ClearFields()
        {
            txt_password.Clear();
            txt_confirmpassword.Clear();
        }

        #endregion

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                ShowErrorMessage(label5, panel10, "Password is required.");
                return;
            }

            if (!IsValidPassword(txt_password.Text, label5, panel10))
                return;
            panel10.Visible = false;
        }

        private void txt_confirmpassword_TextChanged(object sender, EventArgs e)
        {
            pictureBox10.Visible = true;
            if (string.IsNullOrWhiteSpace(txt_confirmpassword.Text))
            {
                ShowErrorMessage(label6, panel11, "Confirm password is required.");
                return;
            }

            panel11.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
