using BlogPost.Models.ControlPanelModel;

namespace BlogPost.ServicesContracts.ControllPanelServiceContract
{
    public interface IBlogsServiceContract
    {
        List<BlogPosts> ShowBlogs();
        BlogPosts AddBlog(BlogPosts blogPosts);
        BlogPosts ShowBlog(string UrlHandle);
        BlogPosts UpdateBlog(Guid id);
        BlogPosts DeleteBlog(string UrlHandle);
    }
}
