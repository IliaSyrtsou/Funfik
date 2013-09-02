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
    /// Class representing a chapter of an article.
    /// </summary>
    public class Chapter 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChapterId { get; set; }

        public int ArticleId { get; set; }

        [Required]
        public String Title { get; set; }

        [Required]
        public String Text { get; set; }

        [ForeignKey("ArticleId")]
        public virtual Article Article { get; set; }
    }
}
