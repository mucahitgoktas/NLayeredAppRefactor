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
using NorthWind.Buisness.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;


namespace NorthWind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = true;
            this.HorizontalScroll.Visible = true;
            this.VerticalScroll.Enabled = true;
            this.VerticalScroll.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // datagridview eventi.
        {


        }
        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Burada sadece buisness çağırılır. // Buisness'a sağ tıklayıp add Reference üzerinden WebFormsUI eklenir.

            LoadProduct();
            LoadCategories();
            LoadCategoriesAdd();
            LoadCategoriesUpdate();

        }

        private void LoadCategoriesUpdate()
        {
            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryId";
        }

        private void LoadCategoriesAdd() // Ürün ekleme için kategorileri combobox'a listeleme.
        {
            cbxCategoryAdd.DataSource = _categoryService.GetAll();
            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";
        }

        private void LoadCategories() // Ürün listeleme için kategorileri combobox'a listeleme.
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void LoadProduct() // tüm ürünleri DataGridView'e listeleme.
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
                // seçilen(selected) kategorinin(value) değerlerinin(value) DataGridView'de listelenmesi. 
            }
            catch
            {

            }

        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbxProductName.Text)) // eğer textboxta bişey yazmıyorsa
                {
                    LoadProduct(); // loadProduct çalıştır. tümünü listele
                }
                else
                {
                    // yazılanlara göre filtreleyerek listele.
                    dgwProduct.DataSource = _productService.GetProductsByName(tbxProductName.Text);
                }

            }
            catch
            {

            }
        }

        private void gbxAdd_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product // efEntityRepositoryBase içerisindeki add methodunu çalıştırarak ürün ekleme.
            {
                CategoryId = Convert.ToInt32(cbxCategoryAdd.SelectedValue),
                ProductName = tbxProductNameAdd.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
                UnitsInStock = Convert.ToInt16(tbxUnitsInStockAdd.Text),
                QuantityPerUnit = tbxQuantityPerUnitAdd.Text



            }
            );

            LoadProduct(); // butona basıldığı anda Dgw listesini yenilemek için.
            MessageBox.Show("Ürün Eklendi!");
        }

        private void cbxCategoryAdd_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void btnUpdate_Click(object sender, EventArgs e) // update butonu
        {
            _productService.Update(new Product
            {
                ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value), // datagridview'den seçilen bir satırın ilk değeri productId.
                ProductName = tbxProductNameUpdate.Text,
                CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                UnitsInStock = Convert.ToInt16(tbxUnitsInStockUpdate.Text),  /// kalan bölümler add gibi.
                QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text)
            });
            LoadProduct(); // butona basıldığı anda Dgw listesini yenilemek için.
            MessageBox.Show("Ürün Güncellendi!");
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e) // datagridview cellclick
                                                                                      // ekrandaki DataGridView listesinden tıkladığımız satırın bilgilerini "güncelleme" boşluklara doldurmak için
        {
            tbxProductNameUpdate.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString(); // seçilen dgw satırındaki 1. kolonu al tostring olarak productnameupdate'e yaz            cbxCategoryUpdate.SelectedValue = dgwProduct.CurrentRow.Cells[2].Value;
            tbxUnitPriceUpdate.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxQuantityPerUnitUpdate.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxUnitsInStockUpdate.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnDltDelete_Click(object sender, EventArgs e)
        {


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Silmek istediğinizden emin misiniz?", "Ürün Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                _productService.Delete(new Product
                {
                    ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value), // datagridview'den seçilen bir satırın ilk değeri productId.
                    ProductName = tbxProductNameUpdate.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                    UnitsInStock = Convert.ToInt16(tbxUnitsInStockUpdate.Text),  /// kalan bölümler add gibi.
                    QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text)
                });
                MessageBox.Show("Ürün Başarıyla Silindi", caption:"Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ürün Silinemedi", caption:"Hata!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            LoadProduct(); // butona basıldığı anda Dgw listesini yenilemek için.
            
        }




    }
}
