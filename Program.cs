using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintScooler p = PrintScooler.getPrintScooler();
            p.Print("olá Mundo");

            DataBase data = DataBase.GetDataBase();
            
            Console.WriteLine(data.Conect());
            Console.ReadLine();

        }
    }
}
