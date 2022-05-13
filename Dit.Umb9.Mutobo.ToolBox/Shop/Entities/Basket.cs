using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dit.Umb9.Mutobo.ToolBox.Shop.Entities
{
    public class Basket
    {
        public Guid ID { get; set; }
        public virtual ICollection<Product> Products { get; set; }
       
    }
}
