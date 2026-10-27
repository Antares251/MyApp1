using System.Data;
using System.Data.SqlClient;
namespace MyApp01;

public class Datos
{
    SqlConnection conexion;
    string cadenaConexion = "Server=192.168.253.1;Database=Agenda;User ID=sa;Password=Rojinegra12;TrustServerCertificate=True;";

    private SqlConnection conexionOpen()
    {
        try
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.ToString());
            return null;
        }
    }
    private void conexionClose(SqlConnection conectar)
    {            
        try { conexion.Close(); }
        catch (Exception ex) { Console.WriteLine(ex.ToString()); }
    }

    public bool ejecutar(string command)
    {
        try {
            SqlConnection conectar=conexionOpen();              
            SqlCommand sqlCommand = new SqlCommand(command, conectar);
            sqlCommand.ExecuteNonQuery();
            conexionClose(conectar);
            return true;
        }
        catch (Exception ex) {
            Console.WriteLine("Error: " + ex.ToString());
            return false;
        }            
    }

    public bool ejecutar(SqlCommand command)
    {
        try
        {
            SqlConnection conectar = conexionOpen();
            command.Connection = conectar;
            command.ExecuteNonQuery();
            conexionClose(conectar);
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.ToString());
            return false;
        }
    }
    
    public DataSet Informacion(string comando)
    {
        DataSet ds= new DataSet();
        try {
            SqlConnection conecta = conexionOpen();
            SqlDataAdapter da =new  SqlDataAdapter(comando, conecta);
            da.Fill(ds);
            conexionClose(conecta);
            return ds;
        }
        catch (Exception ex) {
            Console.WriteLine("Error: " + ex.ToString());
            return null;
        }
    }
}