using Funfik.Core.Entities;

namespace Funfik.Core.Interfaces.EntityServiceInterfaces
{
    /// <summary>
    /// An interface for tag-related functionality.
    /// </summary>
    public interface ITagService
    {
        /// <summary>
        /// Adds tag to the database
        /// </summary>
        void AddTag(Tag tag);

        void DeleteTag();
    }
}
