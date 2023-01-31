using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Feladat
{
    public partial class Form1 : Form
    {
        List<kolcsonzesek> kolcsonzesek;
        

        dvd_magyarEntities context = new dvd_magyarEntities();
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            dvdDataGridView.DataSource = kolcsonzesek;
            CreateExcel();
            
        }

        private void CreateExcel()
        {
            xlApp = new Excel.Application();
            xlWB = xlApp.Workbooks.Add();
            xlSheet xlWB.ActiveSheet;

            CreateTable();

            xlApp.Visible = true;
            xlApp.UserControl = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadData ()
        {
            kolcsonzesek = context.kolcsonzesek.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void szuresButton_Click(object sender, EventArgs e)
        {
            DateTime datum = kolcsonzesDateTimePicker.Value;
            kolcsonzesek = context.kolcsonzesek.Where(x => x.ki_datum <= datum && (x.vissza_datum == null || x.vissza_datum >= datum)).ToList();
            dvdDataGridView.DataSource = kolcsonzesek;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            DateTime datum = kolcsonzesDateTimePicker.Value;
            kolcsonzesek = context.kolcsonzesek.Where(x => x.ki_datum <= datum && (x.vissza_datum == null || x.vissza_datum >= datum)).OrderByDescending(XmlReadMode => XmlReadMode.ki_datum).ToList();
            dvdDataGridView.DataSource = kolcsonzesek;
        }

        private void CreateTable()
        {
            string[] headers = new string[]
            {
                "ID",
                "ki",
                "mit",
                "ki_datum",
                "vissza_datum"
            };
        }
    }
}
