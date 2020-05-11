using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EConfiableWEB.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EConfiableWEB.Controllers
{
    [Authorize]

    public class RoleController : Controller
    {
        ApplicationDbContext context;
        public RoleController()
        {
            context = new ApplicationDbContext();
        }



        /// <summary>
                /// Get All Roles
                /// </summary>
                /// <returns></returns>
        [Authorize]
        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }

        /// <summary>
                /// Create  a New role
                /// </summary>
                /// <returns></returns>
        [Authorize]
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }

        /// <summary>
                /// Create a New Role
                /// </summary>
                /// <param name="Role"></param>
                /// <returns></returns>
        [Authorize]
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        //GET
        [Authorize]
        public ActionResult Delete(string id)
        {
            var role = context.Roles.Where(d => d.Name == id).FirstOrDefault();
            context.Roles.Remove(role);
            context.SaveChanges();
            var Roles = context.Roles.ToList();
            return View("Index", Roles);
        }

    }
}