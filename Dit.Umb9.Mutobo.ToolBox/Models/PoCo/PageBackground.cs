﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Dit.Umb9.Mutobo.ToolBox.Models.PoCo
{
    public class PageBackground 
    {


        public Image BackgroundImage { get; set; }

        public double BackgroundOpacity { get; set; }

        public PageBackground()
        {
        }

        public int MyProperty { get; set; }
    }
}
