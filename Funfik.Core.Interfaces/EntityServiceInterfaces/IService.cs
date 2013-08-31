using System.Collections.Generic;
using Funfik.Core.Entities;

namespace Funfik.Core.Interfaces.EntityServiceInterfaces
{
    /// <summary>
    /// A base service generic interface each entity service must inherit from. Provides basic CRUD functionality.
    /// </summary>
    public interface IService<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        /// Fetches an entity from database by an id.
        /// </summary>
        TEntity Get(int id);

        /// <summary>
        /// Deteles entity with a given id.
        /// </summary>
        void Detele(int id);

        /// <summary>
        /// Creates new user in database.
        /// </summary>
        void Create(TEntity entity);

    }
}
