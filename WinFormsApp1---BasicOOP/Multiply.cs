using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1___BasicOOP
{
    public class Multiply
    {
        public float num1 { get; set; }
        public float num2 { get; set; }
        public float product { get; private set; }
        public string multiply()
        {
            product = num1 * num2;
            return $"{product}";
        }
    }
}
