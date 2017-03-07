using MyBlog.Core.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class ListViewModel
    {
        //public IList<Post> Posts { get;  set; }
        public IQueryable<Post> Posts { get; set; }
        public int TotalPosts { get; set; }
    }
}