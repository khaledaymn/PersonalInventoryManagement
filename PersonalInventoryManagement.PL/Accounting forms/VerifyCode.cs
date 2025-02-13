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
    public partial class VerifyCode : Form
    {
        private readonly int _code;
        private readonly User _user;
        public VerifyCode(int code, User user)
        {
            InitializeComponent();
            panel9.Visible = false;
            _code = code;
            _user = user;
        }

        #region Verify Code

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_code.Text))
            {
                panel9.Visible = true;
                label4.Text = "Code is required";
            }
            if (txt_code.Text == _code.ToString())
            {
                MessageBox.Show("Validation code is successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ResetPassword resetPassword = new ResetPassword(_user);
                resetPassword.ShowDialog();
            }
            else
            {
                panel9.Visible = true;
                label4.Text = "Entered code is not valid";
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
