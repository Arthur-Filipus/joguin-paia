using System;
using System.Windows.Forms;
using NAudio.Wave;

namespace Joguin_paia;
public partial class Menu : UserControl
{
    Button btnComecar;
    Button btnMusica;
    Button btnCreditos;
    Button btnFechar;
    PictureBox mainImage;
    ImageList imageList;
    IWavePlayer player;
    AudioFileReader musica;
    bool isMuted = false;
    
    public Menu()
    {
        InitializeComponent();
    }
    public event EventHandler FecharClick;
    public event EventHandler ComecarClick;
    private void InitializeComponent()
    {
        this.Size = new Size(1600, 900);
        
        mainImage = new PictureBox();
        mainImage.Location = new Point(500, 100);
        mainImage.Size = new Size(600, 390);
        mainImage.SizeMode = PictureBoxSizeMode.StretchImage;
        mainImage.Image = Image.FromFile("Imagens/MainMenu.png");

        imageList = new ImageList();
        imageList.Images.Add("musicOn", Image.FromFile("Imagens/musicOn.png"));
        imageList.Images.Add("musicOff", Image.FromFile("Imagens/musicOff.png"));

        player = new WaveOut();
        musica = new AudioFileReader("Musicas/chingCheng.mp3");
        player.Init(musica);
        player.Play();

        btnMusica = new Button();
        btnMusica.Location = new Point(1550, 10);
        btnMusica.Size = new Size(40, 40);
        btnMusica.ImageList = imageList;
        btnMusica.ImageKey = "musicOn";
        btnMusica.BackgroundImageLayout = ImageLayout.Stretch;
        btnMusica.BackColor = Color.FromArgb(0, 255, 0);
        btnMusica.FlatStyle = FlatStyle.Popup;
        btnMusica.Click += btnMusica_Click;

        btnComecar = new Button();
        btnComecar.Location = new Point(700, 500);
        btnComecar.Size = new Size(200, 70);
        btnComecar.Text = "Começar";
        btnComecar.BackColor = Color.FromArgb(0, 255, 0);
        btnComecar.FlatStyle = FlatStyle.Popup;
        btnComecar.Click += btnComecar_Click;

        btnCreditos = new Button();
        btnCreditos.Location = new Point(700, 580);
        btnCreditos.Size = new Size(200, 70);
        btnCreditos.Text = "Créditos";
        btnCreditos.BackColor = Color.FromArgb(0, 255, 0);
        btnCreditos.FlatStyle = FlatStyle.Popup;
        btnCreditos.Click += btnCreditos_Click;

        btnFechar = new Button();
        btnFechar.Location = new Point(700, 660);
        btnFechar.Size = new Size(200, 70);
        btnFechar.Text = "Fechar";
        btnFechar.BackColor = Color.FromArgb(0, 255, 0);
        btnFechar.FlatStyle = FlatStyle.Popup;
        btnFechar.Click += btnFechar_Click;

        Controls.Add(btnComecar);
        Controls.Add(btnCreditos);
        Controls.Add(btnMusica);
        Controls.Add(btnFechar);
        Controls.Add(mainImage);
    }
    private void btnComecar_Click(object sender, EventArgs e)
    {

        ComecarClick?.Invoke(this, EventArgs.Empty);
    }
    private void btnMusica_Click(object sender, EventArgs e)
    {
        isMuted = !isMuted;
        if (isMuted)
            {
                btnMusica.ImageKey = "musicOff";
                musica.Volume = 0;
            }
            else
            {
                btnMusica.ImageKey = "musicOn";
                musica.Volume = 1;
            }
    }
    private void btnCreditos_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Arthur Leonardo Filipus :D", "Créditos");
    }
    private void btnFechar_Click(object sender, EventArgs e)
    {
        player.Stop();
        player.Dispose();
        musica.Dispose();

        FecharClick?.Invoke(this, EventArgs.Empty);
    }
}