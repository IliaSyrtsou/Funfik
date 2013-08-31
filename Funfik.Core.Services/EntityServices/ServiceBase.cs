using Funfik.Core.DataAccess;
using Funfik.Core.Entities;
using Funfik.Core.Interfaces.EntityServiceInterfaces;

namespace Funfik.Core.Services.EntityServices
{
    public abstract class ServiceBase<TEntity> : IService<TEntity> 
        where TEntity: BaseEntity
    {
        public FunfikDb Database { get; private set; }


        public abstract TEntity Get(int id);

        public abstract void Detele(int id);

        public abstract void Create(TEntity entity);

    }
}
