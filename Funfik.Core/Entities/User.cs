using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Funfik.Core.Entities
{
    /// <summary>
    /// Class representing a user of the fanfic site.
    /// </summary>
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        public String UserName { get; set; }

        [EmailAddress]
        public String Email { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        public virtual List<ArticleRate> ArticleRates { get; set; }
    }
}

