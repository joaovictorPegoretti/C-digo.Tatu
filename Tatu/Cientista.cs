using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tatu
{
    public partial class Cientista : Form
    {
        Thread f1;
        public Cientista()
        {
            InitializeComponent();
            groupBox_Aviso_Salvo.Visible = false;
            groupBox_Aviso_Cancelar.Visible = false;
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            string nome_cientista = txtBox_Nome.Text;
            string email_cientista = txtBox_Email.Text;
            string telefone_cientista = txtBox_Telefone.Text;

            if (groupBox_Aviso_Salvo.Visible == true)
            {
                groupBox_Aviso_Salvo.Visible = false;
            }
            else
            {
                groupBox_Aviso_Salvo.Location = new Point(315, 178);
                groupBox_Aviso_Salvo.Visible = true;
            }

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            if (groupBox_Aviso_Cancelar.Visible == true)
            {
                groupBox_Aviso_Cancelar.Visible = false;
            }
            else
            {
                groupBox_Aviso_Cancelar.Visible = true;
            }
        }

        private void button_Sim_Click(object sender, EventArgs e)
        {

        }

        private void buttonBox_Sim_Click(object sender, EventArgs e)
        {
            this.Close();
            f1 = new Thread(Abrir_Menu!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Remove(groupBox_Aviso_Salvo);
            this.Close();
            f1 = new Thread(Abrir_Menu!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        }

        private void buttonBox_Cancelar_Click(object sender, EventArgs e)
        {
            Controls.Remove(groupBox_Aviso_Cancelar);
            ClearControl(this);
        }

        public static void ClearControl(Control ctrl) // Função para limpar os itens 
        {
            foreach (Control c in ctrl.Controls) // um foreach para pegar todo o valor escrito no item
            {
                if (c is TextBox)  // aqui você coloca a variavel do foreach e coloca o item que tem no formulário

                    ((TextBox)c).Text = ""; // Aqui ele faz o item ficar com isso
            }
        }

        private void Abrir_Menu(object obj)
        {
            Application.Run(new Menu());
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

