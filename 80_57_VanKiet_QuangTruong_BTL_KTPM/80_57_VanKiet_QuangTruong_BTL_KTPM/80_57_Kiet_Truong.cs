using System;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _80_57_VanKiet_QuangTruong_BTL_KTPM
{
    public partial class Form1 : Form
    {
        private IWebDriver driver_80_57;
        private const string siteURL = "https://www.shutterstock.com/vi";
        public Form1()
        {
            InitializeComponent();
            setUp();
        }
        private void setUp()
        {//80_57_VanKiet_QuangTruong
            var options = new ChromeOptions();
            options.AddArgument("C:\\Users\\Admin\\AppData\\Local\\Google\\Chrome\\User Data\\Default");
            options.AddArgument("profile-directory=Default");
            options.AddArgument("--start-maximized");
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            driver_80_57 = new ChromeDriver(service, options);
        }
        private void navigate()
        {
            driver_80_57.Navigate().GoToUrl(siteURL);
        }

        private void btnTC1_TKAmThanhTC_80_57_Kiet_Truong_Click(object sender, EventArgs e)
        {
            //80_57_VanKiet_QuangTruong
            navigate();//Chạy trang https://www.shutterstock.com/vi
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div[2]/div[1]/div/div[4]/li")).Click();
            Thread.Sleep(3000);//đợi trang load
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div[2]/div[2]/div[3]/div/div/div/button")).Click();
            Thread.Sleep(3000);//đợi trang load
            driver_80_57.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"E:\KTPM\video_test\mp3_158kb.mp3");
        }
    }
}
