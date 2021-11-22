using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace firma
{
    public class ControladorBD
    {
        readonly SQLiteAsyncConnection db;

        public ControladorBD(String pathdb)
        {
            db = new SQLiteAsyncConnection(pathdb);
            db.CreateTableAsync<Persona>().Wait();
        }

        
    }
}
