using System.Data;

namespace MyApp01;

public partial class frmInformacion : Form
{
    Datos datos;
    public frmInformacion()
    {
        InitializeComponent();
    }

    private void ActualizarGrid()
    {
        datos = new Datos();
        DataSet ds = datos.Informacion("Select * from Datos");

        if (ds != null)
        {
            dgvInformacion.AutoGenerateColumns = true;
            dgvInformacion.DataSource = ds.Tables[0];
        }
        else
        {
            MessageBox.Show("No se pudo obtener la información de la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }

    private void frmInformacion_Load(object sender, EventArgs e)
    {
        ActualizarGrid();
    }


    private void btnCerrar_Click(object sender, EventArgs e)
    {
        Close();
    }
}
