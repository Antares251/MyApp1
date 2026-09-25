using System.ComponentModel;

namespace MyApp01;

public partial class Form2 : Form
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string ActualizaNombre { get; set; }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string ActualizaCorreo { get; set; }
    
    public Form2(string nombre,string correo)
    {
        InitializeComponent();
        txtNombre.Text = nombre;
        txtCorreo.Text = correo;
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
        ActualizaNombre = txtNombre.Text;
        ActualizaCorreo = txtCorreo.Text;
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}