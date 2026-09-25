namespace MyApp01;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        btnCargar = new System.Windows.Forms.Button();
        dgvRegistros = new System.Windows.Forms.DataGridView();
        Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column4 = new System.Windows.Forms.DataGridViewImageColumn();
        Column5 = new System.Windows.Forms.DataGridViewImageColumn();
        ofdCSV = new System.Windows.Forms.OpenFileDialog();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
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
        splitContainer1.Panel1.Controls.Add(btnCargar);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(dgvRegistros);
        splitContainer1.Size = new System.Drawing.Size(529, 458);
        splitContainer1.SplitterDistance = 98;
        splitContainer1.TabIndex = 0;
        splitContainer1.Text = "splitContainer1";
        // 
        // btnCargar
        // 
        btnCargar.Location = new System.Drawing.Point(32, 24);
        btnCargar.Name = "btnCargar";
        btnCargar.Size = new System.Drawing.Size(136, 39);
        btnCargar.TabIndex = 0;
        btnCargar.Text = "Cragar";
        btnCargar.UseVisualStyleBackColor = true;
        btnCargar.Click += btnCargar_Click;
        // 
        // dgvRegistros
        // 
        dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
        dgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvRegistros.Location = new System.Drawing.Point(0, 0);
        dgvRegistros.Name = "dgvRegistros";
        dgvRegistros.RowHeadersWidth = 51;
        dgvRegistros.Size = new System.Drawing.Size(529, 356);
        dgvRegistros.TabIndex = 0;
        dgvRegistros.Text = "dataGridView1";
        dgvRegistros.CellContentClick += dgvRegistros_CellContentClick;
        // 
        // Column1
        // 
        Column1.HeaderText = "id";
        Column1.MinimumWidth = 6;
        Column1.Name = "Column1";
        Column1.Width = 25;
        // 
        // Column2
        // 
        Column2.HeaderText = "Nombre";
        Column2.MinimumWidth = 6;
        Column2.Name = "Column2";
        Column2.Width = 150;
        // 
        // Column3
        // 
        Column3.HeaderText = "Correo";
        Column3.MinimumWidth = 6;
        Column3.Name = "Column3";
        Column3.Width = 200;
        // 
        // Column4
        // 
        Column4.HeaderText = "";
        Column4.MinimumWidth = 6;
        Column4.Name = "Column4";
        Column4.Width = 50;
        // 
        // Column5
        // 
        Column5.HeaderText = "";
        Column5.MinimumWidth = 6;
        Column5.Name = "Column5";
        Column5.Width = 50;
        // 
        // ofdCSV
        // 
        ofdCSV.FileName = "openFileDialog1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(529, 458);
        Controls.Add(splitContainer1);
        Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        Text = "Form1";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.OpenFileDialog ofdCSV;

    private System.Windows.Forms.Button btnCargar;

    private System.Windows.Forms.DataGridViewImageColumn Column4;
    private System.Windows.Forms.DataGridViewImageColumn Column5;

    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;

    private System.Windows.Forms.DataGridView dgvRegistros;

    private System.Windows.Forms.SplitContainer splitContainer1;

    #endregion
}