using Dit.Umb9.Mutobo.ToolBox.Constants;
using Dit.Umb9.Mutobo.ToolBox.Interfaces;
using Dit.Umb9.Mutobo.ToolBox.Models.Pages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Extensions;

namespace Dit.Umb9.Mutobo.ToolBox.Services
{
    /// <summary>
    /// implementation of the IMutoboContentService service interface
    /// </summary>
    public class MutoboContentService : BaseService, IMutoboContentService
    {
        protected readonly IImageService ImageService;
        protected readonly ISliderService SliderService;
        protected readonly IConfigService ConfigurationService;
        private readonly ICardService _cardService;
        protected readonly IThemeService ThemeService;
        private readonly IUmbracoContextFactory _umbracoContextFactory;

        /// <summary>
        /// constructor for a MUTOBO content service.
        /// PYrovides some methods to get Umbraco nodes as MUTOBO Pages or modules
        /// </summary>
        /// <param name="logger">the logging service</param>
        /// <param name="imageService">the image service</param>
        /// <param name="sliderService">the slider service</param>
        /// <param name="cardService">the card service</param>
        /// <param name="contextAccessor">the umbraco context accessor to get content from umbraco</param>
        /// <param name="contextFactory">factors to create the umbraco context</param>
        /// <param name="themeService">the theme service</param>
        public MutoboContentService(
            ILogger<MutoboContentService> logger,
            IImageService imageService,
            ISliderService sliderService,
            ICardService cardService,
            IUmbracoContextAccessor contextAccessor,
            IUmbracoContextFactory contextFactory,
            IThemeService themeService)
                : base(logger, contextAccessor)
        {
            SliderService = sliderService;
            _cardService = cardService;
            ImageService = imageService;
            ThemeService = themeService;
            _umbracoContextFactory = contextFactory;
        }


        /// <summary>
        /// returns a list with all MUTOBO modules placed in a module field of the page
        /// </summary>
        /// <param name="content">
        /// </param>
        /// <param name="fieldName"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<IModule> GetContent(IPublishedContent content, string fieldName, string culture = null)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// method to get the   
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public BasePage GetPageModel(IPublishedContent content)
        {
            BasePage result = null;

            switch (content.ContentType.Alias)
            {
                case DocumentTypes.BasePage.Alias:
                default:
                    result = new BasePage(content)
                    {
                    };
                    break;

                case DocumentTypes.ArticlePage.Alias:
                    result = new ArticlePage(content)
                    {
                        EmotionImages = content.HasValue(DocumentTypes.ArticlePage.Fields.EmotionImages) ?
                        ImageService.GetImages(content.Value<IEnumerable<IPublishedContent>>(DocumentTypes.ArticlePage.Fields.EmotionImages),
                        width: 800,
                        height: 450) : null,
                    };
                    break;

                case DocumentTypes.HomePage.Alias:
                    result = new HomePage(content)
                    {
                        Modules = content.HasValue(DocumentTypes.HomePage.Fields.Modules) ? GetContent(content, DocumentTypes.HomePage.Fields.Modules) : null
                    };
                    break;

            }

            return result;
        }
    }
}
