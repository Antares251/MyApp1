using System.Data;
using System.Data.SqlClient;
namespace MyApp01;

public class Datos
{
    SqlConnection conexion;
    string cadenaConexion = "Server=192.168.2.1;Database=Agenda;User ID=sa;Password=Rojinegra12;TrustServerCertificate=True;";

    private void conexionOpen()
    {
        try
        {
            conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.ToString());
        }
    }
    private void conexionClose()
    {
        try { conexion.Close(); }
        catch (Exception ex) { Console.WriteLine(ex.ToString()); }
    }

    public bool Insertar(string nombre,string paterno,string materno,
        string telefono,string correo)
    {
        try {
            conexionOpen();
            string comando = "Insert Into Datos(nombre,paterno,materno,telefono," +
                             "correo)Values('" + nombre +"','"+ paterno +
                             "','"+ materno +"','"+ telefono +"','"+ correo +"')";
            SqlCommand sqlCommand = new SqlCommand(comando, conexion);
            sqlCommand.ExecuteNonQuery();
            conexionClose();
            return true;
        }
        catch (Exception ex) {
            Console.WriteLine("Error: " + ex.ToString());
            return false;
        }            
    }
    
    public DataSet Informacion(String comando)
    {
        DataSet ds = null;
        try
        {
            conexion.Open();
            SqlDataAdapter da = new SqlDataAdapter(comando,conexion);
            da.Fill(ds);
            conexion.Close();
            return ds;
        }
        catch(Exception ex){
            Console.WriteLine("Error: "+ ex.ToString());
            return null;
        }
    }
}