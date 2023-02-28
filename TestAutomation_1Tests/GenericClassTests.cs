namespace GenericNameSpace.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using GenericNameSpace;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Moq;
    using FluentAssertions;

    [TestClass()]
    public class GenericClassTests
    {
        [TestMethod()]
        public void TestsFluentAssertions_MOQ_SystemPaths()
        {
            GenericClass genericClass = new GenericClass();

            Mock<IJustAClass> fakeAgent = new Mock<IJustAClass>();
            fakeAgent.SetupGet(p => p.Version).Returns("1.2.3.4");

            var result = genericClass.MakeAgentVersionFolder(fakeAgent.Object, "C:\\Skyline DataMiner\\Protocols");

            result.Should().Be("C:\\Skyline DataMiner\\1.2.3.4");
        }
    }
}