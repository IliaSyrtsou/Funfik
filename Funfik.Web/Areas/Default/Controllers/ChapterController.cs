using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Funfik.Core.Entities;

namespace Funfik.Web.Areas.Default.Controllers
{
    public partial class ChapterController : Controller
    {
        public virtual ActionResult ShowChapter(Chapter chapter)
        {
            return PartialView(MVC.Default.Chapter.Views._ShowChapterPartial, chapter);
        }

    }
}
