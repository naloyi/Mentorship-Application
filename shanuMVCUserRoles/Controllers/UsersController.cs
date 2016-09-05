using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Claims;
using System.Web.Security;
using Microsoft.AspNet.Identity;
using shanuMVCUserRoles.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace shanuMVCUserRoles.Controllers
{
	[Authorize]
	public class UsersController : Controller
    {
		// GET: Users
		public Boolean isAdminUser()
		{
			if (User.Identity.IsAuthenticated)
			{
				var user = User.Identity;
				ApplicationDbContext context = new ApplicationDbContext();
				var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
				var s = UserManager.GetRoles(user.GetUserId());
				if (s[0].ToString() == "Admin")
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			return false;
		} 
        public Boolean isMentorUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ApplicationDbContext context = new ApplicationDbContext();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                if (s[0].ToString() == "Mentor")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public Boolean isMenteeUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ApplicationDbContext context = new ApplicationDbContext();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                if (s[0].ToString() == "Mentee")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public ActionResult Index()
		{
			if (User.Identity.IsAuthenticated)
			{
				var user = User.Identity;
				ViewBag.Name = user.Name;
				//	ApplicationDbContext context = new ApplicationDbContext();
				//	var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

				//var s=	UserManager.GetRoles(user.GetUserId());
				//ViewBag.displayMenu = "No";

				if (isAdminUser())
				{
					ViewBag.displayMenu = "Yes1";
				}
                if (isMenteeUser())
                {
                    ViewBag.displayMenu = "Yes2";
                }
               if (isMentorUser())
                {
                    ViewBag.displayMenu = "Yes3";
                }
                return View();
			}
			else
			{
				ViewBag.Name = "Not Logged IN";
			}


			return View();


		}
	}
}