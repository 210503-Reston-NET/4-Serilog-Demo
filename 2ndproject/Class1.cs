using System;
using Serilog;
namespace _2ndproject
{
    public class Class1
    {
        public void test1(){

            
            var mylog = Log.ForContext<Class1>();
            
            Log.Warning("No Context here");
            Console.WriteLine("Until....");
            mylog.Information("now I have context");

            mylog.Information("this is how you pass in variables");
            string one = "git out of my swamp";
            mylog.Warning("my var is: {shrek_said}",one);
        }
        public void test2(){
            var mylog = Log.ForContext<Class1>();
            Console.WriteLine();
            mylog.Verbose("verbose log");
            mylog.Debug("Debug log");
            mylog.Information("info log");
            mylog.Warning("Warning");
            mylog.Error("Error log");
            mylog.Fatal("Fatal - very bad");
            Console.WriteLine();
        }
    }
}
