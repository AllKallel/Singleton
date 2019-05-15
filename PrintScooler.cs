using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class PrintScooler
    {
        private PrintScooler() { }
        private static PrintScooler printScooler = null;

        
        public static PrintScooler getPrintScooler()
        {
            if(printScooler == null)
            {
               printScooler = new PrintScooler();
            }
            return printScooler;
            
        }

        public void Print(String mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadLine();
        }
    }
}
