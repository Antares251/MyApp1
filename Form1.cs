using System.Globalization;
using CsvHelper;
namespace MyApp01;

public partial class Form1 : Form
{
    List<Persona> registros = new List<Persona>();
    public Form1()
    {
        InitializeComponent();
    }
    

    private void btnCargar_Click(object sender, EventArgs e)
    {
        if (ofdCSV.ShowDialog() == DialogResult.OK)
        {
            using (var reader = new StreamReader(ofdCSV.FileName))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                registros = csv.GetRecords<Persona>().ToList();
            }

            foreach (var registro in registros) 
            {
                dgvRegistros.Rows.Add(registro.id, registro.name, registro.email, null, null);
            }
        }
    }

    private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        Form2 editar = new Form2(
            nombre: dgvRegistros.Rows[e.RowIndex].Cells[1].Value.ToString(),
            correo: dgvRegistros.Rows[e.RowIndex].Cells[2].Value.ToString());

        if (editar.ShowDialog() == DialogResult.OK)
        {
            string nombre = editar.ActualizaNombre;
            string correo = editar.ActualizaCorreo;

            dgvRegistros.Rows[e.RowIndex].Cells[1].Value = nombre;
            dgvRegistros.Rows[e.RowIndex].Cells[2].Value = correo;

            registros[e.RowIndex].name = nombre;
            registros[e.RowIndex].email = correo;

            try
            {
                using (var writer = new System.IO.StreamWriter(ofdCSV.FileName))
                using (var csv = new CsvHelper.CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(registros);
                }
            
                MessageBox.Show("Guardado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
    }
}