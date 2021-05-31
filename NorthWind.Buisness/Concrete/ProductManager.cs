using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Buisness.Concrete 
{
    public class ProductManager
    {
        ProductDal _productDal = new ProductDal(); // ProductDal DataAccess'ten gelir.
                                                   // alt çizgi ile isimlendirme sebebi ctor ile set edebilmek için ancak bu örnekte ctor yok.
        public List<Product> GetAll() // Product entities'ten gelir.
        {
            // iş kodları yazılır, şartlar vs.
            
            return _productDal.GetAll();
        }
    }
}
