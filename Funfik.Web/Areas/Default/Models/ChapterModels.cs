using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Funfik.Core.Entities;

namespace Funfik.Web.Areas.Default.Models
{
    public class ChapterModel
    {
        
        public int ChapterId { get; set; }

        public int ArticleId { get; set; }

        public String Text { get; set; }

        public virtual Article Article { get; set; }
    }
}