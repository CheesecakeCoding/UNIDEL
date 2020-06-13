using System;
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
        private List<Vehicle> veh = new List<Vehicle>(){
                new Vehicle() { VehicleID = 0, VehicleMake = "A", VehicleModel = "Z", VehicleVIN = "I", VehicleMileage = 20, VehicleLicensePlate = "E", VehicleLicenseDiskExpiry = new DateTime(2033, 12, 25, 10, 30, 50), VehicleLastService = new DateTime(2019, 10, 25, 10, 30, 50), VehicleNextMileageService = 30, VehicleNextDateService = new DateTime(2020, 10, 25, 10, 30, 50) },
                new Vehicle() { VehicleID = 1, VehicleMake = "B", VehicleModel = "Y", VehicleVIN = "F", VehicleMileage = 12, VehicleLicensePlate = "E", VehicleLicenseDiskExpiry =new DateTime(2023, 12, 25, 10, 30, 50), VehicleLastService = new DateTime(2019, 10, 25, 10, 35, 50), VehicleNextMileageService = 30, VehicleNextDateService = new DateTime(2020, 10, 25, 10, 30, 50) },
                new Vehicle() { VehicleID = 2, VehicleMake = "C", VehicleModel = "X", VehicleVIN = "J", VehicleMileage = 23, VehicleLicensePlate = "E", VehicleLicenseDiskExpiry = new DateTime(2035, 12, 25, 10, 30, 50), VehicleLastService = new DateTime(2019, 10, 25, 10, 40, 50), VehicleNextMileageService = 30, VehicleNextDateService = new DateTime(2020, 10, 25, 10, 30, 50) },
                new Vehicle() { VehicleID = 3, VehicleMake = "D", VehicleModel = "W", VehicleVIN = "G", VehicleMileage = 10, VehicleLicensePlate = "E", VehicleLicenseDiskExpiry = new DateTime(2025, 12, 25, 10, 30, 50), VehicleLastService = new DateTime(2019, 10, 25, 10, 50, 50), VehicleNextMileageService = 30, VehicleNextDateService = new DateTime(2020, 10, 25, 10, 30, 50) },
                new Vehicle() { VehicleID = 4, VehicleMake = "E", VehicleModel = "V", VehicleVIN = "H", VehicleMileage = 26, VehicleLicensePlate = "E", VehicleLicenseDiskExpiry = new DateTime(2030, 12, 25, 10, 30, 50), VehicleLastService = new DateTime(2019, 10, 25, 11, 30, 50), VehicleNextMileageService = 30, VehicleNextDateService = new DateTime(2020, 10, 25, 10, 30, 50) }
        };

        // GET: /<controller>/
        public IActionResult Index(String sortV,String search)
        {
            List<Vehicle> v = new List<Vehicle>();
            //veh[0].VehicleMake=search;
            if (search==null)
                v = new List<Vehicle>(veh);
            else
            {
                foreach(var ve in veh)
                {
                    if (ve.VehicleVIN.Contains(search))
                        v.Add(ve);
                }
            }
            if (sortV=="vID")
                v = v.OrderBy(order => order.VehicleID).ToList();
            else if (sortV == "vMake")
                v = v.OrderBy(order => order.VehicleMake).ToList();
            else if (sortV == "vModel")
                v = v.OrderBy(order => order.VehicleModel).ToList();
            else if (sortV == "vVIN")
                v = v.OrderBy(order => order.VehicleVIN).ToList();
            else if (sortV == "vMileage")
                v = v.OrderBy(order => order.VehicleMileage).ToList();
            else if (sortV == "vLicensePlate")
                v = v.OrderBy(order => order.VehicleLicensePlate).ToList();
            else if (sortV == "vLicenseDiskExpiry")
                v = v.OrderBy(order => order.VehicleMileage).ToList();
            else if (sortV == "vLastService")
                v = v.OrderBy(order => order.VehicleLicenseDiskExpiry).ToList();
            else if (sortV == "vNextMileageService")
                v = v.OrderBy(order => order.VehicleNextMileageService).ToList();
            else if (sortV == "vNextDateService")
                v = v.OrderBy(order => order.VehicleNextDateService).ToList();
            return View(v);
        }

        public IActionResult AddVehicle()
        {
            return View();
        }

        public IActionResult Add(String vMake, String vModel,String vVIN, int vMileage, String vLicensePlate, DateTime vLicenseDiskExpiry, DateTime vLastService, int vNextMileageService, DateTime vNextDateService)
        {
            List<Vehicle> v = new List<Vehicle>();
            veh.Add(new Vehicle() { VehicleID = veh.Count(), VehicleMake = vMake, VehicleModel = vModel, VehicleVIN = vVIN, VehicleMileage = vMileage, VehicleLicensePlate = vLicensePlate, VehicleLicenseDiskExpiry = vLicenseDiskExpiry, VehicleLastService = vLastService, VehicleNextMileageService = vNextMileageService, VehicleNextDateService = vNextDateService });
            //Index(null,null);
            return View(veh);
        }

        public IActionResult CaptureService()
        {
            return View(veh);
        }

        public IActionResult Capture()
        {
            return View(veh);
        }

        public IActionResult RenewLicenseDisk()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult delete()
        {
            return View();
        }

    }
}
