using PersonalInventoryManagement.BL.Interface;
using PersonalInventoryManagement.BL.Repository;
using PersonalInventoryManagement.DAL.Entities;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PersonalInventoryManagement.PL
{
    public partial class Registration : Form
    {
        private readonly IUserRepository _userRepository;
        public Registration()
        {
            InitializeComponent();
            HideErrorMessages();
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            _userRepository = new UserRepository();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        #region Register Button Click

        private void button1_Click(object sender, EventArgs e)
        {
            HideErrorMessages();

            string name = txt_Name.Text.Trim();
            string email = txt_email.Text.Trim();
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();
            string confirmPassword = txt_confirmpassword.Text.Trim();

            if (CheckInputs(name, email, username, password, confirmPassword) ||
                !IsValidUsername(username, label3, panel8) ||
                !IsValidPassword(password, label5, panel10))
                return;

            if (password != confirmPassword)
            {
                ShowErrorMessage(label6, panel11, "Passwords do not match.");
                return;
            }

            try
            {
                User newUser = new User
                {
                    Name = name,
                    Email = email,
                    UserName = username,
                    Password = password
                };

                User addedUser = _userRepository.AddUser(newUser);

                MessageBox.Show($"User {addedUser.UserName} registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Validation Methods

        private bool CheckInputs(string name, string email, string username, string password, string confirmPassword)
        {
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(name))
            {
                ShowErrorMessage(label2, panel7, "Name is required.");
                txt_Name.Focus();
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                ShowErrorMessage(label4, panel9, "Email is required.");
                txt_email.Focus();
                hasError = true;
            }
            else if (!IsValidEmail(email))
            {
                ShowErrorMessage(label4, panel9, "Invalid email format.");
                txt_email.Focus();
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                ShowErrorMessage(label3, panel8, "Username is required.");
                txt_username.Focus();
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowErrorMessage(label5, panel10, "Password is required.");
                txt_password.Focus();
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                ShowErrorMessage(label6, panel11, "Confirm password is required.");
                txt_confirmpassword.Focus();
                hasError = true;
            }

            return hasError;
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

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidUsername(string username, Label label, Panel panel)
        {

            if (username.Length < 5)
            {
                ShowErrorMessage(label, panel, "Username must be at least 5 characters.");
                return false;
            }

            if (!char.IsLetter(username[0]))
            {
                ShowErrorMessage(label, panel, "Username must start with a letter.");
                return false;
            }

            if (username.Contains(" "))
            {
                ShowErrorMessage(label, panel, "Username cannot contain spaces.");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-zA-Z0-9_.]+$"))
            {
                ShowErrorMessage(label, panel, "Username can only contain letters, numbers, underscores (_).");
                return false;
            }

            panel.Visible = false; // ✅ No error, hide panel
            return true; // ✅ Username is valid
        }

        #endregion


        #region UI Helper Methods

        private void ShowErrorMessage(Label label, Panel panel, string message)
        {
            label.Text = message;
            panel.Visible = true;
        }

        private void HideErrorMessages()
        {
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
        }

        private void ClearFields()
        {
            txt_Name.Clear();
            txt_email.Clear();
            txt_username.Clear();
            txt_password.Clear();
            txt_confirmpassword.Clear();
            HideErrorMessages();
        }
        #endregion


        #region Text Changed Events

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text))
                ShowErrorMessage(label2, panel7, "Name is required.");
            else
                panel7.Visible = false;
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text))
            {
                ShowErrorMessage(label3, panel8, "Username is required.");
                return;
            }
            else
                panel8.Visible = false;
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                ShowErrorMessage(label4, panel9, "Email is required.");
                return;
            }

            if (!IsValidEmail(txt_email.Text))
            {
                ShowErrorMessage(label4, panel9, "Invalid email format.");
                return;
            }

            panel9.Visible = false;
        }

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

        #endregion

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
            txt_password.PasswordChar = '\0';
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible= false;
            pictureBox7.Visible= true;
            txt_password.PasswordChar = '*';
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible= false;
            pictureBox10.Visible= true;
            txt_confirmpassword.PasswordChar = '*';
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            pictureBox10.Visible = false;
            txt_confirmpassword.PasswordChar = '\0';
        }
    }
}
