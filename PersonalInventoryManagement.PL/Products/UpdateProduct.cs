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

namespace PersonalInventoryManagement.PL.Images.Categories
{
    public partial class UpdateProduct : Form
    {
        private readonly int _id;
        private readonly User _user;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;
        private readonly FileManager imageManager;
        public event Action<IEnumerable<DAL.Entities.Product>> OnProductUpdated;
      
        public UpdateProduct(int ProductId, User user)
        {
            InitializeComponent();
            _id = ProductId;
            _user = user;
            _categoryRepository = new CategoryRepository();
            _productRepository = new ProductRepository();
            imageManager = new FileManager();
        }


        #region Form Load

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            if (_id <= 0)
            {
                MessageBox.Show("No product is selected to edit. Select a row and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            var productList = _productRepository.Filter(p => p.Id == _id).ToList();

            if (productList.Count == 0)
            {
                MessageBox.Show("No product found with the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            var product = productList[0];
            txt_name.Text = product.Name;
            txt_price.Text = product.Price.ToString();
            txt_quantity.Text = product.Quantity.ToString();
            dtp_expiredate.Value = product.ExpireDate;
            ImageUrl = product.ImageURL;
            comboBox1.DataSource = _categoryRepository.GetAll().ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedValue = _categoryRepository.Filter(c => c.Id == product.CategoryId).FirstOrDefault().Id;

            try
            {
                if (!string.IsNullOrEmpty(product.ImageURL) && File.Exists(product.ImageURL))
                {
                    // Load the image into a MemoryStream to avoid file locking
                    using (FileStream stream = new FileStream(product.ImageURL, FileMode.Open, FileAccess.Read))
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
                pictureBox1.Image = Image.FromFile("DefaultImage.jpg");
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
                    MessageBox.Show("No product is selected to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_name.Text))
                {
                    MessageBox.Show("Product name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txt_price.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Enter a valid price greater than 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_quantity.Text, out int quantity) || quantity < 0)
                {
                    MessageBox.Show("Enter a valid quantity (0 or more).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtp_expiredate.Value < DateTime.Today)
                {
                    MessageBox.Show("Expire date must be in the future.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DAL.Entities.Product updatedProduct = new DAL.Entities.Product
                {
                    Id = _id,
                    Name = txt_name.Text.Trim(),
                    Price = price,
                    Quantity = quantity,
                    UserId = _user.Id,
                    ExpireDate = dtp_expiredate.Value,
                    ImageURL = ImageUrl,
                    CategoryId = (int)comboBox1.SelectedValue
                };

                var result = _productRepository.Update(updatedProduct);

                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                OnProductUpdated?.Invoke(_productRepository.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

#endregion
    }

}
