using System.Media;
using NAudio.Wave;

namespace Joguin_paia;
partial class Form1 : Form
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    /// 
    Panel panelPrincipal;
    Menu menu;
    Dificuldade dificuldade;
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1600, 900);
        this.Text = "Joguin Paia";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.BackColor = Color.FromArgb(0xEB, 0x33, 0x24);
        this.ControlBox = false;

        Cursor.Hide();
        this.Cursor = new Cursor(Cursor.Current.Handle);
        DisableMouseInteraction(this);

        menu = new Menu();
        menu.FecharClick += Menu_FecharClick;
        menu.ComecarClick += Menu_ComecarClick;

        dificuldade = new Dificuldade();
        dificuldade.VoltarClick += Dificuldade_VoltarClick;

        panelPrincipal = new Panel();
        panelPrincipal.BackColor = Color.FromArgb(0xEB, 0x33, 0x24);
        panelPrincipal.Dock = DockStyle.Fill;

        Controls.Add(panelPrincipal);
        panelPrincipal.Controls.Add(menu);
        //panelPrincipal.Controls.Add(dificuldade);
    }
private void DisableMouseInteraction(Control control)
{
    foreach (Control ctrl in control.Controls)
    {
        // Desabilita a interação do mouse com o controle
        ctrl.Enabled = false;

        // Se o controle tiver subcontroles, desabilita a interação do mouse com eles também
        if (ctrl.HasChildren)
        {
            DisableMouseInteraction(ctrl);
        }
    }
}
    private void Menu_FecharClick(object sender, EventArgs e)
    {
        Cursor.Show();
        this.Close();
    }
    private void Menu_ComecarClick(object sender, EventArgs e)
    {
        panelPrincipal.Controls.Clear();
        panelPrincipal.Controls.Add(dificuldade);
    }

    private void Dificuldade_VoltarClick(object sender, EventArgs e)
    {
        panelPrincipal.Controls.Clear();
        panelPrincipal.Controls.Add(menu);
    }
    #endregion
}