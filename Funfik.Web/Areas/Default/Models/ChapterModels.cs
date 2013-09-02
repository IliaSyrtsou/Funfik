using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Funfik.Core.Entities;

namespace Funfik.Web.Areas.Default.Models
{
    public class ShowChapterModel
    {
        public int ChapterId { get; private set; }

        public int ArticleId { get; private set; }

        public String Text { get; private set; }
    }

    public class CreateChapterModel
    {
        [Required]
        public int ArticleId { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public String Text { get; set; }
    }

    public class EditChapterModel
    {
        [Required]
        [DataType(DataType.MultilineText)]
        public String Text { get; set; }
    }
}