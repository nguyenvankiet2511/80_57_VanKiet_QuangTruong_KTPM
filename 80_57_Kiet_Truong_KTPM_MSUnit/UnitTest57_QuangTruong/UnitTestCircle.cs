using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _80_57_Kiet_Truong_KTPM_MSUnit.CircleCalculator;
using static _80_57_Kiet_Truong_KTPM_MSUnit.CircleCalculator.Circle;
namespace UnitTest57_QuangTruong
{
    public class UnitTestCircle
    {
        [TestClass]

        public class CircleTests
        {
            public TestContext TestContext { get; set; }//57_QuangTruong

            [TestMethod]
            public void NamTrongDuongTron()
            { 
                //57_QuangTruong
                // Arrange
                Point center = new Point(0, 0);
                double radius = 5;
                Circle circle = new Circle(center, radius);
                string expected = "Trong";
                // Act
                Point insidePoint = new Point(4, 2);
                string actual = CircleUtils.KiemTraDiem(circle, insidePoint);
                // Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void NamNgoaiDuongTron()
            {
                // Arrange
                Point center = new Point(0, 0);
                double radius = 5;
                Circle circle = new Circle(center, radius);
                string expected = "Ngoai";
                // Act
                Point insidePoint = new Point(6, 0);
                string actual = CircleUtils.KiemTraDiem(circle, insidePoint);
                // Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void NamTrenDuongTron()
            {
                // Arrange
                Point center = new Point(0, 0);
                double radius = 5;
                Circle circle = new Circle(center, radius);
                string expected = "Tren";
                // Act
                Point insidePoint = new Point(0, 5);
                string actual = CircleUtils.KiemTraDiem(circle, insidePoint);
                // Assert
                Assert.AreEqual(expected, actual);
            }

            //57_QuangTruong

            [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
             @".\Data_57_QuangTruong\DataTest_57.csv", "DataTest_57#csv", DataAccessMethod.Sequential)]
            [TestMethod]
            public void TestWithDataSource()
            {
                int x, y, c1, c2, r;
                string expected, actual;
                x = int.Parse(TestContext.DataRow[0].ToString());
                y = int.Parse(TestContext.DataRow[1].ToString());
                c1 = int.Parse(TestContext.DataRow[2].ToString());
                c2 = int.Parse(TestContext.DataRow[3].ToString());
                r = int.Parse(TestContext.DataRow[4].ToString());
                expected = TestContext.DataRow[5].ToString();
                Point point = new Point(x, y);
                Point center = new Point(c1, c2);
                Circle cricle = new Circle(center, r);
                actual = CircleUtils.KiemTraDiem(cricle, point);
                Assert.AreEqual(expected, actual);

            }

        }
    }
}

