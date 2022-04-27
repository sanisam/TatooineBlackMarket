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
    public class ShopOverViewPage : ContentPage
    {
        public IEnumerable<string> TeaserCategories => this.Content.HasValue(DocumentTypes.ShopOverviewPage.Fields.TeaserCategories) ?
            this.Content.Value<IEnumerable<string>>(DocumentTypes.ShopOverviewPage.Fields.TeaserCategories) : null;

        public IPublishedContent ShopParentPage => this.Content.HasValue(DocumentTypes.ShopOverviewPage.Fields.ShopParentPage) ?
            this.Content.Value<IPublishedContent>(DocumentTypes.ShopOverviewPage.Fields.ShopParentPage) : null;
        public IEnumerable<ProductPage> Products { get; set; }



        public ShopOverViewPage(IPublishedContent content) : base(content)
        {


        }
    }
}
