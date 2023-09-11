
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using Nop.Web.Framework.Mvc.ModelBinding;
using Microsoft.IdentityModel.Tokens;
using System.Threading.Tasks;
using Nop.Web.Framework.Models.Extensions;
using Nop.Plugin.Misc.GPTFriend;
using Nop.Web.Areas.Admin.Infrastructure.Mapper.Extensions;
using System.Text;
using Nop.Core;
using Microsoft.AspNetCore.Http;
using System.IO;
using Nop.Services.Messages;
using DocumentFormat.OpenXml.EMMA;

namespace Nop.Plugin.Misc.GPTFriend.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class GPTFriendController : BasePluginController
    {

        #region Fields
		private readonly INotificationService _notificationService;
		#endregion

		#region Ctor

		public GPTFriendController(INotificationService notificationService)
        {
            _notificationService = notificationService;
	    }

        #endregion


        #region Methods


        [AuthorizeAdmin]
        [Area(AreaNames.Admin)]
        public IActionResult Configure()
        {
            //ConfigurationModel model = new ConfigurationModel()
            //{
            //    SearchModel = new RedirectionSearchModel() { AvailablePageSizes = "10,20,30" }
            //};

            //foreach (RedirectionTypeEnum r in (RedirectionTypeEnum[])Enum.GetValues(typeof(RedirectionTypeEnum)))
            //{
            //    model.AvailableTypes.Add(new SelectListItem() { Text = r.ToString(), Selected = !model.AvailableTypes.Any(), Value = r.ToString() });
            //}

            //            return View("~/Plugins/Misc.GPTFriend/Views/Configure.cshtml", model); 
			return View("~/Plugins/Misc.GPTFriend/Views/Configure.cshtml", null);
		}


        //[AuthorizeAdmin]
        //[Area(AreaNames.Admin)]
        //[HttpPost, ActionName("Configure")]
        //[FormValueRequired("save")]
        //public IActionResult Configure(ConfigurationModel model)
        //{
        //    if (!ModelState.IsValid)
        //        return  Configure();

        //    return Configure();
        //}

        #endregion
    }
}