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
            groupBox_Aviso_Proximo.Visible = false;
            groupBox_Aviso_Salvo.Visible = false;
            groupBox_Aviso_Cancelar.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Box_Sim_Click(object sender, EventArgs e)
        {
            this.Close();
            f1 = new Thread(Abrir_Ficha_Tatu!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        }

        private void button_Box_Não_Click(object sender, EventArgs e)
        {
            this.Close();
            f1 = new Thread(Abrir_Menu!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        }
        
        private void button_Proximo_Click(object sender, EventArgs e)
        {
            if (groupBox_Aviso_Proximo.Visible == true)
            {

                groupBox_Aviso_Proximo.Visible = false;
                groupBox_Aviso_Proximo.Visible = false;

            }
            else
            {
                groupBox_Aviso_Proximo.Location = new Point(315, 178);
                groupBox_Aviso_Proximo.Visible = true;
                groupBox_Aviso_Proximo.Visible = true;

            }
            string Local_Captura = txtbox_Local.Text;
            DateTime Data_Captura = Convert.ToDateTime(txtbox_Data.Text);
            DateTime Horario_Captura = Convert.ToDateTime(txtbox_Horario.Text);
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            string Local_Captura = txtbox_Local.Text;
            DateTime Data_Captura = Convert.ToDateTime(txtbox_Data.Text);
            DateTime Horario_Captura = Convert.ToDateTime(txtbox_Horario.Text);

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
        
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            if (groupBox_Aviso_Cancelar.Visible == true)
            {
                groupBox_Aviso_Cancelar.Visible = false;
            }
            else
            {
                groupBox_Aviso_Cancelar.Location = new Point(315, 178);
                groupBox_Aviso_Cancelar.Visible = true;
            }
        }

        private void Captura_Load(object sender, EventArgs e)
        {

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Controls.Remove(groupBox_Aviso_Salvo);
        }

       

        private void buttonBox_Sim_Click(object sender, EventArgs e)
        {
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

        // Métodos

        public static void ClearControl(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = ""; // Limpa o textbox
                }
            }
        }
        
        private void Abrir_Ficha_Tatu(object obj)
        {
            Application.Run(new Ficha_do_Tatu());
        }

        private void Abrir_Menu(object obj)
        {
            Application.Run(new Menu());
        }
    }
}

