using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _80_57_VanKiet_QuangTruong_BTL_KTPM
{
    public partial class Form1 : Form
    {
        //    private IWebDriver driver;
        //    public IDictionary<string, object> vars { get; private set; }
        //    private IJavaScriptExecutor js;


        //    public Form1()
        //    {
        //        InitializeComponent();
        //        SetUp(); // Call SetUp method here
        //    }

        //
        //    protected void TearDown()
        //    {
        //        driver.Quit();
        //    }

        //    public void test2InvalidEmail()
        //    {
        //        driver.Navigate().GoToUrl("https://www.shutterstock.com/vi/");
        //        var a = driver.FindElement(By.CssSelector("div.MuiContainer-root.MuiContainer-disableGutters.mui-sgxi1e-root header.MuiPaper-root.MuiPaper-elevation.MuiPaper-elevation4.MuiAppBar-root.MuiAppBar-colorPrimary.MuiAppBar-positionRelative.mui-13x0ifu-root-root-siteHeader div.MuiGrid-root.MuiGrid-container.mui-10cm3u-container div.MuiGrid-root.MuiGrid-item.mui-hoqpgz-gridItemContainer:nth-child(3) div.mui-2baw36-hideMdDown:nth-child(4) > a.MuiButtonBase-root.MuiButton-root.MuiButton-outlined.MuiButton-outlinedPrimary.MuiButton-sizeSmall.MuiButton-outlinedSizeSmall.MuiButton-disableElevation.MuiButton-root.MuiButton-outlined.MuiButton-outlinedPrimary.MuiButton-sizeSmall.MuiButton-outlinedSizeSmall.MuiButton-disableElevation.mui-14t494t-navSpacing-siteHeaderTextColor-outlined-actionHover:nth-child(1)"));
        //        a.Click();
        //        Thread.Sleep(10000);
        //        driver.FindElement(By.CssSelector("div.MuiDialog-root.MuiModal-root.mui-126xj0f:nth-child(46) div.MuiDialog-container.MuiDialog-scrollPaper.mui-16u656j:nth-child(3) div.MuiPaper-root.MuiPaper-elevation.MuiPaper-rounded.MuiPaper-elevation24.MuiDialog-paper.MuiDialog-paperScrollPaper.MuiDialog-paperWidthLg.mui-1fzv7gn div.mui-1iuhhry-flexRoot div.MuiBox-root.mui-6h3w0u-container:nth-child(1) > div.MuiBox-root.mui-1i631ux")).Click();

        //    }
        //    private void Form1_Load(object sender, EventArgs e)
        //    {
        //        test2InvalidEmail();
        //        Thread.Sleep(5000);
        //        TearDown();
        //    }
        //}
        private IWebDriver driver;

        private const string siteURL = "https://www.shutterstock.com/vi";
        //65 - Nguyễn Hữu Tú
        private void useProfile()
        {
            var options = new ChromeOptions();
            options.AddArgument("C:\\Users\\Admin\\AppData\\Local\\Google\\Chrome\\User Data\\Default");
            options.AddArgument("profile-directory=Default");
            options.AddArgument("--start-maximized");
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            driver = new ChromeDriver(service, options);
        }

        private void navigate()
        {
    
        

        }
        private void SetUp()
        {
            driver.Navigate().GoToUrl(siteURL);
        }

        private void clickSignUp()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/header/div/div[3]/div[3]/button")).Click();
            Thread.Sleep(12000);
        }

        private void clickEmail()
        {
            driver.FindElement(By.XPath("/html/body/div/div/main/div/div/div/div/div/form/div[2]/div[1]/span[1]/div/div/input")).Click();
            Thread.Sleep(5000);
        }
        private void clickPassWord()
        {
            driver.FindElement(By.XPath("/html/body/div/div/main/div/div/div/div/div/form/div[2]/div[1]/span[2]/div/div")).Click();
            Thread.Sleep(5000);
        }

        private void clickDangKi()
        {
            //CreateUserForm_bottomSpacingSm__sLqm5
            driver.FindElement(By.CssSelector("div[class='CreateUserForm_bottomSpacingSm__sLqm5']")).Click();
            Thread.Sleep(5000);
        }

        private void SaiEmail()
        {
            var titleBox = driver.FindElement(By.CssSelector("input[id=':r0:']"));
            titleBox.SendKeys("hahahaemailsairoihahhaha");
            Thread.Sleep(5000);
        }
        private void PWDung()
        {
            var titleBox = driver.FindElement(By.CssSelector("input[data-test-id='password-input']"));
            titleBox.SendKeys("emyeucoThanh");
            Thread.Sleep(5000);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SetUp();
            //gbfgbr();
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div[2]/div[1]/div/div[4]/li")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div[2]/div[2]/div[3]/div/div/div/button")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"E:\KTPM\video_test\mp3_158kb.mp3");
        }

        public Form1()
        {
            InitializeComponent();
            useProfile();
        }
        public void gbfgbr()
        {
        
            
        }
        public void DangKy()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/header/div/div[3]/div[3]/button")).Click();
            Thread.Sleep(10000);
            driver.FindElement(By.CssSelector("body:nth-child(2) div.MuiDialog-root.MuiModal-root.mui-126xj0f:nth-child(51) > div.MuiDialog-container.MuiDialog-scrollPaper.mui-16u656j:nth-child(3)")).SendKeys("sknajqefj");
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("input[data-test-id='password-input']")).SendKeys("cffgggfgfgg");
            Thread.Sleep(5000);
        }
    }
}
