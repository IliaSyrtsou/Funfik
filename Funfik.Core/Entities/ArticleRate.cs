using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Funfik.Core.Entities
{
    /// <summary>
    /// Class representing a rate given to the article by a logged-in user.
    /// </summary>
    public class ArticleRate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticleRateId { get; set; }

        public int UserId { get; set; }

        public int ArticleId { get; set; }
        
        public int Rate { get; set; }

        [ForeignKey("ArticleId")]
        public virtual Article Article { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
