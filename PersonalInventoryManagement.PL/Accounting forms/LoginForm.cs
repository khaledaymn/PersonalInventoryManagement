using PersonalInventoryManagement.BL.Interface;
using PersonalInventoryManagement.BL.Repository;
using PersonalInventoryManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInventoryManagement.PL
{
    public partial class LoginForm : Form
    {
        private bool isPasswordVisible = false;
        private readonly IUserRepository _userRepository;

        public LoginForm()
        {
            InitializeComponent();
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            _userRepository = new UserRepository();
        }


        #region Show / hide password
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(true);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(false);
        }

        private void TogglePasswordVisibility(bool showPassword)
        {
            isPasswordVisible = showPassword;
            txt_password.PasswordChar = showPassword ? '\0' : '*';
            pictureBox7.Visible = !showPassword;
            pictureBox8.Visible = showPassword;
        }

        #endregion


        #region Login Click

        private void button1_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel10.Visible = false;

            string email = txt_email.Text.Trim();
            string password = txt_password.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                ShowErrorMessage(label4, panel9, "Email is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowErrorMessage(label5, panel10, "Password is required.");
                return;
            }

            try
            {
                User user = _userRepository.Login(email, password);
                if (user == null)
                {
                    MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show($"Welcome, {user.UserName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (checkBox1.Checked)
                {
                    string psw = txt_password.Text;
                    string encryptedPassword = Encrypt(psw, "1234567890abcdef");
                    Properties.Settings.Default.Email = txt_email.Text;
                    Properties.Settings.Default.Psw = encryptedPassword;
                    Properties.Settings.Default.RememberMe = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.RememberMe = false;
                    Properties.Settings.Default.Save();
                }

                this.Hide();
                Products products = new Products(user);
                products.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Show Error Massages

        private void ShowErrorMessage(Label label, Panel panel, string message)
        {
            label.Text = message;
            panel.Visible = true;
        }
        #endregion


        #region Text Changed Events
        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
        }


        #endregion


        #region Registration

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        #endregion


        #region Forget Password

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.ShowDialog();
        }

        #endregion


        #region Form Load

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberMe)
            {
                txt_email.Text = Properties.Settings.Default.Email;
                string encryptedPassword = Properties.Settings.Default.Psw;
                string decryptedPassword = Decrypt(encryptedPassword, "1234567890abcdef");
                txt_password.Text = decryptedPassword;
                checkBox1.Checked = true;
            }
        }
        #endregion


        #region Encrypt password

        public static string Encrypt(string plainText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[16];

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }


        #endregion


        #region Decrypt

        public static string Decrypt(string cipherText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[16];

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }


        #endregion


        #region Close Application

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


        #region Minimized 

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

    }
}
