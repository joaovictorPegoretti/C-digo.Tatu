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
        Thread f1;
        public Ficha_Anestesica()
        {
            InitializeComponent();
            groupBox_Aviso_Salvo.Visible = false;
            groupBox_Aviso_Proximo.Visible = false;
            groupBox_Aviso_Cancelar.Visible = false;
        }

        private void Ficha_Anestesica_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        } // Ignora

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            string Anestesia_Ficha = txtBox_Anestesico.Text;
            string Administracao_Anestesica_Ficha = txtBox_Administracao.Text;
            string Observacao_Ficha = txtBox_Observacao.Text;

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
                groupBox_Aviso_Cancelar.Location = new Point(315, 178);
                groupBox_Aviso_Cancelar.Visible = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        } // Ignora

        private void button_Sim_Click(object sender, EventArgs e)
        {
            Controls.Remove(groupBox_Aviso_Proximo);

            this.Close();
            f1 = new Thread(Abrir_Amostras!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        }

        private void button_Não_Click(object sender, EventArgs e)
        {
            Controls.Remove(groupBox_Aviso_Proximo);

            this.Close();
            f1 = new Thread(Abrir_Menu!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        }

        private void buttonBox_Sim_Click(object sender, EventArgs e)
        {
            Controls.Remove(groupBox_Aviso_Cancelar);
            this.Close();
            f1 = new Thread(Abrir_Menu!);
            f1.SetApartmentState(ApartmentState.STA);
            f1.Start();
        }

        private void buttonBox_Cancelar_Click(object sender, EventArgs e)
        {
            Controls.Remove(this);
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Controls.Remove(groupBox_Aviso_Salvo);
            if (groupBox_Aviso_Proximo.Visible == true)
            {
                groupBox_Aviso_Proximo.Visible = false;
            }
            else
            {
                groupBox_Aviso_Proximo.Location = new Point(315, 178);
                groupBox_Aviso_Proximo.Visible = true;
            }

        }

        // Métodos

        public static void ClearControl(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false; // Limpa os checkbox
                }

                else if (c is TextBox)
                {
                    ((TextBox)c).Text = ""; // Limpa o textbox
                }
            }
        }

        private void Abrir_Amostras(object obj)
        {
            Application.Run(new Amostras());
        }

        private void Abrir_Menu(object obj)
        {
            Application.Run(new Menu());
        }

       
    }
}
