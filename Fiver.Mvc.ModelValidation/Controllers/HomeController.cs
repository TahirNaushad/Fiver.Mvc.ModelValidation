using Microsoft.AspNetCore.Mvc;
using Fiver.Mvc.ModelValidation.Models.Home;

namespace Fiver.Mvc.ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello Model Validation");
        }

        [HttpPost]
        public IActionResult Save(EmployeeInputModel model)
        {
            if (ModelState.IsValid)
                return Ok(model);
            
            return BadRequest(ModelState);
        }
    }
}
