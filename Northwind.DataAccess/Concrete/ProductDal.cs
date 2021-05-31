using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete // Veri tabanı iletişimi için somut işlemler.
{
    public class ProductDal // ürünlerle ilgili veri tabanı operasyonları.
    {
        public List<Product> GetAll() // veri tabanından hepsini getir metodu.
        {
            using (NorthWindContext Context = new NorthWindContext()) // NordWindContext.cs içerisinde db bağlantısı kurmuştuk. Metot içerisinde new'ledik.
            {
                return Context.Products.ToList(); // ürünleri listeye çeviriyor. // bu bağlantı kodu her metot için olmazsa olmaz.
            }
        }

        public Product Get(int id) // id getir metodu.
        {
            using (NorthWindContext Context = new NorthWindContext())
            {
                return Context.Products.SingleOrDefault(p => p.ProductId == id); // burada bir listeye ihtiyacımız yok. sadece id'yi Product id'ye eşitliyoruz.

            }
        }

        public void Add(Product product) // ürün ekleme.
        {
            using (NorthWindContext Context = new NorthWindContext())
            {
                Context.Products.Add(product); // Verilen yeni ürünü add(hazır fonksiyon) ile yazıyoruz.
                Context.SaveChanges(); // Değişiklikleri veri tabanına kaydediyoruz.

            }
        }

        public void Update(Product product) // ürün güncelleme
        {
            using (NorthWindContext Context = new NorthWindContext())
            {
                

            }
        }

        public void Delete(Product product) // Ürün silme
        {
            using (NorthWindContext Context = new NorthWindContext())
            {
                

            }
        }

    }
}
