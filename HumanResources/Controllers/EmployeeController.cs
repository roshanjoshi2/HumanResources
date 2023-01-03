using HumanResources.Models;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.Controllers
{
    public class EmployeeController : Controller
    {
        HRDbContext db = new HRDbContext();
        public IActionResult Index()
        {

           
            var employees  = db.Employees.ToList();
            return View(employees);
        }

        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add( Employee employee)
        {
            var employees = db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int ID)
        {
            var employee = db.Employees.Find(ID);
            return View(employee);
        }


        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
           db.Employees.Update(employee);
           db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int ID)
        {
            var employee = db.Employees.Find(ID);
            return View(employee);
        }


        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            var employees = db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}
