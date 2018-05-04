using EmployeeLeavePortal.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace EmployeeLeavePortal.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Employee
        public ActionResult Index()
        {
                        
            return View();
            
        }
        public ActionResult ViewProfile( string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser applicationUser = db.Users.Find(id);
            if (applicationUser == null)
            {
                return HttpNotFound();
            }
            return View(applicationUser);
        }
        public ActionResult ApplyLeave(string id)
        {
            //var employeeList = db.Users.FirstOrDefault(from u in db.Users where id.Contains(u.Id) select );

            return View();
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ApplyLeave(LeaveRequest model)
        {
            
            var request = new LeaveRequest { EmployeeId = model.EmployeeId, };
            if (ModelState.IsValid)
            {
                db.leaveRequests.Add(request);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

    }
}