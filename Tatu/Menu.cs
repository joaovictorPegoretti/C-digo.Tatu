using System.Threading;

namespace Tatu
{
    public partial class Menu : Form
    {
        Thread f1;
        public Menu()
        {
            InitializeComponent();

        }

        private void Ficha_Campo_Click(object sender, EventArgs e)
        {
            this.Close();
            f1 = new Thread(Abrir_Ficha_Tatu!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        }

        private void capturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            f1 = new Thread(Abrir_Captura!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        }
        private void fichaAnestesicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            f1 = new Thread(Abrir_Ficha_Anestesica!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();

        }
        private void amostrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            f1 = new Thread(Abrir_Amostras!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        }

        private void biometriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            f1 = new Thread(Abrir_Biometria!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        } 
        private void equipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            f1 = new Thread(Abrir_Equipe!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        }
        
        private void cientistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            f1 = new Thread(Abrir_Cientista!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        }

        //M�todos

        private void Abrir_Ficha_Tatu(object obj)
        {
            Application.Run(new Ficha_do_Tatu());
        }

        private void Abrir_Captura(object obj)
        {
            Application.Run(new Captura());
        }

        private void Abrir_Ficha_Anestesica(object obj)
        {
            Application.Run(new Ficha_Anestesica());
        }

        private void Abrir_Amostras(object obj)
        {
            Application.Run();
        }

        private void Abrir_Biometria(object obj)
        {
            Application.Run(new Biometria());
        }

        private void Abrir_Equipe(object obj)
        {
            Application.Run(new Equipe());
        }

        private void Abrir_Cientista(object obj)
        {
            Application.Run(new Cientista());
        }

        

       
    }
}
