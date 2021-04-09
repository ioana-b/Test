using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    public class TestClass
    {
        private string Parameter;

        public TestClass(string value)
        {
            Parameter = value;
        }

        public void DoSomething()
        {
            Console.WriteLine($"I'm doing something with this value: {Parameter}");   
        }
    }
}
