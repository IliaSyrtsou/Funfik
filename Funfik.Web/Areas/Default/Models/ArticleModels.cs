using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Funfik.Web.Areas.Default.Models
{
    public class ShowArticleModel
    {
        public int UserId { get; private set; }

        public int ArticleId { get; private set; }

        public int CategoryId { get; set; }

        public String Title { get; set; }
    }

    public class CreateOrEditArticleModel
    {
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [Display(Name = "Title")]
        public String Title { get; set; }
    }
}