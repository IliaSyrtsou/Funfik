using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarkdownSharp;

namespace Funfik.Web.Helpers
{
    public static class MarkdownHelper
    {
        private static Markdown markdownTransformer = new Markdown();

        public static IHtmlString Markdown(this HtmlHelper helper, string text)
        {
            String html = markdownTransformer.Transform(text);
            return new MvcHtmlString(html);
        }
    }
}