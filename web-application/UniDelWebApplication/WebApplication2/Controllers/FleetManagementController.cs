﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UniDelWebApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniDelWebApplication.Controllers
{
    public class FleetManagementController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //page containing list of vehicles, search bar, drop down list
            //to select a sorting criteria, a sort button
            return View();
        }

        
        public IActionResult CaptureService()
        {
            //page containing form inputs to change when the vehicles next service is due
            //when the action is complete it should update the vehicles last service date to today
            return View();
        }

        public IActionResult RenewLicenseDisk()
        {
            //page to select a new expiry date for the license disk, usually a year later
            return View();
        }

        public IActionResult Edit()
        {
            //page to edit any other vehicle details
            return View();
        }

        public IActionResult Delete()
        {
            //code to remove vehicle from system



            //redirect back to index page after deleting vehicle
            return new RedirectToPageResult("Index");
        }
    }
}
