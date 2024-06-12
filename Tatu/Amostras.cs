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
        Thread f1;
        public Amostras()
        {
            InitializeComponent();
            groupBox_Aviso_Salvo.Visible = false;
            groupBox_Aviso_Proximo.Visible = false;
            groupBox_Aviso_Cancelar.Visible = false;
        }

        private void Amostras_Load(object sender, EventArgs e)
        {

        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            bool Sangue_Amostras = checkBox_Sangue.Checked;
            bool Fezes_Amostras = checkBox_Fezes.Checked;
            bool Pelo_Amostras = checkBox_Pelo.Checked;
            bool Ectoparasitos_Amostras = checkBox_Ectoparasitos.Checked;
            bool Sawb_Amostras = checkBox_Sawb.Checked;
            string Local_Amostras = txtBox_Local.Text;
            string Outros_Amostras = txtBox_Outros.Text;

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        } // Sumiu

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button_Sim_Click(object sender, EventArgs e)
        {
            Controls.Remove(groupBox_Aviso_Proximo);

            this.Close();
            f1 = new Thread(Abrir_Biometria!);
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

        private void butto_Cancelar_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
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
        
        private void Abrir_Biometria(object obj)
        {
            Application.Run(new Biometria());
        }

        private void Abrir_Menu(object obj)
        {
            Application.Run(new Menu());
        }
    }
}
