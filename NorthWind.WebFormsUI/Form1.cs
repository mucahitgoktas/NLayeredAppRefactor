using NorthWind.Buisness.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NorthWind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // datagridview eventi.
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Burada sadece buisness çağırılır. // Buisness'a sağ tıklayıp add Reference üzerinden WebFormsUI eklenir.
            ProductManager productManager = new ProductManager();
            dgwProduct.DataSource = productManager.GetAll();
        }
    }
}
