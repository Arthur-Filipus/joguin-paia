using System;
using System.Windows.Forms;

namespace Joguin_paia;
public partial class Dificuldade : UserControl
{
    Button btnVoltar;
    Button btnFacil;
    Button btnMedio;
    Button btnDificil;
    public Dificuldade()
    {
        InitializeComponent();
    }
    public event EventHandler VoltarClick;
    private void InitializeComponent()
    {
        this.Size = new Size(1600, 900);

        btnFacil = new Button();
        btnFacil.Location = new Point(700, 420);
        btnFacil.Size = new Size(200, 70);
        btnFacil.Text = "Facil";
        btnFacil.BackColor = Color.FromArgb(0, 255, 0);
        btnFacil.FlatStyle = FlatStyle.Popup;
        btnFacil.Click += btnFacil_Click;

        btnMedio = new Button();
        btnMedio.Location = new Point(700, 500);
        btnMedio.Size = new Size(200, 70);
        btnMedio.Text = "Medio";
        btnMedio.BackColor = Color.FromArgb(0, 255, 0);
        btnMedio.FlatStyle = FlatStyle.Popup;
        btnMedio.Click += btnMedio_Click;

        btnDificil = new Button();
        btnDificil.Location = new Point(700, 580);
        btnDificil.Size = new Size(200, 70);
        btnDificil.Text = "Dificil";
        btnDificil.BackColor = Color.FromArgb(0, 255, 0);
        btnDificil.FlatStyle = FlatStyle.Popup;
        btnDificil.Click += btnDificil_Click;

        btnVoltar = new Button();
        btnVoltar.Location = new Point(700, 660);
        btnVoltar.Size = new Size(200, 70);
        btnVoltar.Text = "Voltar";
        btnVoltar.BackColor = Color.FromArgb(0, 255, 0);
        btnVoltar.FlatStyle = FlatStyle.Popup;
        btnVoltar.Click += btnVoltar_Click;

        Controls.Add(btnVoltar);
        Controls.Add(btnFacil);
        Controls.Add(btnMedio);
        Controls.Add(btnDificil);
    }
    public void btnVoltar_Click(object sender, EventArgs e)
    {
        VoltarClick?.Invoke(this, EventArgs.Empty);
    }
    public void btnFacil_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Facil");
    }
    public void btnMedio_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Medio");
    }
    public void btnDificil_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Dificil");
    }
}