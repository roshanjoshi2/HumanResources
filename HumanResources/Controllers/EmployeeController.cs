using Microsoft.AspNetCore.Mvc;

namespace HumanResources.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {

           HRDbContext db = new HRDbContext();
            var employees  = db.Employees.ToList();
            return View(employees);
        }
    }
}
