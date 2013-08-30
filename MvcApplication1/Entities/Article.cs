using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication1.Entities
{
    /// <summary>
    /// Class representing an article written by a user.
    /// </summary>
    [Table("Articles")]
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }

        public int UserId { get; set; }

        [Required]
        public String Title { get; set; }

        public String Content { get; set; }

        public virtual ICollection<Chapter> Chapters { get; set; }

        public virtual ICollection<ArticleRate> Rates { get; set; } 

        public virtual ICollection<Tag> Tags { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastEditDate { get; set; }

    }
}
