using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Abstract;

namespace Northwind.DataAccess.Abstract
{
    public interface IentityRepository<T> where T:class ,IEntity,new() // kullanıcı type olarak class kullansın, IEntity kullansın ve new'lesin.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // Listeyi getirirken bir filtre versin, vermezse hepsini getir.
        T Get(Expression<Func<T, bool>> filter = null); // (önceden burası id'di) burada kendisi bir filtre versin ve öyle getir.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
