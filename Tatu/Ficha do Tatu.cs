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
        Thread f1;
        public Ficha_do_Tatu()
        {
            InitializeComponent();
            text_chip.Visible = false; //Texto do chip
            txtbox_Chip.Visible = false; // Caixa de texto para colocar o número
            groupBox_Aviso_Cancelar.Visible = false;
            groupBox_Aviso_Proximo.Visible = false;
            groupBox_Aviso_Salvo.Visible = false;
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

        }//Ignora

        private void Button_Salvar_Click(object sender, EventArgs e)
        {
            string nome_Tatu = txtbox_Nome.Text;
            decimal altura_Tatu = decimal.Parse(txtbox_Altura.Text);
            decimal peso_Tatu = decimal.Parse(txtbox_Peso.Text);

            if (text_chip.Visible == true)
            {
                long chip_Tatu = long.Parse(txtbox_Chip.Text);
            }

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

        private void Button_Cancelar_Click(object sender, EventArgs e)
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

        private void button_Sim_Click(object sender, EventArgs e)
        {
            Controls.Remove(groupBox_Aviso_Proximo);

            this.Close();
            f1 = new Thread(Abrir_Ficha_Anestesica!);
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
            Controls.Remove(groupBox_Aviso_Cancelar);
            ClearControl(this);
        }

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

        private void Abrir_Ficha_Anestesica(object obj)
        {
            Application.Run(new Ficha_Anestesica());
        }

        private void Abrir_Menu(object obj)
        {
            Application.Run(new Menu());
        }
    }
}
