using Dit.Umb9.Mutobo.ToolBox.Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dit.Umb9.Mutobo.ToolBox.Shop
{
    public static class ShopInitializer
    {


        public static void Initialize(ShopContext context)
        {


            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Baskets.Any())
            {
                return;   // DB has been seeded
            }

            var baskets = new Basket[]
            {
            new Basket{ID = Guid.NewGuid(), Products= new List<Product>(){ 
            
                new Product
                {
                    Id = Guid.NewGuid(),
                    Price = 5.45,
                    Text = "Test"
                }
            } },

            };
            foreach (Basket b in baskets)
            {
                context.Baskets.Add(b);
            }
            context.SaveChanges();
        }
    }
}
