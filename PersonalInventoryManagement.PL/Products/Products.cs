using PersonalInventoryManagement.BL.Helper;
using PersonalInventoryManagement.BL.Interface;
using PersonalInventoryManagement.BL.Repository;
using PersonalInventoryManagement.DAL.DataBase;
using PersonalInventoryManagement.DAL.Entities;
using PersonalInventoryManagement.PL.Category;
using PersonalInventoryManagement.PL.Images.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInventoryManagement.PL
{
    public partial class Products : Form
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;
        private readonly User _user;
        public Products(User user)
        {
            InitializeComponent();
            _user = user;
            _categoryRepository = new CategoryRepository();
            _productRepository = new ProductRepository();

        }


        #region Form Load

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            label1.Text = _user.Name.Split(" ")[0] + " " + _user.Name.Split(" ")[1];
            txt_search.Padding = new Padding(20, 0, 0, 0);
            // Call LoadCategories when the form loads
            LoadProducts(_productRepository.GetAll().ToList());
            panel1.Height = 0;
            panel3.Height = 0;
        }

        #endregion


        #region Load Categories

        public void LoadProducts(IEnumerable<PersonalInventoryManagement.DAL.Entities.Product> products)
        {
            // Set up UI properties for DataGridView
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.MultiSelect = false;

            // Reset the DataGridView before adding new data
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.AllowUserToAddRows = false;

            // Define columns
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("ExpireDate", "Expire Date");

            // Add image column
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn
            {
                Name = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridView1.Columns.Add(imgColumn);

            // Adjust row appearance
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DefaultCellStyle.Padding = new Padding(5);

            // Populate DataGridView with products
            foreach (var product in products)
            {
                Image img = null;
                string imagePath = product.ImageURL;

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    // Open the image safely to avoid file locking
                    using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        img = Image.FromStream(stream);
                    }
                }
                else
                {
                    img = Image.FromFile("DefaultImage.jpg"); // Load a default image if no valid image is found
                }

                // Add product data to DataGridView
                dataGridView1.Rows.Add(product.Id, product.Name, product.Price, product.ExpireDate.ToShortDateString(), img);
            }

            // Hide ID column
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Refresh();
        }


        #endregion


        #region Close Window

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


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


        #region side bar movement

        bool sidebarExpand = true;
        int sidebarTargetWidth;
        int step = 15; // Animation step size

        // Define the two sizes and positions for the DataGridView
        Size expandedSize = new Size(867, 407);
        Point expandedLocation = new Point(102, 188);

        Size collapsedSize = new Size(605, 407);
        Point collapsedLocation = new Point(278, 188);

        private void btn_menu_Click(object sender, EventArgs e)
        {
            sidebarTargetWidth = sidebarExpand ? 70 : 261; // Toggle sidebar width
            timer1.Start(); // Start animation
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) // Collapse sidebar
            {
                if (sidebar.Width > sidebarTargetWidth)
                {
                    sidebar.Width -= step; // Reduce sidebar width gradually
                    MoveControlsSmoothly(-step); // Move controls left
                    ResizeGridView(expandedSize, expandedLocation); // Expand DataGridView
                }
                else
                {
                    sidebar.Width = sidebarTargetWidth; // Ensure exact width
                    sidebarExpand = false;
                    pictureBox2.Visible = false; // Hide icon
                    timer1.Stop();
                }
            }
            else // Expand sidebar
            {
                if (sidebar.Width < sidebarTargetWidth)
                {
                    sidebar.Width += step; // Increase sidebar width gradually
                    MoveControlsSmoothly(step); // Move controls right
                    ResizeGridView(collapsedSize, collapsedLocation); // Shrink DataGridView back
                }
                else
                {
                    pictureBox2.Visible = true; // Show icon
                    sidebar.Width = sidebarTargetWidth; // Ensure exact width
                    sidebarExpand = true;
                    timer1.Stop();
                }
            }
        }

        // Move UI controls smoothly with the sidebar
        private void MoveControlsSmoothly(int deltaX)
        {
            txt_search.Location = new Point(txt_search.Location.X + deltaX, txt_search.Location.Y);
            pictureBox1.Location = new Point(pictureBox1.Location.X + deltaX, pictureBox1.Location.Y);
            btn_search.Location = new Point(btn_search.Location.X + deltaX, btn_search.Location.Y);
        }

        // Resize and reposition DataGridView smoothly in both directions
        private void ResizeGridView(Size targetSize, Point targetLocation)
        {
            // Adjust width gradually
            if (dataGridView1.Width != targetSize.Width)
            {
                int newWidth = dataGridView1.Width + (sidebarExpand ? step : -step);
                dataGridView1.Width = Math.Clamp(newWidth, collapsedSize.Width, expandedSize.Width);
            }

            // Adjust X position gradually
            if (dataGridView1.Location != targetLocation)
            {
                int xStep = step * (sidebarExpand ? -1 : 1);
                dataGridView1.Location = new Point(dataGridView1.Location.X + xStep, dataGridView1.Location.Y);
            }
        }


        #endregion


        #region Minimize window

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion


        #region Filter

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchQuery = txt_search.Text.Trim(); // Get the search query

            // If search query isn't empty, filter categories
            if (!string.IsNullOrEmpty(searchQuery))
            {
                var filteredCategories = _productRepository.Filter(c => c.Name.ToLower().Contains(searchQuery.ToLower()));
                LoadProducts(filteredCategories.ToList());
            }
            else
            {
                // If search query is empty, show all categories
                var allCategories = _productRepository.GetAll().ToList();
                LoadProducts(allCategories);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            btn_search_Click(sender, e);
        }

        #endregion


        #region Add

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddProductFrm addProductFrm = new AddProductFrm(_user);
            addProductFrm.OnProductAdded += LoadProducts;
            addProductFrm.ShowDialog();
        }

        #endregion


        #region Update

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected before proceeding
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try to retrieve the ID safely
            if (dataGridView1.SelectedRows[0].Cells[0].Value != null &&
                int.TryParse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), out int id))
            {
                UpdateProduct updateProduct = new UpdateProduct(id, _user);
                updateProduct.ShowDialog();
                //updateProduct.OnProductUpdated += LoadProducts;
            }
            else
            {
                MessageBox.Show("Invalid product ID. Please select a valid row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //LoadProducts(_productRepository.GetAll());
        }

        #endregion


        #region Delete

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView1.SelectedRows[0].Cells[0].Value != null &&
                int.TryParse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), out int id))
            {
                var product = _productRepository.Filter(p => p.Id == id).FirstOrDefault();

                if (product == null)
                {
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    bool isDeleted = _productRepository.Delete(id);

                    if (isDeleted)
                    {
                        if (!string.IsNullOrEmpty(product.ImageURL))
                        {
                            RemoveImage(product.ImageURL);
                        }

                        MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadProducts(_productRepository.GetAll().ToList());
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid product ID. Please select a valid row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Remove Image

        private void RemoveImage(string ImageUrl)
        {
            FileManager fileManager = new FileManager();
            if (!string.IsNullOrEmpty(ImageUrl))
            {
                if (fileManager.DeleteImage(ImageUrl))
                {
                    ImageUrl = "";
                    pictureBox1.Image = Image.FromFile("DefaultImage.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Visible = false;
                    MessageBox.Show("Image removed successfully");
                }
                else
                    MessageBox.Show("No image to remove");
            }
        }

        #endregion


        #region Dashboard

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(_user);
            dashboard.ShowDialog();
            this.Close();
        }


        #endregion


        #region Products
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products product = new Products(_user);
            product.ShowDialog();
            this.Close();
        }

        #endregion


        #region Categories

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categories categories = new Categories(_user);
            categories.ShowDialog();
            this.Close();
        }

        #endregion


        #region Reports

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.ShowDialog();
            this.Close();
        }

        #endregion


        #region Profile

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowProfileFrm profileFrm = new ShowProfileFrm(_user);
            profileFrm.ShowDialog();
        }

        #endregion


        #region Log out

        private void button8_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Email = "";
            Properties.Settings.Default.Psw = "";
            Properties.Settings.Default.RememberMe = false;
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Close();
        }

        #endregion


        #region Open profile window

        bool isExpanded = false;
        int panelMaxHeight = 118;
        int step1 = 5;
        private void label1_Click(object sender, EventArgs e)
        {
            if (!timer2.Enabled)
            {
                isExpanded = !isExpanded;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                if (panel1.Height < panelMaxHeight)
                {
                    panel1.Height += step1;
                    if (panel3.Height <= 114)
                        panel3.Height += step1;
                }
                else
                    timer2.Stop();
            }
            else
            {
                if (panel1.Height > 0)
                {
                    panel1.Height -= step1;
                    panel3.Height -= step1;
                }
                else
                    timer2.Stop();
            }
        }

        #endregion


        //private void button3_MouseEnter(object sender, EventArgs e)
        //{
        //    button3.BackColor = Color.White;

        //}

        //private void button3_MouseLeave(object sender, EventArgs e)
        //{
        //    button3.BackColor = Color.Transparent;
        //}

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Transparent;

        }

        //private void button6_MouseEnter(object sender, EventArgs e)
        //{
        //    button6.BackColor = Color.White;

        //}

        //private void button6_MouseLeave(object sender, EventArgs e)
        //{
        //    button6.BackColor = Color.Transparent;
        //}
    }

}
