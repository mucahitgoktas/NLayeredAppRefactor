using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Concrete;

namespace NorthWind.Buisness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
