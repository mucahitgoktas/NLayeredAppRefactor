using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using System.Linq.Expressions;

namespace Northwind.DataAccess.Concrete.EntityFramework // Veri tabanı iletişimi için somut işlemler.
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthWindContext>,IProductDal
    {
        

        
    }
}
