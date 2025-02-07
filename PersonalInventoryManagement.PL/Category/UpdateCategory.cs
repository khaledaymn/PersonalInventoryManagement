using PersonalInventoryManagement.BL.Helper;
using PersonalInventoryManagement.BL.Interface;
using PersonalInventoryManagement.BL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInventoryManagement.PL.Images.Categories
{
    public partial class UpdateCategory : Form
    {
        private readonly int _id;
        private readonly ICategoryRepository _categoryRepository;
        private readonly FileManager imageManager;
        public event Action<IEnumerable<PersonalInventoryManagement.DAL.Entities.Category>> OnCategoryUpdated;
        public UpdateCategory(int id)
        {
            InitializeComponent();
            _id = id;
            _categoryRepository = new CategoryRepository();
            imageManager = new FileManager();
        }

        #region Form Load

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            if (_id <= 0)
            {
                MessageBox.Show("No data is selected to edit. Select a row and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            var categoryn = _categoryRepository.Filter(c => c.Id == _id).ToList();

            if (categoryn.Count == 0)
            {
                MessageBox.Show("No category found with the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            var category = categoryn[0];
            txt_name.Text = category.Name;
            ImageUrl = category.ImageURL;

            try
            {
                if (!string.IsNullOrEmpty(category.ImageURL) && File.Exists(category.ImageURL))
                {
                    // Load the image into a MemoryStream to avoid file locking
                    using (FileStream stream = new FileStream(category.ImageURL, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox1.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    pictureBox1.Image = Image.FromFile("DefaultImage.jpg");
                    pictureBox3.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pictureBox1.Image = Image.FromFile("DefultImage.jpg");
                pictureBox3.Visible = false;
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        #endregion


        #region Close Form

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region Minimize form
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion


        #region Upload image

        string ImageUrl = "";
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                string saveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Categories");

                string savedFilePath = imageManager.SaveImage(selectedFilePath, saveDirectory);

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

        #endregion


        #region Remove Image

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ImageUrl))
            {
                if (imageManager.DeleteImage(ImageUrl))
                {
                    ImageUrl = "";
                    pictureBox1.Image = Image.FromFile("DefultImage.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Visible = false;
                    MessageBox.Show("Image removed successfully");
                }
                else
                    MessageBox.Show("No image to remove");
            }
        }

        #endregion


        #region Update

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (_id <= 0)
                {
                    MessageBox.Show("No category is selected to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new category object with updated values
            
                PersonalInventoryManagement.DAL.Entities.Category updatedCategory = new PersonalInventoryManagement.DAL.Entities.Category
                {
                    Id = _id,
                    Name = txt_name.Text.Trim(),
                    ImageURL = ImageUrl
                };

                // Call the BL method to update the category

                var result = _categoryRepository.Update(updatedCategory);

                MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                OnCategoryUpdated?.Invoke(_categoryRepository.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }

}
