using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication1.Entities
{
    /// <summary>
    /// Class representing a tag which can be attached to the article.
    /// </summary>
    [Table("Tags")]
    public class Tag
    {
        [Key]
        public int TagId { get; set; }

        [Required]
        public int ArticleId { get; set; }

        public String TagContent { get; set; }
        
        public int UsageCount { get; set; }
    }
}
