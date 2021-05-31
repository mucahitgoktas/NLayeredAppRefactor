using System;
using System.Collections.Generic;
using System.Data.Entity; // Entity FrameWork
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete
{
    class NorthWindContext:DbContext // EntityFrameWork ile gelen özellik DataBase bağlantısı kurmayı sağlıyor.
    {
        public DbSet<Product> Products { get; set; } // Entities içerisindeki Product.cs'yi Database'deki Product Table'ı ile bağdaştıran prop.
                                                     // Buradan ProductDal'a geçiş yapıp düzenleyelim.

    }
}
