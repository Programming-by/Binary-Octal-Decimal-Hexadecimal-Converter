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
    }
}
