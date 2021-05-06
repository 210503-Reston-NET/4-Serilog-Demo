using System;
using Serilog;
namespace _2ndproject
{
    public class Class1
    {
        public void test(){

            
             var mylog = Log.ForContext<Class1>();
            
            Log.Warning("No Context here");
            Console.WriteLine("Until....");
            mylog.Information("now I have context");
        }
    }
}
