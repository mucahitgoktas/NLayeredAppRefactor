using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.Buisness.Abstract;
using Northwind.DataAccess.Concrete.NHibernate;

namespace NorthWind.Buisness.Concrete 
{
    public class ProductManager : IProductService
    {
        EfProductDal _productDal = new EfProductDal(); // ProductDal DataAccess'ten gelir.
        private EfProductDal efProductDal;
        private NhProductDal nhProductDal;

        public ProductManager(EfProductDal efProductDal)
        {
            this.efProductDal = efProductDal;
        }

        public ProductManager(NhProductDal nhProductDal)
        {
            this.nhProductDal = nhProductDal;
        }

        // alt çizgi ile isimlendirme sebebi ctor ile set edebilmek için ancak bu örnekte ctor yok.
        public List<Product> GetAll() // Product entities'ten gelir.
        {
            // iş kodları yazılır, şartlar vs.
            
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.Contains(productName));
        }
    }
}
