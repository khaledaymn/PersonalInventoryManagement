using PersonalInventoryManagement.BL.Helper;
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

namespace PersonalInventoryManagement.PL.Category
{
    public partial class AddCategoryFrm : Form
    {
        private readonly CategoryRepository _categoryRepository;
        public event Action<List<PersonalInventoryManagement.DAL.Entities.Category>> OnCategoryAdded;
        public AddCategoryFrm()
        {
            InitializeComponent();
            _categoryRepository = new CategoryRepository();
            pictureBox1.Visible = false;
        }

        #region Upload Image

        string ImageUrl = "";
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                string saveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Categories");

                FileManager imageManager = new FileManager();
                string savedFilePath = imageManager.SaveImage(selectedFilePath, saveDirectory);

                if (!string.IsNullOrEmpty(savedFilePath))
                {
                    ImageUrl = savedFilePath;
                    button3.Visible = false;
                    pictureBox1.Image = Image.FromFile(savedFilePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Visible = true;
                    MessageBox.Show("Image uploaded successfully");
                }
            }
        }

        #endregion


        #region Add Category

        private void button4_Click(object sender, EventArgs e)
        {
            // Validate category name
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                MessageBox.Show("Category name is required");
                return;
            }

            // Ensure an image has been selected before proceeding
            if (string.IsNullOrEmpty(ImageUrl))
            {
                MessageBox.Show("Please select an image for this category");
                return;
            }

            // Create a new Category object and set its properties
            PersonalInventoryManagement.DAL.Entities.Category category = new PersonalInventoryManagement.DAL.Entities.Category
            {
                Name = txt_name.Text,  // Get category name from the TextBox
                ImageURL = ImageUrl     // Set the image URL to the previously uploaded image path
            };

            // Call the Add method to save the category to the database
            try
            {
                _categoryRepository.Add(category);
                MessageBox.Show("Category added successfully");
                OnCategoryAdded?.Invoke(_categoryRepository.GetAll().ToList());
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding category: {ex.Message}");
            }
        }

        #endregion


        #region Close Form

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region Minimize Form

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion
    }
}
