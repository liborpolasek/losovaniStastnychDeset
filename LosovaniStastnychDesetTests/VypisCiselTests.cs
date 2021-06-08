using Microsoft.VisualStudio.TestTools.UnitTesting;
using losovaniStastnychDeset;
using System;
using System.Collections.Generic;
using System.Text;

namespace losovaniStastnychDeset.Tests
{
    [TestClass()]
    public class VypisCiselTests
    {
        [TestMethod()]
        public void GetStringBuilderTestReturnsStringBuilder()
        {
            VypisCisel vc = new VypisCisel();
            var stringBuilder = vc.GetStringBuilder();

            Assert.IsInstanceOfType(stringBuilder, typeof(StringBuilder));
        }
    }
}