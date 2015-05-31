using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            doWork();

            Console.ReadKey();
        }

        public static void doWork()
        {

            Character c1 = new Character();
            c1.Name = "John";
            c1.HP = 25;

            Character c2 = new Character("Jim", 50, 50, 100, 100, 100, 100, 50, 50);
            
            Console.WriteLine("Name: {0}   HP: {1}",c1.Name,c1.HP);
            Console.WriteLine("Name: {0}   HP: {1}   MP: {2}", c2.Name, c2.HP, c2.MP);


            string path = @"D:\Development\C# Projects\Game\Save Files\characters.txt";
            try
            {
                using(FileStream fs = File.Create(path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(c2.Name);
                    fs.Write(info, 0, info.Length);
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
