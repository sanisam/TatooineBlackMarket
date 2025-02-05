﻿using Dit.Umb9.Mutobo.ToolBox.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Dit.Umb9.Mutobo.ToolBox.Interfaces
{
    public interface IXmlSitemapService
    {
        IEnumerable<BasePage> GetXmlSitemap(IPublishedContent model);
    }
}
