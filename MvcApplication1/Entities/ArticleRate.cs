using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication1.Entities
{
    /// <summary>
    /// Class representing a rate given to the article by a logged-in user.
    /// </summary>
    [Table("ArticleRates")]
    public class ArticleRate
    {
        [Key]
        public int ArticleRateId { get; set; }

        public int UserId { get; set; }

        public int ArticleId { get; set; }
        
        public int Rate { get; set; }
    }
}
