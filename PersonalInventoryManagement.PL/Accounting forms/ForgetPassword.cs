using PersonalInventoryManagement.BL;
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
    public partial class ForgetPassword : Form
    {
        private User _user;
        private readonly IUserRepository _userRepository;
        public ForgetPassword()
        {
            InitializeComponent();
            panel9.Visible = false;
            _userRepository = new UserRepository();
        }


        #region Go to Login

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        #endregion


        #region Forgit Password buton

        private async void button1_Click(object sender, EventArgs e)
        {
            var (IsExist, user) = _userRepository.EmailExist(txt_email.Text);
            if (IsExist)
            {
                _user = user;
                EmailConfiguration emailConfiguration = new EmailConfiguration()
                {
                    From = Properties.Settings.Default.From,
                    Port = Properties.Settings.Default.Port,
                    Password = Properties.Settings.Default.Password,
                    SmtpServer = Properties.Settings.Default.SmtpServer,
                    UserName = Properties.Settings.Default.Username
                };
                IEmailRepository emailRepository = new EmailRepository(emailConfiguration);
                var code = await emailRepository.SendEmailAsync(_user);
                MessageBox.Show("Code is sanded to your email address", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                VerifyCode verifyCode = new VerifyCode(code, _user);
                verifyCode.ShowDialog();
            }
            else
            {
                panel9.Visible = true;
                label4.Text = "This email is not exist in the system, enter valid email";
            }
        }

        #endregion


        #region Close

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
