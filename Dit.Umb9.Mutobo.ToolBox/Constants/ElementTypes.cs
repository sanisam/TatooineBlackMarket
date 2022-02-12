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

        public static class MailConfiguration
        {
            public const string Alias = "mailConfiguration";

            public static class Fields
            {
                public const string MailSubject = "mailSubject";
                public const string MailBody = "mailBody";
                public const string MailHeader = "mailHeader";
                public const string MailFooter = "mailFooter";
                public const string SenderMail = "senderMail";
                public const string ReceiverMail = "receiverMail";
            }
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


        #region modules

        public static class CallToActionButton
        {

            public const string Alias = "callToActionButton";

            public static class Fields
            {
                public const string Title = "title";
                public const string Text = "text";
                public const string Link = "link";
            }
        }


        public static class Flyer
        {
            public const string Alias = "flyer";

            public static class Fields
            {
                public const string Link = "link";
                public const string Color = "color";
                public const string Direction = "direction";
                public const string Width = "width";
                public const string Height = "height";
                public const string Rotation = "rotation";
                public const string Timer = "timer";
                public const string Position = "position";
                public const string FlyerTitle = "flyerTitle";
                public const string FlyerImage = "flyerImage";
                public const string FlyerTeaserText = "flyerTeaserText";
                public const string FlyerLink = "website";
                public const string MarginTop = "marginTop";
                public const string MarginSide = "marginSide";
                public const string TextHeight = "textHeight";
                public const string TextWidth = "textWidth";
            }
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
