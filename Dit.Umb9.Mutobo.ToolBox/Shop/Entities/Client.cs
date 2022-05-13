using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dit.Umb9.Mutobo.ToolBox.Shop.Entities
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int ClientNo { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Country   { get; set; }


    }
}
