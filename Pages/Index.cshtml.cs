using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using razorweb.models;

namespace CsharpRazor09.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MyBlogContext _myblogContext;

        public IndexModel(ILogger<IndexModel> logger, MyBlogContext myblogContext)
        {
            _logger = logger;
            _myblogContext = myblogContext;
        }

        public void OnGet()
        {
            var posts = (from a in _myblogContext.articles
                         orderby a.Created descending
                         select a).ToList();
            ViewData["posts"] = posts;
        }
    }
}
