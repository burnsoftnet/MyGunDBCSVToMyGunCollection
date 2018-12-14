using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BurnSoft.mgc.convert;

namespace UnitTest_ConvertLibrary
{
    [TestClass]
    public class UnitTest_MyGunDB
    {
        public string errOut;
        /// <summary>
        /// Defines the test method TestMethod_ListMyGunDBData.
        /// </summary>
        [TestMethod]
        public void TestMethod_ListMyGunDBData()
        {
            int totalCount = MyGunDB.ListMyGunDBData(Settings.ImportPath, out errOut).Count;
            General.HasValues(totalCount);
        }
    }
}
