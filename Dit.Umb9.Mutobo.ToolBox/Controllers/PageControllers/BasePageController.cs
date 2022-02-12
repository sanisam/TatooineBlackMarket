using Dit.Umb9.Mutobo.ToolBox.Constants;
using Dit.Umb9.Mutobo.ToolBox.Interfaces;
using Dit.Umb9.Mutobo.ToolBox.Models.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Extensions;

namespace Dit.Umb9.Mutobo.ToolBox.Controllers.PageControllers
{
    public class BasePageController : RenderController
    {

        protected readonly IImageService ImageService;
        protected readonly IPageLayoutService PageLayoutService;
        protected readonly IMutoboContentService ContentService;


        public BasePageController(
            ILogger<RenderController> logger,
            ICompositeViewEngine compositeViewEngine,
            IUmbracoContextAccessor umbracoContextAccessor,
            IImageService imageService,
            IPageLayoutService pageLayoutService,
            IMutoboContentService contentService)
            : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            ImageService = imageService;
            PageLayoutService = pageLayoutService;
            ContentService = contentService;
   
        }

        public override IActionResult Index() 
        {
            var redirectLink = CurrentPage.Value<Link>(DocumentTypes.BasePage.Fields.RedirectLink);

            if (!string.IsNullOrEmpty(redirectLink?.Url))
            {
                var url = redirectLink.Url.ToLower();
                if (!url.StartsWith("http"))
                    url = url.Insert(0, "http://");

                HttpContext.Response.Redirect(url);
            }

            var model = ContentService.GetPageModel(CurrentPage);

            var homePage = CurrentPage.AncestorsOrSelf()
                .FirstOrDefault(c => c.ContentType.Alias == DocumentTypes.HomePage.Alias);


            model.HeaderConfiguration = PageLayoutService.GetHeaderConfiguration(CurrentPage);
            model.FooterConfiguration = PageLayoutService.GetFooterConfiguration(CurrentPage);

            if (model.FooterConfiguration != null)
                model.FooterConfiguration.HomePageLogo = model.HeaderConfiguration?.Logo;

            return CurrentTemplate<BasePage>(model);

        }


    }
}
