using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Funfik.Web.Areas.Default.Models
{
    public class ShowTagModel
    {
        public int TagId { get; private set; }

        public int UserId { get; private set; }

        public int ArticleId { get; private set; }

        public String Title { get; private set; }
    }

    public class AddTagModel
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public int ArticleId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public String Title { get; set; }
    }
}