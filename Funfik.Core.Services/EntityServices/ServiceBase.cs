using Funfik.Core.Entities;

namespace Funfik.Core.Services.EntityServices
{
    public abstract class ServiceBase<TEntity> where TEntity: BaseEntity
    {
        protected I DataEntityDao { get; private set; }
    }
}
