using MCVCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MCVCalculator.Controllers
{
    
    public class CalculatorController : Controller
    {
        private object Res { get; set; }



        public JsonResult Calculat(CalculatorActionModel model)
        {
            //CalculatorActionModel model = new CalculatorActionModel();

            double a = Convert.ToDouble(model.firstNumber);
            double b = Convert.ToDouble(model.secondNumber);
            double c = 0;
            string action = model.action;
            if (a > 0 && b > 0)
            {
                switch (action)
                {
                    case "addition":
                        c = a + b;
                        break;
                    case "substruction":
                        c = a - b;
                        break;
                    case "multiplication":
                        c = a * b;
                        break;
                    case "division":
                        c = a / b;
                        break;
                }

                model.result = c.ToString();
                return Json(model);
            }
            
            else {

                return Json(false);
            }
           

            
        }
    }
}
