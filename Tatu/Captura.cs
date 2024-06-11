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
    public partial class Captura : Form
    {
        Thread f1;
        public Captura()
        {
            InitializeComponent();
            groupBox_Aviso.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Box_Sim_Click(object sender, EventArgs e)
        {
            string Local_Captura = txtbox_Local.Text;
            DateTime Data_Captura = Convert.ToDateTime(txtbox_Data.Text);
            DateTime Horario_Captura = Convert.ToDateTime(txtbox_Horario.Text);


            this.Close();
            f1 = new Thread(Abrir_Ficha_Tatu!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        }
        private void button_Box_Não_Click(object sender, EventArgs e)
        {

            string Local_Captura = txtbox_Local.Text;
            DateOnly Data_Captura = DateOnly.Parse(txtbox_Data.Text);
            TimeOnly Horario_Captura = TimeOnly.Parse(txtbox_Horario.Text);


            this.Close();
            f1 = new Thread(Abrir_Menu!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();

        }
        // Métodos
        private void Abrir_Ficha_Tatu(object obj)
        {
            Application.Run(new Ficha_do_Tatu());
        }

        private void Abrir_Menu(object obj)
        {
            Application.Run(new Menu());
        }

        private void button_Proximo_Click(object sender, EventArgs e)
        {
            if (groupBox_Aviso.Visible == true)
            {

                groupBox_Aviso.Visible = false;
                groupBox_Aviso.Visible = false;

            }
            else
            {

                groupBox_Aviso.Visible = true;
                groupBox_Aviso.Visible = true;
            }
        }
    }    
}

