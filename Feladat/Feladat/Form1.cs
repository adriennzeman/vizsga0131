using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feladat
{
    public partial class Form1 : Form
    {
        List<kolcsonzesek> kolcsonzesek;
        dvd_magyarEntities context = new dvd_magyarEntities();
        public Form1()
        {
            InitializeComponent();
            LoadData();
            dvdDataGridView.DataSource = kolcsonzesek;
            
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
    }
}
