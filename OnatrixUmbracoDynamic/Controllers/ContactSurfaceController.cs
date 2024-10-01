using Microsoft.AspNetCore.Mvc;
using OnatrixUmbracoDynamic.Models;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace OnatrixUmbracoDynamic.Controllers
{
	public class ContactSurfaceController : SurfaceController
	{
		public ContactSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
		{
		}

		public IActionResult HandleSubmit(ContactFormModel form)
		{
			if (!ModelState.IsValid)
			{
				ViewData["name"] = form.Name;
				ViewData["email"] = form.Email;
				ViewData["message"] = form.Message;
				ViewData["phone"] = form.Phone;

				ViewData["error_name"] = string.IsNullOrEmpty(form.Name);
				ViewData["error_email"] = string.IsNullOrEmpty(form.Email);
				ViewData["error_message"] = string.IsNullOrEmpty(form.Message);
				ViewData["error_phone"] = string.IsNullOrEmpty(form.Phone);
				TempData["failed"] = "failed to submit form";

				return CurrentUmbracoPage();
			}

			TempData["success"] = "form submitted successfully";
			return CurrentUmbracoPage();
		}
	}
}
