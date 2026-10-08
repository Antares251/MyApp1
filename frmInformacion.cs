using System.Data;

namespace MyApp01;

public partial class frmInformacion : Form
{
    Datos datos;
    public frmInformacion()
    {
        InitializeComponent();
    }

    private void frmInformacion_Load(object sender, EventArgs e)
    {
        datos = new Datos();
        DataSet ds = datos.Informacion("Select * from Datos");

        if (ds != null)
        {
            dgvInformacion.DataSource = ds.Tables[0];
        }
    }
}