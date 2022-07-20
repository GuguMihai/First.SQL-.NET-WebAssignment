using FirstRequirement;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{
    public class TestConsoleWrapperForEmpty : IConsole
    {
        public int Counter = 0;

        public void Write(string message)
        {
        }

        public void WriteLine(string message)
        {
        }

        public string ReadLine()
        {
            Counter++;
            return Counter > 1 ? "dummyTest" : "";
        }
    }

    public class TestConsoleWrapperForDigits : IConsole
    {
        public int Counter = 0;

        public void Write(string message)
        {
        }

        public void WriteLine(string message)
        {
        }

        public string ReadLine()
        {
            Counter++;
            return Counter > 1 ? "dummyTest" : "Mark1";
        }
    }

    public class TestConsoleWrapperForSpecialChars : IConsole
    {
        public int Counter = 0;

        public void Write(string message)
        {
        }

        public void WriteLine(string message)
        {
        }

        public string ReadLine()
        {
            Counter++;
            return Counter > 1 ? "dummyTest" : "Mark$#%$#";
        }
    }

    public class TestConsoleWrapperForCorrectName : IConsole
    {
        public void Write(string message)
        {
        }

        public void WriteLine(string message)
        {
        }

        public string ReadLine()
        {
            return "dummyTest";
        }
    }
}
