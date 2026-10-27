using System.ComponentModel;

namespace MyApp01;

partial class frmInformacion
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        splitContainer1 = new System.Windows.Forms.SplitContainer();
        dgvInformacion = new System.Windows.Forms.DataGridView();
        btnAgregar = new System.Windows.Forms.Button();
        btnCerrar = new System.Windows.Forms.Button();
        contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
        editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvInformacion).BeginInit();
        contextMenuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        splitContainer1.Location = new System.Drawing.Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(dgvInformacion);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(btnAgregar);
        splitContainer1.Panel2.Controls.Add(btnCerrar);
        splitContainer1.Size = new System.Drawing.Size(800, 450);
        splitContainer1.SplitterDistance = 316;
        splitContainer1.TabIndex = 0;
        splitContainer1.Text = "splitContainer1";
        // 
        // dgvInformacion
        // 
        dgvInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvInformacion.Location = new System.Drawing.Point(0, 0);
        dgvInformacion.Name = "dgvInformacion";
        dgvInformacion.RowHeadersWidth = 82;
        dgvInformacion.Size = new System.Drawing.Size(800, 316);
        dgvInformacion.TabIndex = 0;
        dgvInformacion.Text = "dataGridView1";
        dgvInformacion.CellMouseDown += dgvInformacion_CellMouseDown;
        // 
        // btnAgregar
        // 
        btnAgregar.Location = new System.Drawing.Point(307, 56);
        btnAgregar.Name = "btnAgregar";
        btnAgregar.Size = new System.Drawing.Size(182, 42);
        btnAgregar.TabIndex = 1;
        btnAgregar.Text = "Agregar";
        btnAgregar.UseVisualStyleBackColor = true;
        btnAgregar.Click += btnAgregar_Click;
        // 
        // btnCerrar
        // 
        btnCerrar.Location = new System.Drawing.Point(549, 56);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Size = new System.Drawing.Size(191, 42);
        btnCerrar.TabIndex = 0;
        btnCerrar.Text = "Salir";
        btnCerrar.UseVisualStyleBackColor = true;
        btnCerrar.Click += btnCerrar_Click;
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { editarToolStripMenuItem, eliminarToolStripMenuItem });
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
        // 
        // editarToolStripMenuItem
        // 
        editarToolStripMenuItem.Name = "editarToolStripMenuItem";
        editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        editarToolStripMenuItem.Text = "Editar";
        editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
        // 
        // eliminarToolStripMenuItem
        // 
        eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
        eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        eliminarToolStripMenuItem.Text = "Eliminar";
        eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
        // 
        // frmInformacion
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(splitContainer1);
        Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
        Text = "frmInformacion";
        Load += frmInformacion_Load;
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvInformacion).EndInit();
        contextMenuStrip1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;

    private System.Windows.Forms.Button btnAgregar;

    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;

    private System.Windows.Forms.Button btnCerrar;
    private System.Windows.Forms.DataGridView dgvInformacion;

    private System.Windows.Forms.SplitContainer splitContainer1;

    #endregion
}