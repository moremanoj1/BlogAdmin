using BlogPost.ServicesContracts.ControllPanelServiceContract;
using Elfie.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace BlogPost.Controllers.AdminWork
{
    [Route("[controller]/[action]")]
    public class ShowPostController : Controller
    {
        //Declaring field 
        private IBlogsServiceContract _blogServiceContract;

        //Constructor
        public ShowPostController(IBlogsServiceContract blogsServiceContract)
        {
            _blogServiceContract = blogsServiceContract;
        }

        [HttpGet]
        public IActionResult ShowAllPost()
        {
            ViewBag.ShowAllPost = _blogServiceContract.ShowBlogs();
            return View("~/Views/Admin/ShowPost/Blogs.cshtml");
        }

        [HttpGet("{UrlHandle?}")]
        public IActionResult BlogShowbyUrl(string UrlHandle)
        {
            if (UrlHandle == null)
            {
                return RedirectToAction("ShowAllPost");
            }
            else
            {
                ViewBag.ShowPostbyUrl = _blogServiceContract.ShowBlog(UrlHandle);
                return View("~/Views/Admin/ShowPost/BlogsbyUrl.cshtml");
            }
        }
    }
}
