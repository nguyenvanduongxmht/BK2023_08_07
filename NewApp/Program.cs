// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, P,S;
            
            Console.Write("Nhap vao chieu dai a: " );
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao chieu rong b: ");
            b = Convert.ToDouble(Console.ReadLine());
            P = (a + b) * 2;
            S= a*b;
            long slong= new long();
            slong=1;
            int sInt=  9;
            string sString="skjfskfhsk";
            string sStringToNum="214423.45";           
            decimal sDecimal=12345678987654320;
            Console.WriteLine("Chu vi hinh chu nhat có chiều rộng"  +a + "và chiều dài"+ b + "la:"  +P);            
            Console.WriteLine("Dien tich hinh chu nhat có chiều dài  {0} rộng {1} là {2} ",a,b,S);  
            System.Console.WriteLine(slong.ToString() + "\n" + sString+"\n"+sInt);  
            System.Console.WriteLine("conver string to double {0}", Convert.ToDouble(sStringToNum));
            int.TryParse(123);
            
        }
    }
}










