using System.Collections.Generic;

namespace MyClassShop.Web.Models
{
    public class MenuGroupViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<MenuViewModel> Menus { set; get; }
    }
}