using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys.Models.ControlPanelModel
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandle {  get; set; }
        public DateTime PublishDate{ get; set; }
        public string Auther { get; set; }
        public bool Visable { get; set; }
        public IEnumerable<Tages> Tages { get; set; }
    }
}
