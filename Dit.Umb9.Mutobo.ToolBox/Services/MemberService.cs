using Dit.Umb9.Mutobo.ToolBox.Interfaces;
using Dit.Umb9.Mutobo.ToolBox.Models.PoCo;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Web;

namespace Dit.Umb9.Mutobo.ToolBox.Services
{
    public class MemberService : BaseService, IMemberService
    {
        protected MemberService(ILogger<MemberService> logger, IUmbracoContextAccessor contextAccessor) : base(logger, contextAccessor)
        {
        }

        public void RegisterMember(Member member)
        {
            throw new NotImplementedException();
        }
    }
}
