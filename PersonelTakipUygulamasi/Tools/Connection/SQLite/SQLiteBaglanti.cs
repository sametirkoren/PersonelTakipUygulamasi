using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi.Tools.Connection.SQLite
{
    public class SQLiteBaglanti
    {
        private static SQLiteConnection _connection;
        public static SQLiteConnection Connection
        {
            get
            {
                if(_connection == null)
                {
                    _connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["PersonelTakipSQLite"].ConnectionString);
                }
                return _connection;
            }
        }

        public static void BaglantiAc()
        {
            if(Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public static void BaglantiKapat()
        {
            if(Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}
