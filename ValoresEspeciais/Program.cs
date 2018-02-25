using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = byte.MaxValue;
            double d = double.MaxValue;
            float f = float.MaxValue;
            int i = int.MaxValue;
            uint ui = uint.MaxValue;
            short s = short.MaxValue;
            sbyte sb = sbyte.MaxValue;
            long l = long.MaxValue;
            ulong ul = ulong.MaxValue;
            Console.WriteLine($"Maximum Values:\nbyte:{b}\ndouble:{d}\nint:{i}uint:{ui}\nshort:{s}\nsbyte:{sb}\nlong:{l}\nulong:{ul}n\n");
            b = byte.MinValue;
            d = double.MinValue;
            f = float.MinValue;
            i = int.MinValue;
            ui = uint.MinValue;
            s = short.MinValue;
            sb = sbyte.MinValue;
            l = long.MinValue;
            ul = ulong.MinValue;
            Console.WriteLine($"Minimum Values:\nbyte:{b}\ndouble:{d}\nint:{i}uint:{ui}\nshort:{s}\nsbyte:{sb}\nlong:{l}\nulong:{ul}\n\n");
            Console.WriteLine($"Negative Infinity (Double): {d / 0}\nPositive Infinity (Double): {d / 0}\nNegative Infinity (Float): {f / 0}\nPositive Infinity (Float): {f / 0}\nInfinity/Infinity: {double.PositiveInfinity / double.PositiveInfinity}\n\n");
            Console.ReadKey();
        }
    }
}
