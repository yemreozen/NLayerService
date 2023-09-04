using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.UnitOfWorks
{
    public interface IUnityOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
