using Company.Repository.Interface.NewFolder;
using Microsoft.AspNetCore.Mvc;

namespace Company.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDpartmentRepositotiry _dpartmentRepositotiry;

        public DepartmentController(IDpartmentRepositotiry dpartmentRepositotiry) {
            _dpartmentRepositotiry = dpartmentRepositotiry;
        }
        public IActionResult Index()
        {
            var department= _dpartmentRepositotiry.GetAll();
            return View(department);
        }
    }
}
