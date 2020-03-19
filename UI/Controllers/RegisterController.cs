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
            //服务器端的验证用户名重复还是伪代码没有写完
            //把用户的信息存储到数据库中=》调用service层 的RegisterServie的save方法

            return View();
        }

        //获取验证码
        public ActionResult FrontEndValidationCode()
        {
            HPValidationCode hPValidationCode = new HPValidationCode();
           byte[] imgByte =hPValidationCode.GetImgByte();
            HttpContext.Session["ValidationCodeString"] = hPValidationCode.verificationCode;
            return File(imgByte, "image/png");
        }
        //前台Ajax验证 验证码
        public ActionResult AfterEndValidationCode(string VerificationCode)
        {
            string code=HttpContext.Session["ValidationCodeString"].ToString().ToLower();
            return Json(VerificationCode.ToLower() == code,JsonRequestBehavior.AllowGet);
        }
        //前台Ajax验证 用户名重复------------
        public ActionResult CheckNameRepeat(string UserName)
        {
            return Json(UserName!="陈百万" , JsonRequestBehavior.AllowGet);
        }
    }
}