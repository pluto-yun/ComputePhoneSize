using System;
using System.Collections.Generic;
using System.Text;
using static System.Convert;
using static System.Console;

namespace ComputePhoneSize
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while ( i>=1)
            {
                WriteLine("请输入屏幕尺寸：");
                float SrcLgth = float.Parse(ReadLine());
                SrcLgth *= 2.54f;
                int j = 1;
                while (j <= 1)
                {
                    WriteLine("请输入屏幕比（长:宽)：");
                    string[] chc = ReadLine().Split(new char[2] { ':', '：' });
                    if (chc.Length == 2)
                    {

                        double length = SrcLgth / (Math.Sqrt(Math.Pow(float.Parse(chc[0]), 2) + Math.Pow(float.Parse(chc[1]), 2))) * float.Parse(chc[0]);
                        double wideth = SrcLgth / (Math.Sqrt(Math.Pow(float.Parse(chc[0]), 2) + Math.Pow(float.Parse(chc[1]), 2))) * float.Parse(chc[1]);

                        WriteLine("请输入屏占比：");
                        double bl;
                        if (ReadLine() == "")
                        {
                            bl = 1;
                        }
                        else
                        {
                            bl = float.Parse(ReadLine());
                        }
                        double lengthTrue = 10 * length * Math.Sqrt(1 / bl);
                        double widethTrue = 10 * wideth * Math.Sqrt(1 / bl);
                        WriteLine($"手机尺寸\n长为：{lengthTrue.ToString("0.00")}mm\n宽为：{widethTrue.ToString("0.00")}mm");
                        //两种形式均可的到小数点后2位
                        //WriteLine($"手机尺寸\n长为：{Math.Round(lengthTrue,2)}mm\n宽为：{Math.Round(widethTrue,2)}mm");

                        i++;
                        j++;
                        ReadKey();
                        Clear();

                    }
                    else
                    {
                        WriteLine("输入错误！！！！");
                        continue;
                    }
                }
            }
        }
    }
}
