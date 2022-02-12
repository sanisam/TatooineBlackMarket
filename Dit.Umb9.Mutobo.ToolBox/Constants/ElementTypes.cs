using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dit.Umb9.Mutobo.ToolBox.Constants
{
    public static class ElementTypes
    {
        #region configuration

        public static class FooterConfiguration
        {
            public const string Alias = "footerConfiguration";

            public static class Fields
            {
                public const string NavigationArea = "navigationArea";
                public const string ContactArea = "contactArea";
                public const string Links = "footerLinks";
                public const string BlockLinks = "blockLinks";
                public const string PictureLinks = "pictureLinks";
                public const string CopyRight = "copyRight";
            }
        }


        public static class HeaderConfiguration {

            public const string Logo = "logo";
            public const string Link = "logoUrl";
        }

        #endregion

        #region footer
        public static class FooterContact
        {
            public const string Headline = "headline";
            public const string AddressBlock = "addressBlock";
        }

        public static class FooterNavBlock
        {
            public const string StartNode = "startNode";
        }
        #endregion


        public static class SearchResults
        {
            public static string Alias = "searchResults";

            public static class Fields
            {
                // BasePage
                public const string PageTitle = "pageTitle";
            }
        }


        public static class PictureLink
        {
            public const string Alias = "pictureLink";

            public static class Fields
            {
                public const string Image = "image";
                public const string Link = "link";
                public const string LogoLink = "logoLink";
                public const string Text = "text";
                public const string MaxHeight = "maxHeight";
                public const string PaddingTop = "paddingTop";
                public const string PaddingRight = "paddingRight";
                public const string PaddingBottom = "paddingBottom";
                public const string PaddingLeft = "paddingLeft";
            }
        }
    }
}
