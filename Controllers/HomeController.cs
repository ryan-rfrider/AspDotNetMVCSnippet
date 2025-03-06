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

        public List<string> SelListBValue { get; set; }
        public List<SelectListItem> SelListA { get; set; }

        public List<SelectListItem> SelListB { get; set; }
    }

    public class CheckboxViewModel
    {
        public bool ChkA { get; set; }
        public bool ChkB { get; set; }
        public bool ChkC { get; set; }

        public List<SelectListItem> ChkListA { get; set; }

        public List<SelectListItem> ChkListB { get; set; }
    }

    public class RadioButtonViewModel
    {
        public string RadioA { get; set; }
        public string RadioB { get; set; }

        public string RadioValueA { get; set; }
        public List<SelectListItem> RadioListA { get; set; }
        public List<SelectListItem> RadioListB { get; set; }
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MyViewModel model = new MyViewModel();
            model.TxtA = "hello";
            model.TxtB = "world";
            model.SelA = "";

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
                    Value="G" ,
                    Selected=true
                } ,
            };

            model.SelListB = new List<SelectListItem>() {
                new SelectListItem() {
                    Text="Chose",
                    Value=""
                } ,
                new SelectListItem() {
                    Text="Apple",
                    Value="A"
                } ,
                new SelectListItem() {
                    Text="DELL",
                    Value="D",
                    Selected=true
                } ,
                new SelectListItem() {
                    Text="HP",
                    Value="H",
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

            vm.SelListB = new List<SelectListItem>() {
                new SelectListItem() {
                    Text="Chose",
                    Value=""
                } ,
                new SelectListItem() {
                    Text="Apple",
                    Value="A"
                } ,
                new SelectListItem() {
                    Text="DELL",
                    Value="D" 
                } ,
                new SelectListItem() {
                    Text="HP",
                    Value="H" 
                } ,
            };

            return View(vm);
        }

        public ActionResult About()
        {
            CheckboxViewModel vm = new CheckboxViewModel();

            vm.ChkA = true;
            vm.ChkC = true;

            vm.ChkListA = new List<SelectListItem> { new SelectListItem
            {
                Text="Apple",
                Value="A",
                Selected=true
            } ,new SelectListItem
            {
                Text="FaceBook",
                Value="F",
                Selected=false
            },new SelectListItem
            {
                Text="Google",
                Value="G",
                Selected=true
            }};

            vm.ChkListB = new List<SelectListItem> { new SelectListItem
            {
                Text="Apple",
                Value="A",
                Selected=true
            } ,new SelectListItem
            {
                Text="Dell",
                Value="D",
                Selected=false
            },new SelectListItem
            {
                Text="HP",
                Value="H",
                Selected=true
            }};

            return View(vm);
        }

        [HttpPost]
        public ActionResult About(CheckboxViewModel vm)
        {
 

            return View(vm);
        }

        public ActionResult Contact()
        {
            RadioButtonViewModel vm = new RadioButtonViewModel();

            vm.RadioA = "A";
            vm.RadioB = "D";
            vm.RadioListA = new List<SelectListItem>() { new SelectListItem()
            {
                Text="Apple",
                Value="A",
                Selected=false

            } ,new SelectListItem()
            {
                Text="Dell",
                Value="D",
                Selected=true
            },new SelectListItem()
            {
                Text="HP",
                Value="H",
                Selected=false
            }};

            return View(vm);
        }

        [HttpPost]
        public ActionResult Contact(RadioButtonViewModel vm)
        {
            vm.RadioListA = new List<SelectListItem>() { new SelectListItem()
            {
                Text="Apple",
                Value="A",
                //Selected=vm.RadioB=="A"

            } ,new SelectListItem()
            {
                Text="Dell",
                Value="D",
                //Selected=vm.RadioB=="D"
            },new SelectListItem()
            {
                Text="HP",
                Value="H",
                //Selected=vm.RadioB=="H"
            }};
            return View(vm);
        }
    }
}