using BlogPost.Models.ControlPanelModel;
using BlogPost.ServicesContracts.ControllPanelServiceContract;
using Elfie.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace BlogPost.Controllers.AdminWork
{
    [Controller]
    [Route("[controller]/[action]")]
    public class AdminController : Controller
    {
        //Invoking Services
        private IBlogsServiceContract _blogServiceContract;

        public AdminController(IBlogsServiceContract blogsServiceContract)
        {
            _blogServiceContract = blogsServiceContract;
        }

        [Route("[action]")]
        public IActionResult AdminPanel()
        {
            return View();
        }

        [HttpGet("[action]")]
        public ActionResult AddBlog()
        {
            return View("~/Views/Admin/AddPost/AddBlog.cshtml");
        }

        [HttpPost("[action]")]
        public ActionResult AddBlog(BlogPosts blogPosts)
        {
            if (blogPosts.UrlHandle == null)
            {
                return View("~/Views/Admin/AddPost/AddBlog.cshtml");
            }
            else
            {
                _blogServiceContract.AddBlog(blogPosts);
                return View("~/Views/Admin/AddPost/AddBlog.cshtml");
            }

            //-------------------- ModelState.IsValid will be check ----------------------
            //if (ModelState.IsValid)
            //{
            //    _blogServiceContract.AddBlog(blogPosts);
            //}
        }

        //[HttpGet("/Admin/{UrlHandle}")]
        //public ActionResult GetPostContent()
        //{
        //    return PartialView(dynamic);
        //}

        [HttpGet("/Admin/{UrlHandle?}")]
        public ActionResult ShowPost(string? UrlHandle)
        {
            ViewBag.ShowPostbyUrl = _blogServiceContract.ShowBlog(UrlHandle);
            //BlogPosts post = _blogServiceContract.ShowBlog(UrlHandle);
            return PartialView("~/Views/Admin/GetPostContentPartal.cshtml");
        }
    }
}
