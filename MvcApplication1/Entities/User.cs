using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication1.Entities
{
    /// <summary>
    /// Class representing a user of the fanfic site.
    /// </summary>
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public String UserName { get; set; }

        public virtual ICollection<Article> Articles { get; set; } 
    }
}

