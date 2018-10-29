using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_ConvertLibrary
{
    public class General
    {
        public static void HasValues(int iValue)
        {
            Assert.AreEqual((iValue > 0), true);
        }
        public static void HasStringValue(string value)
        {
            Assert.AreEqual((value.Length > 0), true);
        }
    }
}
