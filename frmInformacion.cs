using System.Data;
using System.Data.SqlClient;

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
            MessageBox.Show("No se pudo obtener la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    private void dgvInformacion_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
        {
            dgvInformacion.ClearSelection();
            dgvInformacion.Rows[e.RowIndex].Selected = true;
            dgvInformacion.CurrentCell = dgvInformacion.Rows[e.RowIndex].Cells[e.ColumnIndex];
            contextMenuStrip1.Show(Cursor.Position);
        }
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        using frmAgregar frmAgg = new frmAgregar();
        if (frmAgg.ShowDialog(this) == DialogResult.OK)
        {
            ActualizarGrid();
        }
    }

    private void editarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (dgvInformacion.CurrentRow?.DataBoundItem is not DataRowView registro)
        {
            return;
        }

        bool tieneClave = TryGetClave(registro, out string columnaClave, out object valorClave);
        object[] valoresOriginales = obtenerValores(registro);

        using frmAgregar frmModificar = new frmAgregar(
            Convert.ToString(registro["nombre"]) ?? string.Empty,
            Convert.ToString(registro["paterno"]) ?? string.Empty,
            Convert.ToString(registro["materno"]) ?? string.Empty,
            Convert.ToString(registro["telefono"]) ?? string.Empty,
            Convert.ToString(registro["correo"]) ?? string.Empty,
            tieneClave ? columnaClave : null,
            valorClave,
            valoresOriginales);

        if (frmModificar.ShowDialog(this) == DialogResult.OK)
        {
            ActualizarGrid();
        }
    }

    private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (dgvInformacion.CurrentRow?.DataBoundItem is not DataRowView registro)
        {
            return;
        }

        bool tieneClave = TryGetClave(registro, out string columnaClave, out object valorClave);

        DialogResult confirmacion = MessageBox.Show(
            "¿Desea eliminar este registro?",
            "Confirmar eliminacion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
        if (confirmacion != DialogResult.Yes)
        {
            return;
        }

        using SqlCommand comando = new SqlCommand();
        if (tieneClave)
        {
            string columnaSegura = columnaClave.Replace("]", "]]");
            comando.CommandText = $"Delete From Datos Where [{columnaSegura}]=@id";
            comando.Parameters.AddWithValue("@id", valorClave);
        }
        else
        {
            object[] valoresOriginales = obtenerValores(registro);
            string filtro = CrearFiltroPorValores();
            comando.CommandText = $"IF (SELECT COUNT(*) FROM Datos WHERE {filtro}) = 1 DELETE FROM Datos WHERE {filtro}";
            AgregarParametrosOriginales(comando, valoresOriginales);
        }

        if (new Datos().ejecutar(comando))
        {
            MessageBox.Show("Registro eliminado");
            ActualizarGrid();
        }
        else
        {
            MessageBox.Show(tieneClave ? "Error al eliminar el registro" : "No se elimino el registro");
        }
    }

    private static object[] obtenerValores(DataRowView registro)
    {
        return new[]
        {
            registro["nombre"],
            registro["paterno"],
            registro["materno"],
            registro["telefono"],
            registro["correo"]
        };
    }

    private static string CrearFiltroPorValores()
    {
        string[] columnas = { "nombre", "paterno", "materno", "telefono", "correo" };
        return string.Join(" AND ", columnas.Select((columna, indice) =>
            $"([{columna}]=@original{indice} OR ([{columna}] IS NULL AND @original{indice} IS NULL))"));
    }

    private static void AgregarParametrosOriginales(SqlCommand comando, object[] valores)
    {
        for (int indice = 0; indice < valores.Length; indice++)
        {
            comando.Parameters.AddWithValue($"@original{indice}", valores[indice]);
        }
    }

    private static bool TryGetClave(DataRowView registro, out string columnaClave, out object valorClave)
    {
        DataColumn[] clavesPrimarias = registro.Row.Table.PrimaryKey;
        DataColumn? columna = clavesPrimarias.Length == 1 ? clavesPrimarias[0] : clavesPrimarias.Length == 0 ? registro.Row.Table.Columns.Cast<DataColumn>() .FirstOrDefault(c => string.Equals(c.ColumnName, "id", StringComparison.OrdinalIgnoreCase)) : null;

        if (columna == null || registro.Row.IsNull(columna))
        {
            columnaClave = string.Empty;
            valorClave = DBNull.Value;
            return false;
        }

        columnaClave = columna.ColumnName;
        valorClave = registro.Row[columna];
        return true;
    }
}
