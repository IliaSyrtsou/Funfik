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
    /// Class representing a category of an article.
    /// </summary>
    public class Category : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required]
        public String Name { get; set; }

        public virtual List<Article> Articles { get; set; }
    }
}
