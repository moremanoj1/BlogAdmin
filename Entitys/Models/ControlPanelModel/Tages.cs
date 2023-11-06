using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys.Models.ControlPanelModel
{
    public class Tages
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public IEnumerable<BlogPost> blogs { get; set; }
    }
}
