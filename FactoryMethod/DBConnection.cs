namespace FactoryMethod
{
    public class DBConnection 
    {
        public class MySQLDBConnection : IDBConnection
        {
            public void GetConnection()
            {
                Console.WriteLine("MySQL DB is connected");
            }
        }

        public class CSharpDBConnection : IDBConnection
        {
            public void GetConnection()
            {
                Console.WriteLine("CSharp DB is connected");
            }
        }

        public class OracleDBConnection : IDBConnection
        {
            public void GetConnection()
            {
                Console.WriteLine("Oracle DB is connected");
            }
        }


    }
}
