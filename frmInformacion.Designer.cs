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
        splitContainer1 = new System.Windows.Forms.SplitContainer();
        btnCerrar = new System.Windows.Forms.Button();
        dgvInformacion = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvInformacion).BeginInit();
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
        splitContainer1.Panel2.Controls.Add(btnCerrar);
        splitContainer1.Size = new System.Drawing.Size(800, 450);
        splitContainer1.SplitterDistance = 316;
        splitContainer1.TabIndex = 0;
        splitContainer1.Text = "splitContainer1";
        // 
        // btnCerrar
        // 
        btnCerrar.Location = new System.Drawing.Point(549, 56);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Size = new System.Drawing.Size(191, 42);
        btnCerrar.TabIndex = 0;
        btnCerrar.Text = "Salir";
        btnCerrar.UseVisualStyleBackColor = true;
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
        // 
        // frmInformacion
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(splitContainer1);
        Text = "frmInformacion";
        Load += frmInformacion_Load;
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvInformacion).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnCerrar;
    private System.Windows.Forms.DataGridView dgvInformacion;

    private System.Windows.Forms.SplitContainer splitContainer1;

    #endregion
}