using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1___BasicOOP
{
    public class Subtraction
    {
        public float num1 { get; set; }
        public float num2 { get; set; }
        public float difference { get; private set; }
        public string subtract()
        {
            difference = num1 - num2;
            return $"{difference}";
        }
    }
}
