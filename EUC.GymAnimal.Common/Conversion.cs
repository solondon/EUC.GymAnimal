using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.Common
{
    public enum WeightType
    {
        Kilograms = 1,
        lbs
    }

    public class Conversion
    {
        public static void ConvertToPounds(double weight, WeightType type)
        {
            switch (type)
            {
                case WeightType.Kilograms:
                    {
                        double pounds = weight * 2.20462d;
                        double ounces = pounds - Math.Floor(pounds);
                        pounds -= ounces;
                        ounces *= 16;
                        Console.WriteLine("{0} lbs and {1} oz.", pounds, ounces);
                        break;
                    }
                default:
                    throw new Exception("Weight type not supported");
            }
        }


    }
}
