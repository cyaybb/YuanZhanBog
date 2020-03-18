using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Helper;
using ViewModel.Register;

namespace UI.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(NewModel newModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View();
        }

        public ActionResult ValidationCode()
        {
            HPValidationCode hPValidationCode = new HPValidationCode();
           byte[] imgByte =hPValidationCode.GetImgByte();
            HttpContext.Session["ValidationCodeString"] = hPValidationCode.GetValidateCode();
            return File(imgByte, "image/png");
        }
    }
}