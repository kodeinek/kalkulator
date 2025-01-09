using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    public class Kalkulator
    {

        public int Value { get; set; } = 0;
        public string TextValue { get; set; } = "0";

        public enum KalkulatorType
        {
            dec,
            bin,
            oct,
            hex
        }

        public KalkulatorType ValueType { get; set; } = KalkulatorType.dec;  // Zmieniono na 'dec'
        public int sum(int a, int b)
        {
            return a + b;
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }

        public int dev(int a, int b)
        {
            return a/b;
        }


    }
}

