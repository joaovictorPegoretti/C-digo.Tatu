namespace Tatu
{
    partial class Cientista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtBox_Nome = new TextBox();
            txtBox_Email = new TextBox();
            label2 = new Label();
            txtBox_Telefone = new TextBox();
            label3 = new Label();
            button_Salvar = new Button();
            button_Cancelar = new Button();
            label4 = new Label();
            groupBox_Aviso_Salvo = new GroupBox();
            button_ok = new Button();
            label5 = new Label();
            groupBox_Aviso_Cancelar = new GroupBox();
            buttonBox_Cancelar = new Button();
            buttonBox_Sim = new Button();
            label11 = new Label();
            groupBox_Aviso_Salvo.SuspendLayout();
            groupBox_Aviso_Cancelar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 94);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtBox_Nome
            // 
            txtBox_Nome.Location = new Point(86, 90);
            txtBox_Nome.Name = "txtBox_Nome";
            txtBox_Nome.Size = new Size(234, 23);
            txtBox_Nome.TabIndex = 1;
            // 
            // txtBox_Email
            // 
            txtBox_Email.Location = new Point(86, 153);
            txtBox_Email.Name = "txtBox_Email";
            txtBox_Email.Size = new Size(234, 23);
            txtBox_Email.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 157);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // txtBox_Telefone
            // 
            txtBox_Telefone.Location = new Point(97, 219);
            txtBox_Telefone.Name = "txtBox_Telefone";
            txtBox_Telefone.Size = new Size(234, 23);
            txtBox_Telefone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 222);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefone:";
            // 
            // button_Salvar
            // 
            button_Salvar.Location = new Point(694, 415);
            button_Salvar.Name = "button_Salvar";
            button_Salvar.Size = new Size(75, 23);
            button_Salvar.TabIndex = 13;
            button_Salvar.Text = "Salvar";
            button_Salvar.UseVisualStyleBackColor = true;
            button_Salvar.Click += button_Salvar_Click;
            // 
            // button_Cancelar
            // 
            button_Cancelar.Location = new Point(600, 415);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(75, 23);
            button_Cancelar.TabIndex = 12;
            button_Cancelar.Text = "Cancelar";
            button_Cancelar.UseVisualStyleBackColor = true;
            button_Cancelar.Click += button_Cancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(37, 21);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 14;
            label4.Text = "Cientista";
            // 
            // groupBox_Aviso_Salvo
            // 
            groupBox_Aviso_Salvo.BackColor = SystemColors.ButtonHighlight;
            groupBox_Aviso_Salvo.Controls.Add(button_ok);
            groupBox_Aviso_Salvo.Controls.Add(label5);
            groupBox_Aviso_Salvo.Location = new Point(550, 59);
            groupBox_Aviso_Salvo.Name = "groupBox_Aviso_Salvo";
            groupBox_Aviso_Salvo.Size = new Size(200, 100);
            groupBox_Aviso_Salvo.TabIndex = 15;
            groupBox_Aviso_Salvo.TabStop = false;
            groupBox_Aviso_Salvo.Text = "Aviso";
            // 
            // button_ok
            // 
            button_ok.Location = new Point(119, 71);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(75, 23);
            button_ok.TabIndex = 1;
            button_ok.Text = "Ok";
            button_ok.UseVisualStyleBackColor = true;
            button_ok.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 35);
            label5.Name = "label5";
            label5.Size = new Size(149, 15);
            label5.TabIndex = 0;
            label5.Text = "Dados salvos com sucesso!";
            // 
            // groupBox_Aviso_Cancelar
            // 
            groupBox_Aviso_Cancelar.BackColor = SystemColors.ButtonHighlight;
            groupBox_Aviso_Cancelar.Controls.Add(buttonBox_Cancelar);
            groupBox_Aviso_Cancelar.Controls.Add(buttonBox_Sim);
            groupBox_Aviso_Cancelar.Controls.Add(label11);
            groupBox_Aviso_Cancelar.Font = new Font("Segoe UI", 9F);
            groupBox_Aviso_Cancelar.Location = new Point(550, 184);
            groupBox_Aviso_Cancelar.Name = "groupBox_Aviso_Cancelar";
            groupBox_Aviso_Cancelar.Size = new Size(235, 109);
            groupBox_Aviso_Cancelar.TabIndex = 24;
            groupBox_Aviso_Cancelar.TabStop = false;
            groupBox_Aviso_Cancelar.Text = "Aviso";
            // 
            // buttonBox_Cancelar
            // 
            buttonBox_Cancelar.Location = new Point(20, 79);
            buttonBox_Cancelar.Name = "buttonBox_Cancelar";
            buttonBox_Cancelar.Size = new Size(128, 23);
            buttonBox_Cancelar.TabIndex = 3;
            buttonBox_Cancelar.Text = "Cancelar o Cientista";
            buttonBox_Cancelar.UseVisualStyleBackColor = true;
            buttonBox_Cancelar.Click += buttonBox_Cancelar_Click;
            // 
            // buttonBox_Sim
            // 
            buttonBox_Sim.Location = new Point(154, 79);
            buttonBox_Sim.Name = "buttonBox_Sim";
            buttonBox_Sim.Size = new Size(75, 23);
            buttonBox_Sim.TabIndex = 1;
            buttonBox_Sim.Text = "Sim";
            buttonBox_Sim.UseVisualStyleBackColor = true;
            buttonBox_Sim.Click += buttonBox_Sim_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 36);
            label11.Name = "label11";
            label11.Size = new Size(217, 30);
            label11.TabIndex = 0;
            label11.Text = "Você deseja cancelar o cientista e voltar \r\npara o menu?";
            label11.Click += label11_Click;
            // 
            // Cientista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox_Aviso_Cancelar);
            Controls.Add(groupBox_Aviso_Salvo);
            Controls.Add(label4);
            Controls.Add(button_Salvar);
            Controls.Add(button_Cancelar);
            Controls.Add(txtBox_Telefone);
            Controls.Add(label3);
            Controls.Add(txtBox_Email);
            Controls.Add(label2);
            Controls.Add(txtBox_Nome);
            Controls.Add(label1);
            Name = "Cientista";
            Text = "Cientista";
            groupBox_Aviso_Salvo.ResumeLayout(false);
            groupBox_Aviso_Salvo.PerformLayout();
            groupBox_Aviso_Cancelar.ResumeLayout(false);
            groupBox_Aviso_Cancelar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBox_Nome;
        private TextBox txtBox_Email;
        private Label label2;
        private TextBox txtBox_Telefone;
        private Label label3;
        private Button button_Salvar;
        private Button button_Cancelar;
        private Label label4;
        private GroupBox groupBox_Aviso_Salvo;
        private Button button_ok;
        private Label label5;
        private GroupBox groupBox_Aviso_Cancelar;
        private Button buttonBox_Cancelar;
        private Button buttonBox_Sim;
        private Label label11;
    }
}