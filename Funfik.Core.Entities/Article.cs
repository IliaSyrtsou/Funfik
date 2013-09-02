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
    public class Article : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticleId { get; set; }

        public int UserId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public String Title { get; set; }

        public String Annotation { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Chapter> Chapters { get; set; }

        public virtual ICollection<Like> Likes { get; set; } 

        public virtual ICollection<Tag> Tags { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastEditDate { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}
