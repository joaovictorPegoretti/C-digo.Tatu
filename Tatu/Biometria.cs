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
    public partial class Biometria : Form
    {
        Thread f1;
        public Biometria()
        {
            InitializeComponent();
            groupBox_Aviso.Visible = false;
        }

        private void button_Salvar_Click_1(object sender, EventArgs e)
        {

            string identificacao_biometria = comboBox_Identificacao.Text;
            string nome_biometria = comboBox_Nome.Text;
            string tipo_biometria = comboBox_Tipo.Text;
        }

        private void button_Cancelar_Click_1(object sender, EventArgs e)
        {
            if (groupBox_Aviso.Visible == false)
            {
                groupBox_Aviso.Visible = true;
            }

            else
            {
                groupBox_Aviso.Visible = false;
            }
            ClearControl(this); //Aqui você chama a função usando o this que se refere ao proprio formulario que ele está
        }


        public static void ClearControl(Control ctrl) // Função para limpar os itens 
        {
            foreach (Control c in ctrl.Controls) // um foreach para pegar todo o valor escrito no item
            {
                if (c is ComboBox)  // aqui você coloca a variavel do foreach e coloca o item que tem no formulário
                {
                    ((ComboBox)c).Text = ""; // Aqui ele faz o item ficar com isso
                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonBox_Sim_Click(object sender, EventArgs e)
        {

            ClearControl(this); //Aqui você chama a função usando o this que se refere ao proprio formulario que ele está

            this.Close();
            f1 = new Thread(Abrir_Menu!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();

        } 
        private void buttonBox_Cancelar_Click(object sender, EventArgs e)
        {
            ClearControl(this); //Aqui você chama a função usando o this que se refere ao proprio formulario que ele está
        }

        private void Abrir_Menu(Object obj)
        {
            Application.Run(new Menu());
        }

       
    }
}
