using System.Data.SqlClient;

namespace MyApp01;

public partial class frmAgregar : Form
{
    bool updateMode = false;
    string? columnaClave;
    object valorClave = DBNull.Value;
    object[] valoresOriginales = Array.Empty<object>();
    Datos datos;

    public frmAgregar()
    {
        InitializeComponent();
    }
    
    public frmAgregar(string nombre, string paterno, string materno,
        string telefono, string correo, string? columnaClave, object valorClave,
        object[] valoresOriginales)
    {
        InitializeComponent();
        txtNombre.Text = nombre;
        txtPaterno.Text = paterno;
        txtMaterno.Text = materno;
        txtTelefono.Text = telefono;
        txtCorreo.Text = correo;
        btnAgregar.Text = "Modificar";
        Text = "Modificar";
        updateMode = true;
        this.columnaClave = columnaClave;
        this.valorClave = valorClave;
        this.valoresOriginales = valoresOriginales;
    }
    

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        datos = new Datos();
        string consulta = "Insert Into Datos(nombre,paterno,materno,telefono,correo) Values(@nombre,@paterno,@materno,@telefono,@correo)";
        if (updateMode)
        {
            string filtro;
            if (columnaClave != null)
            {
                string columnaSegura = columnaClave.Replace("]", "]]");
                filtro = $"[{columnaSegura}]=@id";
            }
            else
            {
                filtro = CrearFiltroPorValores();
                consulta = $"IF (SELECT COUNT(*) FROM Datos WHERE {filtro}) = 1 " +
                    $"UPDATE Datos SET nombre=@nombre,paterno=@paterno,materno=@materno,telefono=@telefono,correo=@correo WHERE {filtro}";
            }

            if (columnaClave != null)
            {
                consulta = $"Update Datos Set nombre=@nombre,paterno=@paterno,materno=@materno,telefono=@telefono,correo=@correo Where {filtro}";
            }
        }

        using SqlCommand comando = new SqlCommand(consulta);
        comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
        comando.Parameters.AddWithValue("@paterno", txtPaterno.Text);
        comando.Parameters.AddWithValue("@materno", txtMaterno.Text);
        comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
        comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
        if (updateMode)
        {
            if (columnaClave != null)
            {
                comando.Parameters.AddWithValue("@id", valorClave);
            }
            else
            {
                AgregarParametrosOriginales(comando);
            }
        }

        bool resultado = datos.ejecutar(comando);
        if (resultado)
        {
            MessageBox.Show(updateMode ? "Registro modificado correctamente" : "Registro agregado correctamente");
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            MessageBox.Show(updateMode ? columnaClave == null ? "No se modifico el registro" : "Error al modificar el registro" : "Error al agregar el registro");
        }
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private string CrearFiltroPorValores()
    {
        string[] columnas = { "nombre", "paterno", "materno", "telefono", "correo" };
        return string.Join(" AND ", columnas.Select((columna, indice) => $"([{columna}]=@original{indice} OR ([{columna}] IS NULL AND @original{indice} IS NULL))"));
    }

    private void AgregarParametrosOriginales(SqlCommand comando)
    {
        for (int indice = 0; indice < valoresOriginales.Length; indice++)
        {
            comando.Parameters.AddWithValue($"@original{indice}", valoresOriginales[indice]);
        }
    }
}