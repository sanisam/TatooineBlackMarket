using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dit.Umb9.Mutobo.ToolBox.Constants
{
    public static class ElementTypes
    {

        public static class FooterContact
        {
            public const string Headline = "headline";
            public const string AddressBlock = "addressBlock";
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
