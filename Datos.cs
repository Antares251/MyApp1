using System.Data;
using System.Data.SqlClient;
namespace MyApp01;

public class Datos
{
    string cadenaConexion = "Server=192.168.253.1;Database=Agenda;User ID=sa;Password=Rojinegra12;TrustServerCertificate=True;";

    public bool ejecutar(string command)
    {
        try
        {
            using SqlConnection conectar = new SqlConnection(cadenaConexion);
            conectar.Open();
            using SqlCommand sqlCommand = new SqlCommand(command, conectar);
            sqlCommand.ExecuteNonQuery();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.ToString());
            return false;
        }
    }

    public bool ejecutar(SqlCommand command)
    {
        try
        {
            using SqlConnection conectar = new SqlConnection(cadenaConexion);
            conectar.Open();
            command.Connection = conectar;
            return command.ExecuteNonQuery() == 1;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.ToString());
            return false;
        }
    }
    
    public DataSet Informacion(string comando)
    {
        DataSet ds = new DataSet();
        try
        {
            using SqlConnection conecta = new SqlConnection(cadenaConexion);
            using SqlDataAdapter da = new SqlDataAdapter(comando, conecta);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.ToString());
            return null;
        }
    }
}