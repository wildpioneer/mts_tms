using DB_Npgsql.Configuration;
using Npgsql;

namespace GUI.Databases;

public class DBConnector
{
    public DBConnector()
    {
        var connectionString =
            $"Host={Configurator.DbSettings.Server};" +
            $"Port={Configurator.DbSettings.Port};" +
            $"Database={Configurator.DbSettings.Schema};" +
            $"User Id={Configurator.DbSettings.Username};" +
            $"Password={Configurator.DbSettings.Password};";

        Connection = new NpgsqlConnection(connectionString);
        Connection.Open();
    }

    public NpgsqlConnection Connection { get; }

    public void CloseConnection()
    {
        Connection.Close();
    }
}
