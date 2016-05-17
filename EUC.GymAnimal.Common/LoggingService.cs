using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC.Common
{
    public class LoggingService
    {
        public static void WriteToFile(List<ILoggable> logItems)
        {
            foreach (var item in logItems)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
