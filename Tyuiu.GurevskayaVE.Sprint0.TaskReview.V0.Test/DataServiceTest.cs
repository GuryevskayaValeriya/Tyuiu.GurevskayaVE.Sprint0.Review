using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.GurevskayaVE.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            Assert.AreEqual(15, DataService.Calc(1, 1, 1)); 
        }
    }
    
}
