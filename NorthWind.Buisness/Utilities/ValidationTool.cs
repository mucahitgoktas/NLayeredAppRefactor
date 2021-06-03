using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace NorthWind.Buisness.Utilities
{
    public static class ValidationTool
    {
        public static void Valitade(IValidator validator,object entity) // ProductManager.cs'de kullanılacak.
        {
            // FluintValidation İle Kullanılacak metot
            var entity1 = new ValidationContext<object>(entity);
            var result = validator.Validate(entity1); // "entity1" Product ya da benzeri nesneler olacak. // entity1 stackoverflow'dan bulduğum çözüm sayesinde yeniden oluşturuldu.
            if (result.Errors.Count > 0) // eğer product ile ilgili 0 dan fazla error gelirse.
            {
                throw new ValidationException(result.Errors); // doğrulama şartlarını çalıştır.
            }
        }
    }
}
