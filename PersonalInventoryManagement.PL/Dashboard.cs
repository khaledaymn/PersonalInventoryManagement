using PersonalInventoryManagement.BL.Interface;
using PersonalInventoryManagement.BL.Repository;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace PersonalInventoryManagement.PL
{
    public partial class Dashboard : Form
    {
        private readonly User _user;
        private readonly IProductRepository _productRepository;
        public Dashboard(User user)
        {
            InitializeComponent();
            _user = user;
            _productRepository = new ProductRepository();
        }

        #region Close window

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


        #region Minimize Window

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear(); 

            Series series1 = new Series
            {
                Name = "Inventory",
                ChartType = SeriesChartType.Pie
            };

            series1.Points.Add(60).Label = "60%";  // Good
            series1.Points.Add(15).Label = "15%";  // Expiring Soon
            series1.Points.Add(25).Label = "25%";  // Expired

            chart1.Series.Add(series1);

            series1.Points[0].Color = System.Drawing.Color.SeaGreen;   // Good
            series1.Points[1].Color = System.Drawing.Color.DarkOrange;  // Expiring Soon
            series1.Points[2].Color = System.Drawing.Color.FromArgb(209, 52, 56);     // Expired

            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White; 
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold); 

            chart1.Legends.Clear();

            foreach (var point in series1.Points)
            {
                point.Label = "#PERCENT{P0}";  
                point.LabelForeColor = System.Drawing.Color.Black;  
            }

            chart1.ChartAreas[0].BackColor = System.Drawing.Color.Transparent;
            chart1.BackColor = System.Drawing.Color.Transparent;

            LoadExpiredProductsChart();
        }


        #region 

        public void LoadExpiredProductsChart()
        {
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chart2.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "Expired Products",
                ChartType = SeriesChartType.Column, // يمكن تغييره إلى Line إذا أردت مخططًا خطيًا
                Color = System.Drawing.Color.Red,
                BorderWidth = 2
            };

            // الأشهر
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            // جلب البيانات المؤقتة
            var expiredProductsPerMonth = GetExpiredProductsCountByMonth();

            // إضافة جميع الأشهر إلى المحور X حتى لو لم يكن هناك بيانات
            for (int i = 0; i < 12; i++)
            {
                int expiredCount = expiredProductsPerMonth.ContainsKey(i + 1) ? expiredProductsPerMonth[i + 1] : 0;
                series.Points.AddXY(months[i], expiredCount);
            }

            chart2.Series.Add(series);

            // ضبط المحور X ليعرض كل الأشهر
            chart2.ChartAreas[0].AxisX.Title = "Month";
            chart2.ChartAreas[0].AxisY.Title = "Expired Products Count";
            chart2.ChartAreas[0].AxisX.Interval = 1;
            chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart2.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true; // تفادي تداخل النصوص
            chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
        }





        private Dictionary<int, int> GetExpiredProductsCountByMonth()
        {
            // بيانات وهمية لعدد المنتجات المنتهية الصلاحية لكل شهر
            var expiredProductsPerMonth = new Dictionary<int, int>
    {
        { 1, 5 },  // يناير: 5 منتجات
        { 2, 8 },  // فبراير: 8 منتجات
        { 3, 3 },  // مارس: 3 منتجات
        { 4, 12 }, // أبريل: 12 منتج
        { 5, 6 },  // مايو: 6 منتجات
        { 6, 9 },  // يونيو: 9 منتجات
        { 7, 4 },  // يوليو: 4 منتجات
        { 8, 10 }, // أغسطس: 10 منتجات
        { 9, 7 },  // سبتمبر: 7 منتجات
        { 10, 2 }, // أكتوبر: 2 منتجات
        { 11, 11 }, // نوفمبر: 11 منتج
        { 12, 5 }  // ديسمبر: 5 منتجات
    };

            return expiredProductsPerMonth;
        }





        #endregion
        #region Data Grid View

        //private void LoadData(IEnumerable<DAL.Entities.Product> products)
        //{
        //    dataGridView1.BackgroundColor = Color.White;
        //    dataGridView1.DefaultCellStyle.BackColor = Color.White;
        //    dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        //    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
        //    dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
        //    dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
        //    dataGridView1.EnableHeadersVisualStyles = false;
        //    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
        //    dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
        //    dataGridView1.ColumnHeadersHeight = 35;
        //    dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        //    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    dataGridView1.MultiSelect = false;
        //    dataGridView1.AllowUserToAddRows = false;

        //    dataGridView1.Rows.Clear();
        //    dataGridView1.Columns.Clear();

        //    dataGridView1.Columns.Add("Id", "Id");
        //    dataGridView1.Columns.Add("Name", "Product Name");
        //    dataGridView1.Columns.Add("Price", "Price");
        //    dataGridView1.Columns.Add("ExpireDate", "Expire Date");
        //    dataGridView1.Columns.Add("Category", "Category");

        //    DataGridViewImageColumn imgColumn = new DataGridViewImageColumn
        //    {
        //        Name = "Image",
        //        HeaderText = "Product Image",
        //        ImageLayout = DataGridViewImageCellLayout.Zoom
        //    };
        //    dataGridView1.Columns.Add(imgColumn);

        //    DataGridViewImageColumn statusColumn = new DataGridViewImageColumn
        //    {
        //        Name = "Status",
        //        HeaderText = "Status",
        //        ImageLayout = DataGridViewImageCellLayout.Normal
        //    };
        //    dataGridView1.Columns.Add(statusColumn);

        //    dataGridView1.RowTemplate.Height = 80;
        //    dataGridView1.DefaultCellStyle.Padding = new Padding(5);

        //    Image checkIcon = Image.FromFile("check.png");     // ✅
        //    Image warningIcon = Image.FromFile("warning.png"); // ⚠️
        //    Image errorIcon = Image.FromFile("error.png");     // ❌

        //    foreach (var product in products)
        //    {
        //        Image productImg = null;
        //        string imagePath = product.ImageURL;

        //        if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
        //        {
        //            using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
        //            {
        //                productImg = Image.FromStream(stream);
        //            }
        //        }
        //        else
        //        {
        //            productImg = Image.FromFile("DefaultImage.jpg");
        //        }

        //        Image statusImg = null;
        //        DateTime today = DateTime.Today;

        //        if (product.ExpireDate < today)
        //        {
        //            statusImg = errorIcon;
        //        }
        //        else if ((product.ExpireDate - today).TotalDays <= 7)
        //        {
        //            statusImg = warningIcon;
        //        }
        //        else
        //        {
        //            statusImg = checkIcon;
        //        }
        //        dataGridView1.Rows.Add(product.Id, product.Name, product.Price,
        //                               product.ExpireDate.ToShortDateString(), product.Category.Name,
        //                               productImg, statusImg);
        //    }

        //    dataGridView1.Columns["Id"].Visible = false;

        //    dataGridView1.Refresh();
        //}

        #endregion

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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


        #region  open / close Minu

        bool sidebarExpand = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 70)
                {
                    pictureBox2.Visible = false;
                    sidebarExpand = false;
                    timer1.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 261)
                {
                    pictureBox2.Visible = true;
                    sidebarExpand = true;
                    timer1.Stop();
                }
            }
        }

        #endregion


        private void btn_menu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
