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
    public partial class Ficha_do_Tatu : Form
    {
        public Ficha_do_Tatu()
        {
            InitializeComponent();
            text_chip.Visible = false; //Texto do chip
            txtbox_Chip.Visible = false; // Caixa de texto para colocar o número
        }

        private void check_Sim_CheckedChanged(object sender, EventArgs e)
        {
            if (text_chip.Visible == true)
            {

                text_chip.Visible = false;
                txtbox_Chip.Visible = false;

            }
            else
            {

                text_chip.Visible = true;
                txtbox_Chip.Visible = true;
            }


        }

        private void check_Não_CheckedChanged(object sender, EventArgs e)
        {
            text_chip.Visible = false;
            txtbox_Chip.Visible = false;
        }

        private void check_Sim_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void Button_Salvar_Click(object sender, EventArgs e)
        {
            string nome_Tatu = txtbox_Nome.Text;
            decimal altura_Tatu = decimal.Parse(txtbox_Altura.Text);
            decimal peso_Tatu = decimal.Parse(txtbox_Peso.Text);
            
            if(text_chip.Visible == true)
            {
                long chip_Tatu = long.Parse(txtbox_Chip.Text);
            }

            MessageBox.Show("Dados salvos com sucesso");
        }
    }
}
