using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IServices<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();

        //Kullanım amacı database herhangi bir sorgu atmadan önce ne yapacağını belirler(örn:orderby ile sıralama) sonrasında database yapacağı işlemi gönderir ve ona göre
        //değer dönderir. Bu sayede sorguyu atıp memorye alıp memoride işlemini yapmaz.
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        //IEnum ile istediğim classa cast(dönüştürme) yapabilirim.
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
       
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entites);
    }
}
