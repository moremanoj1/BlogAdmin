using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost.Models.ControlPanelModel
{
    public class BlogPosts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Heading Should Not Null")]
        public string Heading { get; set; }

        [Required(ErrorMessage ="Page Title Should Not Be Empty")]
        public string PageTitle { get; set; }

        [Required(ErrorMessage ="Content Should Not Empty")]
        [MinLength(50, ErrorMessage ="Content should be at least 50 char")]
        public string Content { get; set; }

        [Required(ErrorMessage ="Short Description Should Not Be Empty")]
        public string ShortDescription { get; set; }

        public string FeaturedImageUrl { get; set; }

        [Required(ErrorMessage = "Url should not be Empty")]
        public string UrlHandle { get; set; }

        public DateTime PublishDate{ get; set; } = DateTime.Now;

        [Required(ErrorMessage ="Prvoid Auther Name")]
        public string Auther { get; set; }

        public bool Visable { get; set; }
        public IEnumerable<Tages> Tages { get; set; }
    }
}
