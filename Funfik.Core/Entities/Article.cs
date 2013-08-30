using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funfik.Core.Entities
{
    /// <summary>
    /// Class representing an article written by a user.
    /// </summary>
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticleId { get; set; }

        public int UserId { get; set; }

        [Required]
        public String Title { get; set; }

        [Required]
        public Category Category { get; set; }

        public virtual ICollection<Chapter> Chapters { get; set; }

        public virtual ICollection<ArticleRate> ArticleRates { get; set; } 

        public virtual ICollection<Tag> Tags { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastEditDate { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}
