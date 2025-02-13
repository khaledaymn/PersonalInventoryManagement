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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
           
            PopulateDataGridView(); // تجهيز الجدول
            AddSampleData(); // إضافة بيانات تجريبية
            StyleDataGridView(); // تحسين تصميم الجدول
            AdjustColumnWidths();
        }
        private void AdjustColumnWidths()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // تعطيل التمدد التلقائي

            dataGridView1.Columns["ProductName"].Width = 170;
            dataGridView1.Columns["Price"].Width = 100;
            dataGridView1.Columns["ExpireDate"].Width = 150;
            dataGridView1.Columns["Status"].Width = 120;
            dataGridView1.Columns["Category"].Width = 150;
            dataGridView1.Columns["ProductImage"].Width = 180;

            dataGridView1.DefaultCellStyle.Padding = new Padding(5);
            dataGridView1.RowTemplate.Height = 80; // ضبط ارتفاع الصفوف
        }

        private void PopulateDataGridView()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // إضافة الأعمدة
            dataGridView1.Columns.Add("ProductName", "Product Name");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("ExpireDate", "Expire Date");
            dataGridView1.Columns.Add("Status", "Status");
            dataGridView1.Columns.Add("Category", "Category");

            // إضافة عمود الصور
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn
            {
                Name = "ProductImage",
                HeaderText = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridView1.Columns.Add(imgColumn);
        }

        private void AddSampleData()
        {
            // بيانات تجريبية
            var sampleProducts = new List<(string Name, decimal Price, DateTime ExpireDate, string Status, string Category, Image Image)>
    {
        ("Milk", 10.50m, DateTime.Now.AddDays(30), "Good", "Dairy", Image.FromFile("DefultImage.jpg")),
        ("Cheese", 25.00m, DateTime.Now.AddDays(5), "ExpireSoon", "Dairy", Image.FromFile("DefultImage.jpg")),
        ("Bread", 5.00m, DateTime.Now.AddDays(-1), "Expired", "Bakery", Image.FromFile("DefultImage.jpg"))
    };

            foreach (var product in sampleProducts)
            {
                int rowIndex = dataGridView1.Rows.Add(product.Name, product.Price, product.ExpireDate.ToShortDateString(), product.Status, product.Category, product.Image);
                ApplyRowColors(rowIndex);
            }
        }

        private void ApplyRowColors(int rowIndex)
        {
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            if (row.Cells["Status"].Value != null)
            {
                string status = row.Cells["Status"].Value.ToString();
                Color rowColor = Color.White;

                switch (status)
                {
                    case "Good":
                        rowColor = Color.LightGreen; // أخضر للحالة الجيدة
                        break;
                    case "ExpireSoon":
                        rowColor = Color.Orange; // برتقالي للمنتجات التي ستنتهي قريبًا
                        break;
                    case "Expired":
                        rowColor = Color.Red; // أحمر للمنتجات المنتهية
                        break;
                }

                row.DefaultCellStyle.BackColor = rowColor;
                row.DefaultCellStyle.ForeColor = Color.Black;
                row.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            }
        }

        private void StyleDataGridView()
        {
            // إعدادات الخط والتنسيق
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 14);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 15, FontStyle.Bold);

            // تغيير لون الهيدر
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;

            // تغيير ألوان الصفوف
            dataGridView1.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            // تغيير لون التحديد
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            // إخفاء العمود الجانبي
            dataGridView1.RowHeadersVisible = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var categoryId = (int)comboBox1.SelectedValue;
            //var
        }
    }
}
