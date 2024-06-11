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
        public Cientista()
        {
            InitializeComponent();
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            string nome_cientista = txtBox_Nome.Text;
            string email_cientista = txtBox_Email.Text;
            string telefone_cientista = txtBox_Telefone.Text;

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
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

    }
}

