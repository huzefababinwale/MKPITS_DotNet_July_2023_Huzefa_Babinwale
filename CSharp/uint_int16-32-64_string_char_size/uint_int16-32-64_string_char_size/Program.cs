using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uint_int16_32_64_string_char_size
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*char ch;
            Console.WriteLine("Enter Character");
            ch= Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Character Entered: " + ch);
*/
            int intValue = 125;
            long longValue = intValue;
            Console.WriteLine("(long) {0} ={1}", intValue,longValue + "these no. can exceed upto -2^63 to 2^63-1");

            byte a;
            Console.WriteLine("Enter nmber bet 0 to 255 for byte  size=8 bits");
            a=Convert.ToByte(Console.ReadLine());
            Console.WriteLine(a);
            

            sbyte b;
            Console.WriteLine("Enter number for sbyte in range -128 to 127  size=8 bits");
            b=Convert.ToSByte(Console.ReadLine());
            Console.WriteLine(b);

            short c;
            Console.WriteLine("Enter number for Short in range -32768 to 32767  size=16 bits");
            c=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(c);

            ushort d;
            Console.WriteLine("Enter number for ushort in range 0 to 65535 size=16 bits");
            d=Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine(d);

            int e;
            Console.WriteLine("Enter number for Int in range -2^31 to 2^31-1 size=32 bits");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(e);

            uint f;
            Console.WriteLine("Enter number for UInt in range 0 to 2^32 size=32 bits");
            f=Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(f);

            ulong g;
            Console.WriteLine("Enter number for ulong in range 0 to 2^63 size=64 bits");
            g=Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine(g);

            long h;
            Console.WriteLine("Enter number for Long in range -2^63 to 2^63-1 size=64 bits");
            h=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(h);

            float i;
            Console.WriteLine("Enter number for float in range ±1.5 × 10^-45 to ±3.4 × 10^38 size=32 bits");
            i=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(i);

            double j;
            Console.WriteLine("Enter numeber for Double Float in range ±5.0 × 10^-324 to ±1.7 × 10^308 size=64 bits");
            j=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(j);

            decimal k;
            Console.WriteLine("Enter number for decimal in range ±1.0 × 10^-28 to ±7.9228 × 10^28 size=128 bits");
            k=Convert.ToDecimal(Console.ReadLine());
            Console.Write(k);

            bool l;
            Console.WriteLine("Enter True or False ");
            l=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(l);

            string m;
            Console.WriteLine("Enter String size=refrence type data ");
            m=Convert.ToString(Console.ReadLine());
            Console.WriteLine(m);

            Console.ReadKey();
        }
    }
}
