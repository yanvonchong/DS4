using Microsoft.AspNetCore.Mvc;

namespace LaboratorioMvc18.Controllers
{
    public class AccssController : Controller
    {
        
        //GET: access
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(string user, string password)
        {
            try
            {
                return Content("1");
            }
            catch(Exception ex)
            {
                return Content("Ocurrio un error: " + ex.Message);
            }
        }
    }
}
