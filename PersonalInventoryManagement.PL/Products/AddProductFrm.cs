using PersonalInventoryManagement.BL.Helper;
using PersonalInventoryManagement.BL.Interface;
using PersonalInventoryManagement.BL.Repository;
using PersonalInventoryManagement.DAL;
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
    public partial class AddProductFrm : Form
    {
        private readonly CategoryRepository _categoryRepository;
        public event Action<List<DAL.Entities.Product>> OnProductAdded;
        private readonly ProductRepository _productRepository;
        private readonly User _user;
        public AddProductFrm(User user)
        {
            InitializeComponent();
            _categoryRepository = new CategoryRepository();
            _productRepository = new ProductRepository();
            pictureBox1.Visible = false;
            _user = user;
        }

        #region Upload Image

        string ImageUrl = "";
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                string saveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Products");

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


        #region Add Product

        private void button4_Click(object sender, EventArgs e)
        {
            // Validate product name
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                MessageBox.Show("Product name is required");
                return;
            }

            // Validate price
            if (!decimal.TryParse(txt_price.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price greater than 0");
                return;
            }

            // Validate quantity
            if (!int.TryParse(txt_quantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity (0 or more)");
                return;
            }

            // Validate expire date
            if (!DateTime.TryParse(dtp_expiredate.Text, out DateTime expireDate))
            {
                MessageBox.Show("Please enter a valid expiration date");
                return;
            }
            if (expireDate < DateTime.Today)
            {
                MessageBox.Show("Expiration date cannot be in the past");
                return;
            }

            // Validate selected image
            if (string.IsNullOrEmpty(ImageUrl))
            {
                MessageBox.Show("Please select an image for this product");
                return;
            }

            // Validate category selection
            if (!int.TryParse(comboBox2.SelectedValue?.ToString(), out int categoryId))
            {
                MessageBox.Show("Please select a valid category");
                return;
            }

            // Create a new Product object and set its properties
            DAL.Entities.Product product = new DAL.Entities.Product
            {
                Name = txt_name.Text,
                Price = price,
                Quantity = quantity,
                ExpireDate = expireDate,
                ImageURL = ImageUrl,
                CategoryId = categoryId,
                UserId = _user.Id
            };

            // Call the Add method to save the product to the database
            try
            {
                _productRepository.Add(product);
                MessageBox.Show("Product added successfully");
                OnProductAdded?.Invoke(_productRepository.GetAll().ToList());
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}");
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


        #region Form Load

        private void AddProductFrm_Load(object sender, EventArgs e)
        {
            dtp_expiredate.Value = DateTime.Today;
            dtp_expiredate.MinDate = DateTime.Today;
            comboBox2.DataSource = _categoryRepository.GetAll().ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
        }

        #endregion


        #region Add Category

        private void button5_Click(object sender, EventArgs e)
        {
            AddCategoryFrm addCategoryFrm = new AddCategoryFrm();
            addCategoryFrm.ShowDialog();
            comboBox2.DataSource = _categoryRepository.GetAll().ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
        }
            
        #endregion

    }
}
