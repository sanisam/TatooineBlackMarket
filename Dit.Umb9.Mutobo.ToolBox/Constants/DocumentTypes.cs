﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dit.Umb9.Mutobo.ToolBox.Constants
{
    public static class DocumentTypes
    {

        #region Pages

        /// <summary>
        /// constants for the basePage document type
        /// </summary>
        public static class BasePage
        {
            public static string Alias = "basePage";

            public static class Fields
            {
                // BasePage
                public const string PageTitle = "pageTitle";
                public const string HideFromNavigation = "hideFromNavigation";
                public const string NotClickable = "notClickable";
                public const string RedirectLink = "redirectLink";
                public const string OpenInNewWindow = "newWindow";
                // SEO Data
                public const string MetaTitle = "metaTitle";
                public const string MetaDescription = "metaDescription";
                public const string MetaKeywords = "metaKeywords";
                public const string ExcludeFromXMLSitemap = "excludeFromXMLSitemap";
                public const string SearchEngineFrequency = "searchEngineFrequency";
                public const string SearchEngineRelativePriority = "searchEngineRelativePriority";
                public const string Theme = "theme";
                public const string HeaderConfiguration = "headerConfiguration";
                public const string FooterConfiguration = "footerConfiguration";
                public const string GoogleAnalyticsKey = "googleAnalyticsKey";
                public const string Thumbnail = "thumbnail";
                public const string ExcludeFromSearch = "excludeFromSearch";

            }
        }

        /// <summary>
        /// constants for the homePage document type
        /// </summary>
        public static class HomePage
        {
            public static string Alias = "homePage";

            public static class Fields
            {
                public static string Disturber = "disturber";
                public static string SloganTitle = "sloganTitle";
                public static string SloganSubTitle = "sloganSubTitle";
                public static string Modules = "modules";
            }
        }
        #endregion


    }
}