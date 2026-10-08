namespace MyApp01;

public partial class frmAgregar : Form
{
    Datos datos;
    public frmAgregar()
    {
        InitializeComponent();
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        datos = new Datos();
        bool f=datos.Insertar(txtNombre.Text, txtApPaterno.Text,
            txtApMaterno.Text, txtTelefono.Text, txtCorreo.Text);
        if (f) 
        {
            MessageBox.Show("Registro agregado correctamente");
            this.Close();
        }
        else
        {
            MessageBox.Show("Error al agregar el registro");
        }
    }
}