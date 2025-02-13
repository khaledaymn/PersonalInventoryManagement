using Microsoft.EntityFrameworkCore;
using PersonalInventoryManagement.BL.Helper;
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
using System.Xml.Linq;

namespace PersonalInventoryManagement.PL
{
    public partial class EditProfileFrm : Form
    {
        private readonly FileManager fileManager;
        private readonly User _user;
        private readonly IUserRepository _userRepository;
        public EditProfileFrm(User user)
        {
            InitializeComponent();
            _user = user;
            panel5.Visible = false;
            panel6.Visible = false;
            panel10.Visible = false;
            fileManager = new FileManager();
            _userRepository = new UserRepository();
        }

        private void EditProfileFrm_Load(object sender, EventArgs e)
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

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                panel10.Visible = true;
                label5.Text = "Name is Required";
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                panel5.Visible = true;
                label1.Text = "Email is Required";
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_username.Text))
            {
                panel6.Visible = true;
                label6.Text = "Username is Required";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (_user == null)
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Update user properties from TextBoxes
            try
            {
                _user.Name = txt_name.Text;
                _user.Email = txt_email.Text;
                _user.UserName = txt_email.Text;
                _user.ImageURL = ImageUrl ?? "profileImage.png";
                _userRepository.Update(_user);
                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ShowProfileFrm showProfileFrm = new ShowProfileFrm(_user);
                showProfileFrm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePasswordFrm changePasswordFrm = new ChangePasswordFrm(_user);
            changePasswordFrm.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_user.ImageURL))
            {
                if (fileManager.DeleteImage(_user.ImageURL))
                {
                    pictureBox1.Image = Image.FromFile("ProfileImage.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Visible = false;
                    MessageBox.Show("Image removed successfully");
                }
                else
                    MessageBox.Show("No image to remove");
            }
        }

        string ImageUrl = null;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                string saveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Categories");

                string savedFilePath = fileManager.SaveImage(selectedFilePath, saveDirectory);

                if (!string.IsNullOrEmpty(savedFilePath))
                {
                    ImageUrl = savedFilePath;
                    pictureBox1.Image = Image.FromFile(savedFilePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Visible = true;
                    pictureBox3.Visible = true;
                    MessageBox.Show("Image uploaded successfully");

                }
            }
        }

    }
}
