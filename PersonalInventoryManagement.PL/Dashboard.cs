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


        #region Form Load
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            label6.Text = _productRepository.ProductsCount().ToString();
            label1.Text = _user.Name.Split(" ")[0] + " " + _user.Name.Split(" ")[1];

            ChartStyle();

            panel5.Height = 0;
            panel4.Height = 0;
        }

        #endregion

        #region Circle Chart

        private void ChartStyle()
        {
            chart1.Series.Clear();
            int goodCount = _productRepository.Good();
            int expireSoonCount = _productRepository.ExpireSoon();
            int expiredCount = _productRepository.Expired();

            // ✅ التأكد من وجود بيانات
            if (goodCount == 0 && expireSoonCount == 0 && expiredCount == 0)
            {
                chart1.Visible = false;
                return;
            }

            Series series1 = new Series
            {
                Name = "Inventory",
                ChartType = SeriesChartType.Pie
            };

            // ✅ إضافة البيانات فقط إذا لم تكن صفر
            if (goodCount > 0)
                series1.Points.Add(goodCount).Label = $"{goodCount} ({(goodCount * 100) / (goodCount + expireSoonCount + expiredCount)}%)";

            if (expireSoonCount > 0)
                series1.Points.Add(expireSoonCount).Label = $"{expireSoonCount} ({(expireSoonCount * 100) / (goodCount + expireSoonCount + expiredCount)}%)";

            if (expiredCount > 0)
                series1.Points.Add(expiredCount).Label = $"{expiredCount} ({(expiredCount * 100) / (goodCount + expireSoonCount + expiredCount)}%)";

            chart1.Series.Add(series1);

            // ✅ تلوين النقاط
            if (goodCount > 0)
                series1.Points[0].Color = System.Drawing.Color.SeaGreen;   // Good

            if (expireSoonCount > 0)
                series1.Points[1].Color = System.Drawing.Color.DarkOrange;  // Expiring Soon

            if (expiredCount > 0)
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


        #region  open / close Minu

        bool sidebarExpand = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 70)
                {
                    panel1.Width = 777;
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
                    panel1.Width = 606;
                    panel1.Location = new Point(277, 65);
                    pictureBox2.Visible = true;
                    sidebarExpand = true;
                    timer1.Stop();
                }
            }
        }



        private void btn_menu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        #endregion


        #region Log out

        private void button8_Click(object sender, EventArgs e)
        {
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
                if (panel5.Height < panelMaxHeight)
                {
                    panel5.Height += step1;
                    if (panel4.Height <= 114)
                        panel4.Height += step1;
                }
                else
                    timer2.Stop();
            }
            else
            {
                if (panel5.Height > 0)
                {
                    panel4.Height -= step1;
                    panel5.Height -= step1;
                }
                else
                    timer2.Stop();
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



        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }

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

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.White;

        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Transparent;
        }

    }
}
