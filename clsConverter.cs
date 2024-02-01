using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Octal_Decimal_Hexadecimal_Converter
{
    public static class clsConverter
    {
        public static long ConvertFromOctalToDecimal(string Octal)
        {
            long Decimal = 0;
            short Length = (short) (Octal.Length - 1);
            for (short i = Length; i >= 0; i--)
            {
                Decimal += byte.Parse(Octal[i].ToString()) * (long)Math.Pow(8, (Length - i)); 
            }
            return Decimal;
        }
   
        public static string ConvertFromDecimalToOctal(long Decimal)
        {
            if (Decimal == 0)
                return "0";

            StringBuilder sbOctal = new StringBuilder();
            byte Remainder = 0;
            while (Decimal > 0)
            {
                Remainder = (byte) (Decimal % 8);
                Decimal /= 8;

                sbOctal.Insert(0,Remainder);
            }
            return sbOctal.ToString();
        }
    }
}
