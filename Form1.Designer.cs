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
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1, agendaToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(463, 42);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { agregarToolStripMenuItem, salirToolStripMenuItem });
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new System.Drawing.Size(97, 38);
        toolStripMenuItem1.Text = "Menu";
        // 
        // agregarToolStripMenuItem
        // 
        agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
        agregarToolStripMenuItem.Size = new System.Drawing.Size(231, 44);
        agregarToolStripMenuItem.Text = "Agregar";
        agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
        // 
        // salirToolStripMenuItem
        // 
        salirToolStripMenuItem.Name = "salirToolStripMenuItem";
        salirToolStripMenuItem.Size = new System.Drawing.Size(231, 44);
        salirToolStripMenuItem.Text = "Salir";
        // 
        // agendaToolStripMenuItem
        // 
        agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { informacionToolStripMenuItem });
        agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
        agendaToolStripMenuItem.Size = new System.Drawing.Size(116, 38);
        agendaToolStripMenuItem.Text = "Agenda";
        // 
        // informacionToolStripMenuItem
        // 
        informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
        informacionToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
        informacionToolStripMenuItem.Text = "Informacion";
        informacionToolStripMenuItem.Click += informacionToolStripMenuItem_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(463, 324);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Text = "Form1";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;

    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion
}