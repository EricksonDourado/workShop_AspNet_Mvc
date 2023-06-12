using Microsoft.AspNetCore.Mvc;
using SallesWebMvc.Models;

namespace SallesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department(1, "Almoxarifado"));
            departments.Add(new Department(2, "RH"));
            departments.Add(new Department(3, "Compras"));


            return View(departments);
        }
    }
}
