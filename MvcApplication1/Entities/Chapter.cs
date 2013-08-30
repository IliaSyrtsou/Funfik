using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication1.Entities
{
    /// <summary>
    /// Class representing a chapter of an article.
    /// </summary>
    [Table("Chapters")]
    public class Chapter
    {
        [Key]
        public int ChapterId { get; set; }
        public int ArticleId { get; set; }
        public String Text { get; set; }
    }
}
