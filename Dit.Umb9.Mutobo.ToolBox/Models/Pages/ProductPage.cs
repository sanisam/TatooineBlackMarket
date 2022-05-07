using Dit.Umb9.Mutobo.ToolBox.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;

namespace Dit.Umb9.Mutobo.ToolBox.Models.Pages
{
    public class ProductPage : ContentPage {

        public decimal Price => this.Content.HasValue(DocumentTypes.ProductPage.Fields.Price) ? 
            this.Content.Value<decimal>(DocumentTypes.ProductPage.Fields.Price) : 0;

        public bool ShowInTeaser => this.Content.HasValue(DocumentTypes.ProductPage.Fields.ShowInTeaser) ? 
            this.Content.Value<bool>(DocumentTypes.ProductPage.Fields.ShowInTeaser) : false;


        public IEnumerable<string> Categories => this.Content.HasValue(DocumentTypes.ProductPage.Fields.Categories) ?
            this.Content.Value<IEnumerable<string>>(DocumentTypes.ProductPage.Fields.Categories) : null;


        public ProductPage(IPublishedContent content) : base(content)
        {

        }

    }
}
