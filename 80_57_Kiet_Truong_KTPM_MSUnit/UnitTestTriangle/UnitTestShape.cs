using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _80_57_Kiet_Truong_KTPM_MSUnit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestTriangle
{
  //  [TestClass]
    public class UnitTestShape
    {//80_VanKiet
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Testcase_TamGiacVuong_80_Kiet()
        {
            string expected, actual;
            ShapeCalculator c = new ShapeCalculator(3, 4, 5);
            expected = "Tam giac vuong";
            actual = c.GetTypeTriangle();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Testcase_TamGiacCan_80_Kiet()
        {
            string expected, actual;
            ShapeCalculator c = new ShapeCalculator(4, 4, 6);
            expected = "Tam giac can";
            actual = c.GetTypeTriangle();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Testcase_TamGiacDeu_80_Kiet()
        {
            string expected, actual;
            ShapeCalculator c = new ShapeCalculator(8, 8, 8);
            expected = "Tam giac deu";
            actual = c.GetTypeTriangle();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Testcase_TamGiacTu_80_Kiet()
        {
            string expected, actual;
            ShapeCalculator c = new ShapeCalculator(5, 8, 10);
            expected = "Tam giac tu";
            actual = c.GetTypeTriangle();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Testcase_TamGiacNhon_80_Kiet()
        {
            string expected, actual;
            ShapeCalculator c = new ShapeCalculator(7, 8, 9);
            expected = "Tam giac nhon";
            actual = c.GetTypeTriangle();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Testcase_KhongPhaiTamGiac_80_Kiet()
        {
            string expected, actual;
            ShapeCalculator c = new ShapeCalculator(7, 3, 3);
            expected = "Khong phai tam giac";
            actual = c.GetTypeTriangle();
            Assert.AreEqual(expected, actual);
        }
  
       [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data_80_VanKiet\DataTest_80.csv","DataTest_80#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestWithDataSource_80_VanKiet()
        {
            int a, b, c;
            string expected, actual;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b= int.Parse(TestContext.DataRow[1].ToString());
            c = int.Parse(TestContext.DataRow[2].ToString());
            expected= TestContext.DataRow[3].ToString();
            ShapeCalculator triangle = new ShapeCalculator(a, b, c);
            actual = triangle.GetTypeTriangle();
            Assert.AreEqual(expected, actual);
        }
    }
}
