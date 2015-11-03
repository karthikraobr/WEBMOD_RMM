using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee.Models;

namespace Employee.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Employee()
        {
            return View();
        }

        public ActionResult Department()
        {
            return View();
        }

        public ActionResult EmployeeDetails(string employeeName)
        {
            EmployeeModel employee = null;
            if (employeeName == "Tom")
            {
                 employee = new EmployeeModel
                {
                    Name = "Tom",
                    Department = "Dev",
                    Manager = "Dick",
                    RoomNumber = "1"

                };
            }
            else if (employeeName == "Dick")
            {
                 employee = new EmployeeModel
                {
                    Name = "Dick",
                    Department = "DevOps",
                    Manager = "Dick",
                    RoomNumber = "1"

                };
            }
            else
            {
                 employee = new EmployeeModel
                {
                    Name = "Harry",
                    Department = "QA",
                    Manager = "Dick",
                    RoomNumber = "1"

                };
            }
            return View(employee);
        }

        public ActionResult DepartmentDetails(string departmentName)
        {
            DepartmentModel department = null;
            if (departmentName == "Dev")
            {
                department = new DepartmentModel
                {
                    Name = "Dev",
                    Members = new List<string>
                {
                    "Tom"
                }
                };
            }
            else if (departmentName == "QA")
            {
                department = new DepartmentModel
                {
                    Name = "QA",
                    Members = new List<string>
                {
                    "Harry"
                }
                };
            }
            else
            {
                department = new DepartmentModel
                {
                    Name = "DevOps",
                    Members = new List<string>
                {
                    "Dick"
                }
                };
            }
            return View(department);
        }
    }
}