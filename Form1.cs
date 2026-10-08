namespace MyApp01;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmAgregar agregar = new frmAgregar();
        agregar.Show();
    }
}