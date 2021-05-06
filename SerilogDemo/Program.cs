using System.Globalization;
using System;
using Serilog;
using System.IO;
using _2ndproject;
using System.Reflection;
namespace SerilogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console(outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Properties:j} {Message:lj}{NewLine}{Exception}")
                .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            /// <summary>
            /// One way to add Context
            /// </summary>
            var myLog = Log.ForContext<Program>();
            myLog.Information("Here is a log with context");

            Log.Information("Hello, world! No context");

            Class1 testclass = new Class1();
            testclass.test();

            //with Exceptions
            int a = 10, b = 0;
            try
            {
                Log.Debug("Dividing {A} by {B}", a, b);
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Something went wrong");
            }
            finally
            {
                Log.CloseAndFlush();
            }

        }
    }
}
