using Microsoft.Data.SqlClient;

namespace SistemaLoja.Lab12_ConexaoSQLServer;

public class DatabaseConnection
{
    private static readonly string connectionString =
        "Server=localhost,1433;" +
        "Database=SistemaLojaDB;" +
        "User Id=sa;" +
        "Password=SqlServer2024!;" +
        "TrustServerCertificate=True;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}