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
    public partial class Ficha_Anestesica : Form
    {
        public Ficha_Anestesica()
        {
            InitializeComponent();
        }

        private void Ficha_Anestesica_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            string Anestesia_Ficha = txtBox_Anestesico.Text;
            string Administracao_Anestesica_Ficha = txtBox_Administracao.Text;
            string Observacao_Ficha = txtBox_Observacao.Text;
        }
    }
}
