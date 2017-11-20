using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_Report
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.categoryProductsDataTableTableAdapter1.Fill(this.northWindDataSet1.CategoryProductsDataTable);
            this.dataGridView1.DataSource = this.northWindDataSet1.CategoryProductsDataTable;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'NorthWindDataSet.CategoryProductsDataTable' 資料表。您可以視需要進行移動或移除。
            this.CategoryProductsDataTableTableAdapter.Fill(this.NorthWindDataSet.CategoryProductsDataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
