using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T:class
    {
        Task<T>GetByIdAsync(int id);
        IQueryable<T> GetAll();

        //Kullanım amacı database herhangi bir sorgu atmadan önce ne yapacağını belirler(örn:orderby ile sıralama) sonrasında database yapacağı işlemi gönderir ve ona göre
        //değer dönderir. Bu sayede sorguyu atıp memorye alıp memoride işlemini yapmaz.
        IQueryable<T> Where(Expression <Func<T,bool>> expression);
        Task AddAsync (T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        
        //IEnum ile istediğim classa cast(dönüştürme) yapabilirim.
        Task AddRangeAsync (IEnumerable<T> entities);

        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entites);
    }
}
