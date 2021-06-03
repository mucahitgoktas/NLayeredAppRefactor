using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Entities.Concrete;

namespace NorthWind.Buisness.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product> // "AbstractValidator" nuget package'dan geliyor.// Ben ürün(product) için kurallar yazacağım. 
    {
        public ProductValidator() // ctor
        {
            // kural yazımı : RuleFor (p => P.****).kural;
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün İsmi Boş Olamaz!"); // eğer istersek hata mesajını kendimiz yazabiliriz.
            RuleFor(p => p.CategoryId).NotEmpty(); // hata mesajı eklemezsek otomatik mesaj belleğinden mesaj gösterir.
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0); // UnitsInStock short olduğu için (short), GreaterThanOrEqualTo Int aldığı için değiştirmek gerek.
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2); // when kullanımı.

            // LessThan Between vs. her türlü kural var. 
            // FluentValidation'un kendi dökümantasyonuna gidip bakmak gerek.

            // Eğer FluentValidation ihtiyacımız olan kural kodunu içermiyorsa, bunu da bir metot aracılığıyla  kural olarak ekleyebiliyoruz.
            // örnek : 
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün Adı 'A' ile başlamalı");


            // ŞARTLARIN KULLANIMI : Entity.ValidationTool.cs'ye eklenecek, ardından form1.cs içerisinde tryCatch kullanılarak çalıştırılacak.

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A"); // return döndürüp String veri tipinin fonksiyonu olan Startswith özelliğini kullanarak valitadion oluşturduk.
        }
    }
}
