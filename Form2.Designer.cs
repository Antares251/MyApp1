using System.ComponentModel;

namespace MyApp01;

partial class Form2
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
        txtNombre = new System.Windows.Forms.TextBox();
        txtCorreo = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        btnActualizar = new System.Windows.Forms.Button();
        btnSalir = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // txtNombre
        // 
        txtNombre.Location = new System.Drawing.Point(39, 50);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new System.Drawing.Size(213, 23);
        txtNombre.TabIndex = 0;
        // 
        // txtCorreo
        // 
        txtCorreo.Location = new System.Drawing.Point(39, 99);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.Size = new System.Drawing.Size(213, 23);
        txtCorreo.TabIndex = 1;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(43, 36);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(86, 14);
        label1.TabIndex = 2;
        label1.Text = "Nombre";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(39, 82);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(86, 14);
        label2.TabIndex = 3;
        label2.Text = "Correo";
        // 
        // btnActualizar
        // 
        btnActualizar.Location = new System.Drawing.Point(322, 52);
        btnActualizar.Name = "btnActualizar";
        btnActualizar.Size = new System.Drawing.Size(139, 20);
        btnActualizar.TabIndex = 4;
        btnActualizar.Text = "Actualizar";
        btnActualizar.UseVisualStyleBackColor = true;
        // 
        // btnSalir
        // 
        btnSalir.Location = new System.Drawing.Point(322, 99);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new System.Drawing.Size(139, 20);
        btnSalir.TabIndex = 5;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = true;
        btnSalir.Click += btnSalir_Click;
        // 
        // Form2
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(493, 154);
        Controls.Add(btnSalir);
        Controls.Add(btnActualizar);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtCorreo);
        Controls.Add(txtNombre);
        Text = "Form2";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnSalir;

    private System.Windows.Forms.Button btnActualizar;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.TextBox txtCorreo;

    #endregion
}