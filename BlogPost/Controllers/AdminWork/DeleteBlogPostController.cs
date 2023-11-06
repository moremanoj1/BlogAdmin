using BlogPost.ServicesContracts.ControllPanelServiceContract;
using Microsoft.AspNetCore.Mvc;

namespace BlogPost.Controllers.AdminWork
{
    [Controller]
    [Route("[controller]/[action]")]
    public class DeleteBlogPostController : Controller
    {
        /// <summary>
        /// Private Field For getting Service Instance
        /// </summary>
        /// <returns></returns>
        private IBlogsServiceContract _blogsServiceContract;

        /// <summary>
        /// Declaring Constructor
        /// </summary>
        /// <returns></returns>
        public DeleteBlogPostController(IBlogsServiceContract blogsServiceContract)
        {
            _blogsServiceContract = blogsServiceContract;
        }

        [HttpGet("{UrlHandle?}")]
        public ActionResult BlogDeletebyUrl(string UrlHandle)
        {
            if (UrlHandle == null)
            {
                return Redirect("~/ShowPost/ShowAllPost");
            }
            else
            {
                _blogsServiceContract.DeleteBlog(UrlHandle);
                return RedirectPermanent("~/ShowPost/ShowAllPost");
            }
        }
    }
}
