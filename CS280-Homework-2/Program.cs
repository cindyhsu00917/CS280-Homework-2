using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS280_Homework_1._2;

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float number = 004;
            string name = "";
            float height = 0.0f;
            float weight = 0.0f;
            string category = "";
            string abilities = "";
            string gender = "";

            Console.Write("請輸入寶可夢的編號:");
            try
            {
                number = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤，請重新輸入。");
                Console.WriteLine("error message:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入寶可夢的名稱:");
            try
            {
                name = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤，請重新輸入。");
                Console.WriteLine("error message:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入寶可夢的身高:");
            try
            {
                height = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤，請重新輸入。");
                Console.WriteLine("error message:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入寶可夢的重量:");
            try
            {
                weight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤，請重新輸入。");
                Console.WriteLine("error message:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入寶可夢的種類:");
            try
            {
                category = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤，請重新輸入。");
                Console.WriteLine("error message:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入寶可夢的技能:");
            try
            {
                abilities = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤，請重新輸入。");
                Console.WriteLine("error message:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入寶可夢的性別:");
            try
            {
                gender = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤，請重新輸入。");
                Console.WriteLine("error message:\n" + e.ToString());
                return;
            }
            Console.WriteLine("編號:{0}, 名稱:{1}, 身高:{2}, 重量:{3}, 種類:{4}, 技能:{5}, 性別:{6}", number, name, height, weight, category, abilities, gender);
        }
    }
}