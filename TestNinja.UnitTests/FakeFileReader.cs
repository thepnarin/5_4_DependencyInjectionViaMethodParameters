using System;
using _5_4_DependencyInjectionViaMethodParameters.Mocking;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNinja.UnitTests
{
    public class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}
