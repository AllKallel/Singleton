using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class DataBase
    {
        private DataBase() { }
        private static DataBase dataBase = null;

        public static DataBase GetDataBase()
        {
            if (dataBase == null)
            {
                dataBase = new DataBase();
            }
            return dataBase;
        }

        public Boolean Conect()
        {
            return true;
        }

    }
}
