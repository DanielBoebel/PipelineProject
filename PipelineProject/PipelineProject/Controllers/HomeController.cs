using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PipelineProject.Controllers
{
    public class HomeController : Controller
    {



        public int add(int a, int b)
        {
            int sum;
            sum = a + b;

            return sum;
        }

        public int subtract(int a, int b)
        {
            int sum;
            sum = a - b;

            return sum;
        }

        public int divide(int a, int b)
        {
            int sum;
            sum = a / b;

            return sum;
        }

        public int multiply(int a, int b)
        {
            int sum;
            sum = a * b;

            return sum;
        }

        public ActionResult Index()
        {


            return View();
        }



    }
}