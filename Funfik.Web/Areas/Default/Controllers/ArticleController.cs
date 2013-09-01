using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Funfik.Core.Entities;
using Funfik.Core.DataAccess;
using Funfik.Core.Interfaces.EntityServiceInterfaces;

namespace Funfik.Web.Areas.Default.Controllers
{
    [Authorize]
    public partial class ArticleController : Controller
    {
        private FunfikDb context = new FunfikDb();
        private IArticleService ArticleService { get; set; }
        private IChapterService ChapterService { get; set; }

        public ArticleController(IArticleService articleService, IChapterService chapterService)
        {
            ArticleService = articleService;
            ChapterService = chapterService;
        }

        //
        // GET: /Article/
        [AllowAnonymous]
        public virtual ViewResult Index()
        {
            return View(ArticleService.GetArticles(100));
        }

        //
        // GET: /Article/Details/5
        [AllowAnonymous]
        public virtual ViewResult Details(int id)
        {
            return View(ArticleService.GetArticleById(id));
        }

        //
        // GET: /Article/Create

        public virtual ActionResult Create()
        {
            ViewBag.PossibleCategories = context.Categories;
            return View();
        } 

        //
        // POST: /Article/Create

        [HttpPost]
        public virtual ActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                context.Articles.Add(article);
                context.SaveChanges();
                return RedirectToAction(MVC.Default.Article.Index());  
            }

            ViewBag.PossibleUsers = context.Users;
            ViewBag.PossibleCategories = context.Categories;
            return View(article);
        }
        
        //
        // GET: /Article/Edit/5

        public virtual ActionResult Edit(int id)
        {
            Article article = context.Articles.Single(x => x.ArticleId == id);
            ViewBag.PossibleUsers = context.Users;
            ViewBag.PossibleCategories = context.Categories;
            return View(article);
        }

        //
        // POST: /Article/Edit/5

        [HttpPost]
        public virtual ActionResult Edit(Article article)
        {
            if (ModelState.IsValid)
            {
                context.Entry(article).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction(MVC.Default.Article.Index());
            }
            ViewBag.PossibleUsers = context.Users;
            ViewBag.PossibleCategories = context.Categories;
            return View(article);
        }

        //
        // GET: /Article/Delete/5

        public virtual ActionResult Delete(int id)
        {
            Article article = context.Articles.Single(x => x.ArticleId == id);
            return View(article);
        }

        //
        // POST: /Article/Delete/5

        [HttpPost, ActionName("Delete")]
        public virtual ActionResult DeleteConfirmed(int id)
        {
            Article article = context.Articles.Single(x => x.ArticleId == id);
            context.Articles.Remove(article);
            context.SaveChanges();
            return RedirectToAction(MVC.Default.Article.Index());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}