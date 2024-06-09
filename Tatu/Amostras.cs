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
    public partial class Amostras : Form
    {
        public Amostras()
        {
            InitializeComponent();
        }

        private void Amostras_Load(object sender, EventArgs e)
        {

        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            bool Sangue_Amostras = checkBox_Sangue.Checked;
            bool Fezes_Amostras = checkBox_Fezes.Checked;
            bool Pelo_Amostras = checkBox_Pelo.Checked;
            bool Ectoparasitos_Amostras = checkBox_Ectoparasitos.Checked; ;
            bool Sawb_Amostras = checkBox_Sawb.Checked;
            string Local_Amostras = txtBox_Local.Text;
            string Outros_Amostras = txtBox_Outros.Text;
        }
    }
}
