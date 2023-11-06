using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost.Models.ControlPanelModel
{
    public class Tages
    {
        [Key]
        public Guid id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public IEnumerable<BlogPosts> blogs { get; set; }
    }
}
