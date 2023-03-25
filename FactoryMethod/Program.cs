

using FactoryMethod;

IDBConnectionFactory dBConnectionFactory = new DBConnectionFactory("Oracle");
dBConnectionFactory.CreateConnection().GetConnection();

dBConnectionFactory = new DBConnectionFactory("MySQL");
dBConnectionFactory.CreateConnection().GetConnection();

Console.WriteLine();