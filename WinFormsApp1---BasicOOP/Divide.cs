using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1___BasicOOP
{
    public class Divide
    {
        public float num1 { get; set; }
        public float num2 { get; set; }
        public float quotient { get; private set; }
        public string divide()
        {
            if (num2 == 0)
            {
                return "Error: Division by zero is not allowed.";
            }
            quotient = num1 / num2;
            return $"{quotient}";
        }
    }
}
