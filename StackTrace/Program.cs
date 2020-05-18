using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTrace
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CallDumbDumbAndRethrow();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.ReadKey();
            }
        }

        public static void CallDumbDumbAndRethrow()
        {
            try
            {
                DumbDumb();
            }
            catch (Exception ex)
            {
                // throws whole stracktrace
                throw;
                // throws new stacktrace which does not include the Errors origin
                // throw ex;
            }
        }

        public static void DumbDumb()
        {
            // be dumb
            int x = 0;
            int r = 0 / x;
        }
    
    }
}
