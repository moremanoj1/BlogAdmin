using BlogPost.Models.ControlPanelModel;
using BlogPost.ServicesContracts.ControllPanelServiceContract;
using Entitys.BlogDbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;

namespace BlogPost.Services.ControlPanelService
{
    public class BlogService : IBlogsServiceContract
    {
        //Declaring Id
        private BlogDBContext _blogDBContext;

        public BlogService(BlogDBContext blogDBContext)
        {
            _blogDBContext = blogDBContext;
        }

        public BlogPosts AddBlog(BlogPosts blogPosts)
        {
            if(blogPosts.Auther != null)
            {
                _blogDBContext.blogPosts.Add(blogPosts);
                _blogDBContext.SaveChanges();
            }
            return blogPosts;
        }

        public BlogPosts DeleteBlog(string UrlHandle)
        {
            try
            {
                if (UrlHandle != null)
                {
                    // Find the blog post based on UrlHandle
                    BlogPosts blogpost = _blogDBContext.blogPosts.FirstOrDefault(check => check.UrlHandle == UrlHandle);

                    if (blogpost != null)
                    {
                        _blogDBContext.blogPosts.Remove(blogpost);
                        _blogDBContext.SaveChanges();
                        return blogpost;
                    }
                    else
                    {
                        throw new Exception("Blog post not found.");
                    }
                }
                else
                {
                    throw new Exception("Invalid URL handle.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the blog post. Please try again later.", ex);
            }
        }

        public BlogPosts ShowBlog(string UrlHandle)
        {
            try
            {
                if (UrlHandle != null)
                {
                    BlogPosts blogpost = _blogDBContext.blogPosts.Where(check => check.UrlHandle == UrlHandle).FirstOrDefault();
                    return blogpost;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the blog post. Please try again later.");
            }
            throw new Exception("Blog post not found.");
        }

        public List<BlogPosts> ShowBlogs()
        {
            try
            {
                List<BlogPosts> blogpost = (List<BlogPosts>)_blogDBContext.blogPosts.Where(q => q.Id != null).ToList();
                return blogpost;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the blog post. Please try again later.");
            }
            throw new Exception("Blog post not found.");
        }

        public BlogPosts UpdateBlog(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
