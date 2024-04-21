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
        }
        private void setUp(int profile)
        {//80_57_VanKiet_QuangTruong
            var options = new ChromeOptions();
            if(profile == 0)
            {
                options.AddArgument("user-data-dir=C:\\Users\\T470p\\AppData\\Local\\Google\\Chrome\\User Data\\");
                options.AddArgument("profile-directory=Profile 8");
            }
            else if(profile == 1)
            {
                options.AddArgument("user-data-dir=C:\\Users\\T470p\\AppData\\Local\\Google\\Chrome\\User Data\\");
                options.AddArgument("profile-directory=Profile 2");
            }
            else if (profile == 2)
            {
                options.AddArgument("user-data-dir=C:\\Users\\T470p\\AppData\\Local\\Google\\Chrome\\User Data\\");
                options.AddArgument("profile-directory=Profile 3");
            }
            options.AddArgument("--start-maximized");
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            driver_80_57 = new ChromeDriver(service, options);
        }
        private void navigate()
        {
            driver_80_57.Navigate().GoToUrl(siteURL);
        }

        private void btnTC1_TKAmThanhTC_80_Kiet_Click(object sender, EventArgs e)
        {
            //80_VanKiet
            setUp(1);
            navigate();//Chạy trang https://www.shutterstock.com/vi
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div[2]/div[1]/div/div[4]/li")).Click();
            Thread.Sleep(3000);//đợi trang load
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div[2]/div[2]/div[3]/div/div/div/button")).Click();
            Thread.Sleep(3000);//đợi trang load
            driver_80_57.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"E:\KTPM\video_test\mp3_158kb.mp3");
        }
        private void btnTC2_TKAmThanh_SaiDinhDang_80_Kiet_Click(object sender, EventArgs e)
        {
            //80_VanKiet
            setUp(1);
            navigate();//Chạy trang https://www.shutterstock.com/vi
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div[2]/div[1]/div/div[4]/li")).Click();
            Thread.Sleep(3000);//đợi trang load
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div[2]/div[2]/div[3]/div/div/div/button")).Click();
            Thread.Sleep(3000);//đợi trang load
            driver_80_57.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"E:\KTPM\video_test\mkv_24mb.mkv");
        }

        private void btnTC3_TKAmThanh_SaiDungLuong_80_Kiet_Click(object sender, EventArgs e)
        {
            //80_VanKiet
            setUp(1);
            navigate();//Chạy trang https://www.shutterstock.com/vi
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div[2]/div[1]/div/div[4]/li")).Click();
            Thread.Sleep(3000);//đợi trang load
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div[2]/div[2]/div[3]/div/div/div/button")).Click();
            Thread.Sleep(3000);//đợi trang load
            driver_80_57.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"E:\KTPM\video_test\mp3_76mb.mp3");
        }

        private void btn_TC1_LuuVaoBoSuuTapCN_80_VanKiet_Click(object sender, EventArgs e)
        {
            setUp(0);//Profile đã đăng nhập
            driver_80_57.Navigate().GoToUrl("https://www.shutterstock.com/vi/image-photo/man-stroking-his-old-dog-loyal-2214665467");
            //80_Kiet
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[1]/div[2]/div[1]/div/div/div/div[1]/div/div[2]/div/div[1]/div[2]/div[1]/div[1]/button")).Click();
            //80_Kiet
            driver_80_57.FindElement(By.XPath("/html/body/div[8]/div[3]/div/div/div[2]/div[2]/div[2]/div/button")).Click();
        }

        private void btn_TC2_LuuVaoBoSuuTapMD_80_Kiet_Click(object sender, EventArgs e)
        {
            setUp(1);//Profile đã đăng nhâp
            driver_80_57.Navigate().GoToUrl("https://www.shutterstock.com/vi/image-photo/man-stroking-his-old-dog-loyal-2214665467");
            //80_Kiet
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[1]/div[2]/div[1]/div/div/div/div[1]/div/div[2]/div/div[1]/div[2]/div[1]/div[1]/button")).Click();
        }

        private void btn_TC3_BoSuuTap_ChuyenTrangLogin_80_Kiet_Click(object sender, EventArgs e)
        {
            setUp(2);//Profile chưa đăng nhập
            driver_80_57.Navigate().GoToUrl("https://www.shutterstock.com/vi/image-photo/man-stroking-his-old-dog-loyal-2214665467");
            //80_Kiet
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[1]/div[2]/div[1]/div/div/div/div[1]/div/div[2]/div/div[1]/div[2]/div[1]/div[1]/button")).Click();

        }

        private void btn_TC1_TaoThietKe_ThanhCong_80_57_Kiet_Truong_Click(object sender, EventArgs e)
        {
            setUp(0);
            navigate();
            //80_VanKiet
            driver_80_57.FindElement(By.CssSelector("#primaryNavItems > div:nth-child(4) > div")).Click();
            //80_VanKiet
            driver_80_57.FindElement(By.CssSelector("#__next > div.MuiContainer-root.MuiContainer-disableGutters.mui-sgxi1e-root >" +
                " div > div.MuiBox-root.mui-1fjtzvx > div.mui-e11pc7-content > div:nth-child(2) > div.mui-1e99pvw-root > div > div >" +
                " div:nth-child(1) > div > div > div")).Click();
            driver_80_57.FindElement(By.Id(":r9:")).SendKeys("80_57_Kiet_Truong");//Tìm và thiết lập giá trị cho ô tên thiết kế
            driver_80_57.FindElement(By.Id(":ra:")).SendKeys("80");//Tìm và thiết lập giá trị cho ô chiều rộng cho phép
            driver_80_57.FindElement(By.Id(":rb:")).SendKeys("57");//Tìm và thiết lập giá trị cho ô chiều cao cho phép
            //80_VanKiet
            driver_80_57.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div/div[2]/button")).Click();
           
           
        }

        private void btn_TC2_TaoThietKe_TenThietKeTrong_80_57_Kiet_Truong_Click(object sender, EventArgs e)
        {
            setUp(0);
            navigate();
            //80_VanKiet Tìm kiếm và nhấn Click() vào nút Sáng tạo
            driver_80_57.FindElement(By.CssSelector("#primaryNavItems > div:nth-child(4) > div")).Click();
            //80_VanKiet Tìm kiếm và nhấn Click() vào nút Kích thước tùy chỉnh
            driver_80_57.FindElement(By.CssSelector("#__next > div.MuiContainer-root.MuiContainer-disableGutters.mui-sgxi1e-root >" +
                " div > div.MuiBox-root.mui-1fjtzvx > div.mui-e11pc7-content > div:nth-child(2) > div.mui-1e99pvw-root > div > div >" +
                " div:nth-child(1) > div > div > div")).Click();
            driver_80_57.FindElement(By.Id(":ra:")).SendKeys("80");//Tìm và thiết lập giá trị cho ô chiều rộng cho phép
            driver_80_57.FindElement(By.Id(":rb:")).SendKeys("57");//Tìm và thiết lập giá trị cho ô chiều cao cho phép
            //80_VanKiet Tìm kiếm và nhấn Click() vào nút Tạo thiết kế
            driver_80_57.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div/div[2]/button")).Click();
        }

        private void Btn1_TKHinhAnh_Click(object sender, EventArgs e)//upload ảnh thành công
        {
            //57_QuangTruong
           //Chạy trang https://www.shutterstock.com/vi
            setUp(0);
            navigate();
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[1]/div/div[1]/div[2]/div[2]/div/div[1]/div/div[1]/li")).Click();
            Thread.Sleep(3000);// đợi trang load

            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[1]/div/div[1]/div[2]/div[2]/div/div[2]/div[3]/div/div/div/button")).Click();
            Thread.Sleep(3000);

            //upload  ảnh 
            driver_80_57.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"D:\KiemThu\anh1.png");
        }

        private void Btn2_TKhinhanh_Click(object sender, EventArgs e)// upload ảnh bị sai định dạng
        {
            //57_QuangTruong

            setUp(0);
            navigate();
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[1]/div/div[1]/div[2]/div[2]/div/div[1]/div/div[1]/li")).Click();
            Thread.Sleep(3000);// đợi trang load

            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[1]/div/div[1]/div[2]/div[2]/div/div[2]/div[3]/div/div/div/button")).Click();
            Thread.Sleep(3000);

            //upload  ảnh
            driver_80_57.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"D:\KiemThu\anh2.webp");
        }

        private void Btn3_KTHinhAnh_Click(object sender, EventArgs e)// ảnh upload lớn hơn 25MB
        {
            //57_QuangTruong
            setUp(0);
            navigate();
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[1]/div/div[1]/div[2]/div[2]/div/div[1]/div/div[1]/li")).Click();
            Thread.Sleep(3000);// đợi trang load

            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[1]/div/div[1]/div[2]/div[2]/div/div[2]/div[3]/div/div/div/button")).Click();
            Thread.Sleep(3000);
            //upload  ảnh
            driver_80_57.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"D:\KiemThu\anh3.png");
        }

        private void Btn1_ChuyenDoi_Click(object sender, EventArgs e)// chuyển đổi ảnh thành công
        {
            setUp(0);
            //57_QuangTruong
            driver_80_57.Navigate().GoToUrl("https://www.shutterstock.com/vi/file-converter"); //Chạy trang 
           
            driver_80_57.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"D:\KiemThu\anh1.png"); 
            //upload  ảnh
            Thread.Sleep(1000);

            // chọn loại định dạng cần tải xuống
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[2]/div/main/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/div[3]/button")).Click();
            Thread.Sleep(1000);

            // tải xuống
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[2]/div/main/div/div/div/div/div[2]/div/div/div[2]/div/div[3]/button")).Click();
            Thread.Sleep(1000);
        }

        private void Btn2_ChuyenDoi_Click(object sender, EventArgs e)// ảnh chuyển đổi sai định dạng
        {
            setUp(0);
            //57_QuangTruong
            driver_80_57.Navigate().GoToUrl("https://www.shutterstock.com/vi/file-converter"); //Chạy trang 
         
            driver_80_57.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"D:\KiemThu\anh2.webp");    //upload  ảnh
            Thread.Sleep(1000);

            // chọn loại định dạng cần tải xuống
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[2]/div/main/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/div[1]/button")).Click();
            Thread.Sleep(1000);

            // tải xuống
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[2]/div/main/div/div/div/div/div[2]/div/div/div[2]/div/div[3]/button")).Click();
            Thread.Sleep(1000);
        }
        private void Btn3_ChuyenDoi_Click(object sender, EventArgs e) // không chọn ảnh cần tải xuống theo định dạng
        {
            //57_QuangTruong
            setUp(0);
            driver_80_57.Navigate().GoToUrl("https://www.shutterstock.com/vi/file-converter");//Chạy trang 
            
            driver_80_57.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"D:\KiemThu\anh4.jpg");
            Thread.Sleep(1000);

            // tải xuống
            driver_80_57.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[2]/div/main/div/div/div/div/div[2]/div/div/div[2]/div/div[3]/button")).Click();
            Thread.Sleep(1000);
        }
        private void btn_TC3_TaoThietKe_ThanhCong_80_57_Kiet_Truong_Click(object sender, EventArgs e)// chiều rộng sai
        {
            setUp(0);
            navigate();
            //57_QuangTruong
            driver_80_57.FindElement(By.CssSelector("#primaryNavItems > div:nth-child(4) > div")).Click();

            //57_QuangTruong
            Thread.Sleep(2000);
            driver_80_57.FindElement(By.CssSelector("#__next > div.MuiContainer-root.MuiContainer-disableGutters.mui-sgxi1e-root > div > div.MuiBox-root.mui-1fjtzvx > div.mui-e11pc7-content > div:nth-child(2) > div.mui-1e99pvw-root > div > div > div:nth-child(1) > div > div > div > div > p")).Click();
            Thread.Sleep(2000);

            driver_80_57.FindElement(By.CssSelector("input[type='text']")).SendKeys("Quang Trường");//ghi giá trị cho tên ô thiết kế
            driver_80_57.FindElement(By.XPath("/html/body/div[8]/div[3]/div/div/div[2]/div[2]/div/input")).SendKeys("20");//ghi giá trị cho ô chiều rộng
            driver_80_57.FindElement(By.XPath("/html/body/div[8]/div[3]/div/div/div[2]/div[3]/div/input")).SendKeys("");// ghi giá trị cho chiều cao
            Thread.Sleep(3000);
            //57_QuangTruong
            driver_80_57.FindElement(By.XPath("/html/body/div[8]/div[3]/div/div/div[2]/button")).Click();
            
        }

        private void btn_TC4_TaoThietKe_ThanhCong_80_57_Kiet_Truong_Click(object sender, EventArgs e)// chiều dài sai
        {
            setUp(0);
            navigate();
            //57_QuangTruong
            driver_80_57.FindElement(By.CssSelector("#primaryNavItems > div:nth-child(4) > div")).Click();

            //57_QuangTruong
            Thread.Sleep(2000);
            driver_80_57.FindElement(By.CssSelector("#__next > div.MuiContainer-root.MuiContainer-disableGutters.mui-sgxi1e-root > div > div.MuiBox-root.mui-1fjtzvx > div.mui-e11pc7-content > div:nth-child(2) > div.mui-1e99pvw-root > div > div > div:nth-child(1) > div > div > div > div > p")).Click();
            Thread.Sleep(2000);

            driver_80_57.FindElement(By.CssSelector("input[type='text']")).SendKeys("Quang Trường ");//ghi giá trị cho tên ô thiết kế
            driver_80_57.FindElement(By.XPath("/html/body/div[8]/div[3]/div/div/div[2]/div[2]/div/input")).SendKeys("");//ghi giá trị cho ô chiều rộng
            driver_80_57.FindElement(By.XPath("/html/body/div[8]/div[3]/div/div/div[2]/div[3]/div/input")).SendKeys("50");// ghi giá trị cho chiều cao
            Thread.Sleep(3000);
            //57_QuangTruong
            driver_80_57.FindElement(By.XPath("/html/body/div[8]/div[3]/div/div/div[2]/button")).Click();
        }


    }
}
