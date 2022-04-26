using Dit.Umb9.Mutobo.ToolBox.Interfaces;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Web;

namespace Dit.Umb9.Mutobo.ToolBox.Controllers.PageControllers
{
    internal class ProductPageController : ArticlePageController
    {
        public ProductPageController(ILogger<ArticlePageController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor, IImageService imageService, IPageLayoutService pageLayoutService, IMutoboContentService contentService, ISearchService searchService) : base(logger, compositeViewEngine, umbracoContextAccessor, imageService, pageLayoutService, contentService, searchService)
        {
        }
    }
}
