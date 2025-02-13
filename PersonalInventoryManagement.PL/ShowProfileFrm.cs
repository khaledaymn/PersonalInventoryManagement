using PersonalInventoryManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInventoryManagement.PL
{
    public partial class ShowProfileFrm : Form
    {
        private readonly User _user;
        public ShowProfileFrm(User user)
        {
            InitializeComponent();
            this._user = user;
        }

        #region  Movement Window

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        #endregion

        private void ShowProfileFrm_Load(object sender, EventArgs e)
        {
            txt_name.Text = _user.Name;
            txt_email.Text = _user.Email;
            txt_username.Text = _user.UserName;
            label1.Text = _user.Name;
            try
            {

                pictureBox1.Image = Image.FromFile(_user.ImageURL);
            }
            catch (Exception ex)
            {
                pictureBox1.Image = Image.FromFile("ProfileImage.png");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProfileFrm editProfileFrm = new EditProfileFrm(_user);
            editProfileFrm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products products = new Products(_user);
            products.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
