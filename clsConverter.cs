using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Octal_Decimal_Hexadecimal_Converter
{
    public static class clsConverter
    {
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
  
        public static string ConvertFromDecimalToHexadecimal(long Decimal)
        {
            if (Decimal == 0)
                return "0";

            byte Remainder = 0;
            StringBuilder sbHexa = new StringBuilder();

            Dictionary<byte, char> keyValueHexa = new Dictionary<byte, char>()
                  {
                      { 0  , '0'  },
                      { 1  , '1'  },
                      { 2  , '2'  },
                      { 3  , '3'  },
                      { 4  , '4'  },
                      { 5  , '5'  },
                      { 6  , '6'  },
                      { 7  , '7'  },
                      { 8  , '8'  },
                      { 9  , '9'  },
                      { 10 , 'A' },
                      { 11 , 'B' },
                      { 12 , 'C' },
                      { 13 , 'D' },
                      { 14 , 'E' },
                      { 15 , 'F' }
                  };


            while (Decimal > 0)
            {
                Remainder = (byte) (Decimal % 16);

                Decimal /= 16;

                sbHexa.Insert(0, keyValueHexa[Remainder]);
            } 
            return sbHexa.ToString();
        }
    
        public static long ConvertFromHexadecimalToDecimal(string Hexadecimal)
        {
            long Decimal = 0;
            short Length = (byte) (Hexadecimal.Length - 1);

            Dictionary<char, byte> keyValueHexa = new Dictionary<char, byte>()
                  {
                     { '0' , 0  },
                     { '1' , 1  },
                     { '2' , 2  },
                     { '3' , 3  },
                     { '4' , 4  },
                     { '5' , 5  },
                     { '6' , 6  },
                     { '7' , 7  },
                     { '8' , 8  },
                     { '9' , 9  },
                     { 'A' , 10 },
                     { 'B' , 11 },
                     { 'C' , 12 },
                     { 'D' , 13 },
                     { 'E' , 14 },
                     { 'F' , 15 }
                  };

            for (int i = Length; i >=0; i--)
            {
                Decimal += keyValueHexa[char.ToUpper((char) Hexadecimal[i])] * (long) Math.Pow(16, Length - i);
            }
            return Decimal;
        }
    
        public static string ConvertFromOctalToHexadecimal(string Octal)
        {
          long Decimal  = ConvertFromOctalToDecimal(Octal);

            return ConvertFromDecimalToHexadecimal(Decimal);
        }
    }
}
