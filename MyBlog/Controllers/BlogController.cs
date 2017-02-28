using MyBlog.Core.Abstract;
using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        private IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }


        public ViewResult Posts(int p = 1)
        {
            //pick latest 10 posts
            var posts = _blogRepository.Posts;
            var listViewModel = new ListViewModel
            {
                Posts = posts,
                TotalPosts = 10
            };
            ViewBag.Title = "Latest Posts";
            return View("List", listViewModel);
        }

        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }
    }
}
