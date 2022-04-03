using System;

namespace ProjectTask_3
{
    class Test1
    {
        static void Main(string[] args)
        {
            var path = "packtest.cs";

            var exception = new ArgumentException("*Exception*");

            LocalFileLoggerTest.TestLogging<MyClass>(path, "*Message*", exception);
            LocalFileLoggerTest.TestLogging<MyInterface>(path, "*Message*", exception);
            LocalFileLoggerTest.TestLogging<MyEnum>(path, "*Mesagge*", exception);
        }
    }
}
