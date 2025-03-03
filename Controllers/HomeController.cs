using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace AspDotNetMVCSnippet.Controllers
{
    public class MyViewModel
    {
        public string TxtA { get; set; }
        public string TxtB { get; set; }

        public string SelA { get; set; }

        public string SelListAValue { get; set; }
        public List<SelectListItem> SelListA { get; set; }
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MyViewModel model = new MyViewModel();
            model.TxtA = "hello";
            model.TxtB = "world";
            model.SelA = "G";

            model.SelListA = new List<SelectListItem>() {
                new SelectListItem() {
                    Text="Chose",
                    Value=""
                } ,
                new SelectListItem() {
                    Text="Apple",
                    Value="A"
                } ,
                new SelectListItem() {
                    Text="Facebook",
                    Value="F"
                } ,
                new SelectListItem() {
                    Text="Google",
                    Value="G",
                    Selected=true
                } ,
            }; 


            return View(model);
        }

        [HttpPost]
        public ActionResult Index(MyViewModel vm)
        {

            vm.SelListA = new List<SelectListItem>() {
                new SelectListItem() {
                    Text="Chose",
                    Value=""
                } ,
                new SelectListItem() {
                    Text="Apple",
                    Value="A"
                } ,
                new SelectListItem() {
                    Text="Facebook",
                    Value="F"
                } ,
                new SelectListItem() {
                    Text="Google",
                    Value="G", 
                } ,
            };

            return View(vm);
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
    }
}