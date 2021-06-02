
namespace NorthWind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxCategoryAdd = new System.Windows.Forms.ComboBox();
            this.tbxQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitsInStockAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnitAdd = new System.Windows.Forms.Label();
            this.lblUnitInStockAdd = new System.Windows.Forms.Label();
            this.lblUnitPriceAdd = new System.Windows.Forms.Label();
            this.lblCategoryAdd = new System.Windows.Forms.Label();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitsInStockUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnitUpdate = new System.Windows.Forms.Label();
            this.lblUnitsInStockUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblCategoryUpdate = new System.Windows.Forms.Label();
            this.lblProductUpdate = new System.Windows.Forms.Label();
            this.btnDltDelete = new System.Windows.Forms.Button();
            this.lblDltDelete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 232);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowTemplate.Height = 25;
            this.dgwProduct.Size = new System.Drawing.Size(890, 206);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            this.dgwProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(211, 82);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(70, 31);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(135, 23);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 34);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(51, 15);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(12, 117);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(211, 82);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün İsmine Göre Ara";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(70, 30);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(135, 23);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(2, 33);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(58, 15);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün İsmi";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.cbxCategoryAdd);
            this.gbxAdd.Controls.Add(this.tbxQuantityPerUnitAdd);
            this.gbxAdd.Controls.Add(this.tbxUnitsInStockAdd);
            this.gbxAdd.Controls.Add(this.tbxUnitPriceAdd);
            this.gbxAdd.Controls.Add(this.tbxProductNameAdd);
            this.gbxAdd.Controls.Add(this.lblQuantityPerUnitAdd);
            this.gbxAdd.Controls.Add(this.lblUnitInStockAdd);
            this.gbxAdd.Controls.Add(this.lblUnitPriceAdd);
            this.gbxAdd.Controls.Add(this.lblCategoryAdd);
            this.gbxAdd.Controls.Add(this.lblProductNameAdd);
            this.gbxAdd.Location = new System.Drawing.Point(13, 454);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(888, 181);
            this.gbxAdd.TabIndex = 3;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Ürün Ekleme";
            this.gbxAdd.Enter += new System.EventHandler(this.gbxAdd_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(457, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxCategoryAdd
            // 
            this.cbxCategoryAdd.FormattingEnabled = true;
            this.cbxCategoryAdd.Location = new System.Drawing.Point(69, 72);
            this.cbxCategoryAdd.Name = "cbxCategoryAdd";
            this.cbxCategoryAdd.Size = new System.Drawing.Size(169, 23);
            this.cbxCategoryAdd.TabIndex = 10;
            this.cbxCategoryAdd.SelectedIndexChanged += new System.EventHandler(this.cbxCategoryAdd_SelectedIndexChanged);
            // 
            // tbxQuantityPerUnitAdd
            // 
            this.tbxQuantityPerUnitAdd.Location = new System.Drawing.Point(432, 72);
            this.tbxQuantityPerUnitAdd.Name = "tbxQuantityPerUnitAdd";
            this.tbxQuantityPerUnitAdd.Size = new System.Drawing.Size(168, 23);
            this.tbxQuantityPerUnitAdd.TabIndex = 9;
            // 
            // tbxUnitsInStockAdd
            // 
            this.tbxUnitsInStockAdd.Location = new System.Drawing.Point(432, 27);
            this.tbxUnitsInStockAdd.Name = "tbxUnitsInStockAdd";
            this.tbxUnitsInStockAdd.Size = new System.Drawing.Size(168, 23);
            this.tbxUnitsInStockAdd.TabIndex = 8;
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(69, 118);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(169, 23);
            this.tbxUnitPriceAdd.TabIndex = 7;
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(69, 27);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(169, 23);
            this.tbxProductNameAdd.TabIndex = 6;
            // 
            // lblQuantityPerUnitAdd
            // 
            this.lblQuantityPerUnitAdd.AutoSize = true;
            this.lblQuantityPerUnitAdd.Location = new System.Drawing.Point(363, 78);
            this.lblQuantityPerUnitAdd.Name = "lblQuantityPerUnitAdd";
            this.lblQuantityPerUnitAdd.Size = new System.Drawing.Size(69, 15);
            this.lblQuantityPerUnitAdd.TabIndex = 4;
            this.lblQuantityPerUnitAdd.Text = "Birim Adedi";
            // 
            // lblUnitInStockAdd
            // 
            this.lblUnitInStockAdd.AutoSize = true;
            this.lblUnitInStockAdd.Location = new System.Drawing.Point(363, 30);
            this.lblUnitInStockAdd.Name = "lblUnitInStockAdd";
            this.lblUnitInStockAdd.Size = new System.Drawing.Size(64, 15);
            this.lblUnitInStockAdd.TabIndex = 3;
            this.lblUnitInStockAdd.Text = "Stok Adedi";
            // 
            // lblUnitPriceAdd
            // 
            this.lblUnitPriceAdd.AutoSize = true;
            this.lblUnitPriceAdd.Location = new System.Drawing.Point(6, 121);
            this.lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            this.lblUnitPriceAdd.Size = new System.Drawing.Size(32, 15);
            this.lblUnitPriceAdd.TabIndex = 2;
            this.lblUnitPriceAdd.Text = "Fiyat";
            // 
            // lblCategoryAdd
            // 
            this.lblCategoryAdd.AutoSize = true;
            this.lblCategoryAdd.Location = new System.Drawing.Point(6, 75);
            this.lblCategoryAdd.Name = "lblCategoryAdd";
            this.lblCategoryAdd.Size = new System.Drawing.Size(51, 15);
            this.lblCategoryAdd.TabIndex = 1;
            this.lblCategoryAdd.Text = "Kategori";
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Location = new System.Drawing.Point(6, 30);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(54, 15);
            this.lblProductNameAdd.TabIndex = 0;
            this.lblProductNameAdd.Text = "Ürün Adı";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.lblDltDelete);
            this.gbxUpdate.Controls.Add(this.btnDltDelete);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.cbxCategoryUpdate);
            this.gbxUpdate.Controls.Add(this.tbxQuantityPerUnitUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUnitsInStockUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxProductNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblQuantityPerUnitUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitsInStockUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblCategoryUpdate);
            this.gbxUpdate.Controls.Add(this.lblProductUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(13, 641);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(888, 181);
            this.gbxUpdate.TabIndex = 12;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Ürün Güncelleme";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(457, 118);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxCategoryUpdate
            // 
            this.cbxCategoryUpdate.FormattingEnabled = true;
            this.cbxCategoryUpdate.Location = new System.Drawing.Point(69, 72);
            this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            this.cbxCategoryUpdate.Size = new System.Drawing.Size(169, 23);
            this.cbxCategoryUpdate.TabIndex = 10;
            // 
            // tbxQuantityPerUnitUpdate
            // 
            this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(432, 72);
            this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(168, 23);
            this.tbxQuantityPerUnitUpdate.TabIndex = 9;
            // 
            // tbxUnitsInStockUpdate
            // 
            this.tbxUnitsInStockUpdate.Location = new System.Drawing.Point(432, 27);
            this.tbxUnitsInStockUpdate.Name = "tbxUnitsInStockUpdate";
            this.tbxUnitsInStockUpdate.Size = new System.Drawing.Size(168, 23);
            this.tbxUnitsInStockUpdate.TabIndex = 8;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(69, 118);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(169, 23);
            this.tbxUnitPriceUpdate.TabIndex = 7;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(69, 27);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(169, 23);
            this.tbxProductNameUpdate.TabIndex = 6;
            // 
            // lblQuantityPerUnitUpdate
            // 
            this.lblQuantityPerUnitUpdate.AutoSize = true;
            this.lblQuantityPerUnitUpdate.Location = new System.Drawing.Point(363, 78);
            this.lblQuantityPerUnitUpdate.Name = "lblQuantityPerUnitUpdate";
            this.lblQuantityPerUnitUpdate.Size = new System.Drawing.Size(69, 15);
            this.lblQuantityPerUnitUpdate.TabIndex = 4;
            this.lblQuantityPerUnitUpdate.Text = "Birim Adedi";
            // 
            // lblUnitsInStockUpdate
            // 
            this.lblUnitsInStockUpdate.AutoSize = true;
            this.lblUnitsInStockUpdate.Location = new System.Drawing.Point(363, 30);
            this.lblUnitsInStockUpdate.Name = "lblUnitsInStockUpdate";
            this.lblUnitsInStockUpdate.Size = new System.Drawing.Size(64, 15);
            this.lblUnitsInStockUpdate.TabIndex = 3;
            this.lblUnitsInStockUpdate.Text = "Stok Adedi";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(6, 121);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(32, 15);
            this.lblUnitPriceUpdate.TabIndex = 2;
            this.lblUnitPriceUpdate.Text = "Fiyat";
            // 
            // lblCategoryUpdate
            // 
            this.lblCategoryUpdate.AutoSize = true;
            this.lblCategoryUpdate.Location = new System.Drawing.Point(6, 75);
            this.lblCategoryUpdate.Name = "lblCategoryUpdate";
            this.lblCategoryUpdate.Size = new System.Drawing.Size(51, 15);
            this.lblCategoryUpdate.TabIndex = 1;
            this.lblCategoryUpdate.Text = "Kategori";
            // 
            // lblProductUpdate
            // 
            this.lblProductUpdate.AutoSize = true;
            this.lblProductUpdate.Location = new System.Drawing.Point(6, 30);
            this.lblProductUpdate.Name = "lblProductUpdate";
            this.lblProductUpdate.Size = new System.Drawing.Size(54, 15);
            this.lblProductUpdate.TabIndex = 0;
            this.lblProductUpdate.Text = "Ürün Adı";
            // 
            // btnDltDelete
            // 
            this.btnDltDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDltDelete.Location = new System.Drawing.Point(696, 71);
            this.btnDltDelete.Name = "btnDltDelete";
            this.btnDltDelete.Size = new System.Drawing.Size(116, 53);
            this.btnDltDelete.TabIndex = 12;
            this.btnDltDelete.Text = "SİL";
            this.btnDltDelete.UseVisualStyleBackColor = true;
            // 
            // lblDltDelete
            // 
            this.lblDltDelete.AutoSize = true;
            this.lblDltDelete.Location = new System.Drawing.Point(712, 53);
            this.lblDltDelete.Name = "lblDltDelete";
            this.lblDltDelete.Size = new System.Drawing.Size(85, 15);
            this.lblDltDelete.TabIndex = 13;
            this.lblDltDelete.Text = "Seçili Ürünü Sil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 857);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.ComboBox cbxCategoryAdd;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitAdd;
        private System.Windows.Forms.TextBox tbxUnitsInStockAdd;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.Label lblQuantityPerUnitAdd;
        private System.Windows.Forms.Label lblUnitInStockAdd;
        private System.Windows.Forms.Label lblUnitPriceAdd;
        private System.Windows.Forms.Label lblCategoryAdd;
        private System.Windows.Forms.Label lblProductNameAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryUpdate;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
        private System.Windows.Forms.TextBox tbxUnitsInStockUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Label lblQuantityPerUnitUpdate;
        private System.Windows.Forms.Label lblUnitsInStockUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblCategoryUpdate;
        private System.Windows.Forms.Label lblProductUpdate;
        private System.Windows.Forms.Label lblStockPerUnitDelete;
        private System.Windows.Forms.Label lblDltDelete;
        private System.Windows.Forms.Button btnDltDelete;
    }
}

