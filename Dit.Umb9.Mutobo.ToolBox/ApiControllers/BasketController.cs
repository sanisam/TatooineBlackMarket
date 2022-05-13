using Dit.Umb9.Mutobo.ToolBox.Constants;
using Dit.Umb9.Mutobo.ToolBox.Models.Pages;
using Dit.Umb9.Mutobo.ToolBox.Models.PoCo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Extensions;

namespace Dit.Umb9.Mutobo.ToolBox.ApiControllers
{
    public class BasketController : UmbracoApiController
    {
        private IUmbracoContextAccessor _contextAccessor;


        public BasketController(IUmbracoContextAccessor contextAccessor)
        {
            this._contextAccessor = contextAccessor;

        }

        [HttpPost]
        public  Basket GetBasketBasketDetails(IEnumerable<Product> products)
        {
            IUmbracoContext ctx = null;

            if (this._contextAccessor.TryGetUmbracoContext(out ctx))
            {
                var result = new Basket();
                var tst = ctx.Content.GetAtRoot();
                result.Products = ctx.Content.GetAtRoot().FirstOrDefault(c => c.ContentType.Alias == DocumentTypes.HomePage.Alias)
                    .DescendantsOrSelf().Where(c => c.ContentType.Alias == DocumentTypes.ProductPage.Alias && products.Select(p => p.Id).Contains(c.Key)).Select(c => new Product {
                        Price = c.HasValue(DocumentTypes.ProductPage.Fields.Price) ? c.Value<double>(DocumentTypes.ProductPage.Fields.Price) : 0,
                        Name = c.HasValue(DocumentTypes.BasePage.Fields.PageTitle) ? c.Value<string>(DocumentTypes.BasePage.Fields.PageTitle) : "",
                        Count = products.FirstOrDefault(p => p.Id == c.Key)?.Count ?? 0
                    });

                foreach (var product in result.Products) {
                    result.TotalPrice += product.Price * product.Count;
                }

                return result;
            }

            return null;

        }


        //[HttpGet]
        //public Basket GetBasket(Guid id)
        //{ 
            
        
        //}


        //[HttpPost]
        //public void PersistBasket()
        //{ 
        
        //}


    }
}
