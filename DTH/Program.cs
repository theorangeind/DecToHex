using System;
using System.IO;

namespace TenToSixteen
{
    class Program
    {
        static String alp = "0123456789ABCDEF";

        static void Main(string[] args)
        {
            String temp = "";
            String output = "";

            int a;

            //reading
            using (StreamReader sr = new StreamReader(@"D:\input.txt"))
            {
                Console.WriteLine("Reading decimal number...");
                try
                {
                    a = Convert.ToInt32(sr.ReadLine());
                    sr.Close();
                    Console.WriteLine("Converting '" + a + "' to hexadecimal...");
                }
                catch
                {
                    Console.WriteLine("Found unconvertable symbols! Breaking...");
                    a = 0;
                }
            }

            //calc
            while (true)
            {
                if (a > 15)
                {
                    int b = a % 16;
                    temp += alp[b];
                    a /= 16;
                }
                else
                {
                    temp += alp[a];
                    break;
                }
            }

            //reverse
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                output += temp[i];
            }

            //writing
            using (StreamWriter sw = new StreamWriter(@"D:\output.txt"))
            {
                sw.Write(output);
                sw.Close();
            }
        }
    }
}
