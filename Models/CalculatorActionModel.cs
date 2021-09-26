using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MCVCalculator.Models
{
    public class CalculatorActionModel
    {
        public double firstNumber { get; set; }
        public double secondNumber { get; set; }
        public string result { get; set; }
        public string action { get; set; }
    }
}
