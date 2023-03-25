using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DBConnectionFactory : IDBConnectionFactory
    {
        private string _type;
        public DBConnectionFactory(string type)
        {
            this._type = type;
        }
        public IDBConnection CreateConnection()
        {
            switch (_type)
            {
                case "Oracle":
                    return new DBConnection.OracleDBConnection();
                case "CSharp":
                    return new DBConnection.CSharpDBConnection();
                case "MySQL":
                default:
                    return new DBConnection.MySQLDBConnection();

            }
        }
    }
}
