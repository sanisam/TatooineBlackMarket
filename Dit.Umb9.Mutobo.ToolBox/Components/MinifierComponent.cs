using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.WebAssets;

namespace Dit.Umb9.Mutobo.ToolBox.Components
{
    public class MinifierComponent : IComponent
    {
        private readonly IRuntimeMinifier _runtimeMinifier;

        public MinifierComponent(IRuntimeMinifier runtimeMinifier) => _runtimeMinifier = runtimeMinifier;
        public void Initialize()
        {


            _runtimeMinifier.CreateCssBundle("inline-css-bundle",
                BundlingOptions.NotOptimizedAndComposite,
                new[] { "~/web-components-cms-template-base/src/css/variables.css", "~/web-components-cms-template-base/src/css/misc.css", "~/web-components-cms-template-base/src/css/fonts.css" });

        }

        public void Terminate()
        {

        }
    }
}
