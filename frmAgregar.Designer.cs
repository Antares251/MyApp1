using System.ComponentModel;

namespace MyApp01;

partial class frmAgregar
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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        txtNombre = new System.Windows.Forms.TextBox();
        txtApPaterno = new System.Windows.Forms.TextBox();
        txtApMaterno = new System.Windows.Forms.TextBox();
        txtTelefono = new System.Windows.Forms.TextBox();
        txtCorreo = new System.Windows.Forms.TextBox();
        btnAgregar = new System.Windows.Forms.Button();
        btnCerrar = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(18, 20);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(110, 38);
        label1.TabIndex = 0;
        label1.Text = "Nombre";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(18, 96);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(134, 38);
        label2.TabIndex = 1;
        label2.Text = "Ap.Paterno";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(18, 172);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(154, 38);
        label3.TabIndex = 2;
        label3.Text = "Ap. Materno";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(18, 247);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(154, 38);
        label4.TabIndex = 3;
        label4.Text = "Telefono";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(18, 327);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(154, 38);
        label5.TabIndex = 4;
        label5.Text = "Correo";
        // 
        // txtNombre
        // 
        txtNombre.Location = new System.Drawing.Point(18, 54);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new System.Drawing.Size(360, 39);
        txtNombre.TabIndex = 5;
        // 
        // txtApPaterno
        // 
        txtApPaterno.Location = new System.Drawing.Point(18, 130);
        txtApPaterno.Name = "txtApPaterno";
        txtApPaterno.Size = new System.Drawing.Size(360, 39);
        txtApPaterno.TabIndex = 6;
        // 
        // txtApMaterno
        // 
        txtApMaterno.Location = new System.Drawing.Point(18, 205);
        txtApMaterno.Name = "txtApMaterno";
        txtApMaterno.Size = new System.Drawing.Size(360, 39);
        txtApMaterno.TabIndex = 7;
        // 
        // txtTelefono
        // 
        txtTelefono.Location = new System.Drawing.Point(18, 285);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.Size = new System.Drawing.Size(360, 39);
        txtTelefono.TabIndex = 8;
        // 
        // txtCorreo
        // 
        txtCorreo.Location = new System.Drawing.Point(18, 368);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.Size = new System.Drawing.Size(360, 39);
        txtCorreo.TabIndex = 9;
        // 
        // btnAgregar
        // 
        btnAgregar.Location = new System.Drawing.Point(18, 450);
        btnAgregar.Name = "btnAgregar";
        btnAgregar.Size = new System.Drawing.Size(158, 59);
        btnAgregar.TabIndex = 10;
        btnAgregar.Text = "Agregar";
        btnAgregar.UseVisualStyleBackColor = true;
        btnAgregar.Click += btnAgregar_Click;
        // 
        // btnCerrar
        // 
        btnCerrar.Location = new System.Drawing.Point(220, 450);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Size = new System.Drawing.Size(158, 59);
        btnCerrar.TabIndex = 11;
        btnCerrar.Text = "Cerrar";
        btnCerrar.UseVisualStyleBackColor = true;
        // 
        // frmAgregar
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(396, 539);
        Controls.Add(btnCerrar);
        Controls.Add(btnAgregar);
        Controls.Add(txtCorreo);
        Controls.Add(txtTelefono);
        Controls.Add(txtApMaterno);
        Controls.Add(txtApPaterno);
        Controls.Add(txtNombre);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "Agregar";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.TextBox txtApPaterno;
    private System.Windows.Forms.TextBox txtApMaterno;
    private System.Windows.Forms.TextBox txtTelefono;
    private System.Windows.Forms.TextBox txtCorreo;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Button btnCerrar;

    #endregion
}