using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using NorthWind.Buisness.Abstract;
using NorthWind.Buisness.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;

namespace NorthWind.Buisness.DependencyResolvers.Ninject
{
    public class BuisnessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope(); // Biri senden IProductService isterse, ProductManager Sınıfını ver.
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope(); // Biri senden IProductDal isterse, EfProductDal Sınıfını ver.
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope(); // Biri senden ICategoryService isterse, CategoryManager Sınıfını ver.
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope(); // Biri senden ICategoryDal isterse, EfCategoryDal Sınıfını ver.
            //InSingletonScope : Performansı artırır, bir nesneyi bir kez ürettikten sonra hep kullanılabilir.

            // Yarın, Ef'den Nh'ye geçiş yaptığımızda ilgili alanları değiştirip kolayca dönüşüm yapabiliriz.


        }
    }
}
