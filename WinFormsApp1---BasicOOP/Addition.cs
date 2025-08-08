using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1___BasicOOP
{
    public class Addition
    {
        public float num1 { get; set; }
        public float num2 { get; set; }
        public float sum { get; private set; }

        public string add()
        {
            sum = num1 + num2;
            return $"{sum}";
        }
    }
}
