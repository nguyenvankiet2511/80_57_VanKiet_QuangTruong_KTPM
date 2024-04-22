using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80_57_Kiet_Truong_KTPM_MSUnit
{
    public class ShapeCalculator
    {
        private int a, b, c;//3 cạnh của tam giác
        public ShapeCalculator(int a ,int b, int c ) 
        {//80_Kiet
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public string GetTypeTriangle()
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                {
                    return "Tam giac vuong";
                }
                else if (a == b && b == c)  // Kiểm tra tam giác đều_80_VanKiet
                {
                    return "Tam giac deu";
                }           
                else if (a == b || a == c || b == c)// Kiểm tra tam giác cân_80_VanKiet
                {
                    return "Tam giac can";
                }
                // Kiểm tra tam giác tù_80_VanKiet
                else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
                { 
                    return "Tam giac tu";
                }
                // Các trường hợp còn lại là tam giác nhọn
                else
                {
                    return "Tam giac nhon";
                }
            }
            else
            {
                return "Khong phai tam giac";
            }   
        }       
    }
}
