namespace Tatu
{
    partial class Biometria
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
            label2 = new Label();
            comboBox_Identificacao = new ComboBox();
            label3 = new Label();
            comboBox_Tipo = new ComboBox();
            label4 = new Label();
            comboBox_Nome = new ComboBox();
            button_Salvar = new Button();
            button_Cancelar = new Button();
            groupBox_Aviso_Cancelar = new GroupBox();
            buttonBox_Cancelar = new Button();
            buttonBox_Sim = new Button();
            label5 = new Label();
            groupBox_Aviso_Proximo = new GroupBox();
            button_Não = new Button();
            button_Sim = new Button();
            label10 = new Label();
            groupBox_Aviso_Salvo = new GroupBox();
            button_ok = new Button();
            label9 = new Label();
            groupBox2 = new GroupBox();
            groupBox_Aviso_Cancelar.SuspendLayout();
            groupBox_Aviso_Proximo.SuspendLayout();
            groupBox_Aviso_Salvo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 0;
            label1.Text = "Biometria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 111);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Identificação:";
            // 
            // comboBox_Identificacao
            // 
            comboBox_Identificacao.FormattingEnabled = true;
            comboBox_Identificacao.Location = new Point(107, 108);
            comboBox_Identificacao.Name = "comboBox_Identificacao";
            comboBox_Identificacao.Size = new Size(250, 23);
            comboBox_Identificacao.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 179);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Tipo:";
            // 
            // comboBox_Tipo
            // 
            comboBox_Tipo.FormattingEnabled = true;
            comboBox_Tipo.Location = new Point(107, 175);
            comboBox_Tipo.Name = "comboBox_Tipo";
            comboBox_Tipo.Size = new Size(250, 23);
            comboBox_Tipo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 250);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 5;
            label4.Text = "Nome:";
            // 
            // comboBox_Nome
            // 
            comboBox_Nome.FormattingEnabled = true;
            comboBox_Nome.Location = new Point(107, 247);
            comboBox_Nome.Name = "comboBox_Nome";
            comboBox_Nome.Size = new Size(250, 23);
            comboBox_Nome.TabIndex = 6;
            // 
            // button_Salvar
            // 
            button_Salvar.Location = new Point(712, 419);
            button_Salvar.Name = "button_Salvar";
            button_Salvar.Size = new Size(75, 23);
            button_Salvar.TabIndex = 9;
            button_Salvar.Text = "Salvar";
            button_Salvar.UseVisualStyleBackColor = true;
            button_Salvar.Click += button_Salvar_Click_1;
            // 
            // button_Cancelar
            // 
            button_Cancelar.Location = new Point(616, 419);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(75, 23);
            button_Cancelar.TabIndex = 8;
            button_Cancelar.Text = "Cancelar";
            button_Cancelar.UseVisualStyleBackColor = true;
            button_Cancelar.Click += button_Cancelar_Click_1;
            // 
            // groupBox_Aviso_Cancelar
            // 
            groupBox_Aviso_Cancelar.AccessibleDescription = "";
            groupBox_Aviso_Cancelar.BackColor = SystemColors.ButtonHighlight;
            groupBox_Aviso_Cancelar.Controls.Add(buttonBox_Cancelar);
            groupBox_Aviso_Cancelar.Controls.Add(buttonBox_Sim);
            groupBox_Aviso_Cancelar.Controls.Add(label5);
            groupBox_Aviso_Cancelar.Location = new Point(539, 264);
            groupBox_Aviso_Cancelar.Name = "groupBox_Aviso_Cancelar";
            groupBox_Aviso_Cancelar.Size = new Size(249, 132);
            groupBox_Aviso_Cancelar.TabIndex = 10;
            groupBox_Aviso_Cancelar.TabStop = false;
            groupBox_Aviso_Cancelar.Text = "Aviso";
            // 
            // buttonBox_Cancelar
            // 
            buttonBox_Cancelar.Location = new Point(34, 103);
            buttonBox_Cancelar.Name = "buttonBox_Cancelar";
            buttonBox_Cancelar.Size = new Size(128, 23);
            buttonBox_Cancelar.TabIndex = 2;
            buttonBox_Cancelar.Text = "Cancelar a Biometria";
            buttonBox_Cancelar.UseVisualStyleBackColor = true;
            buttonBox_Cancelar.Click += buttonBox_Cancelar_Click;
            // 
            // buttonBox_Sim
            // 
            buttonBox_Sim.Location = new Point(168, 103);
            buttonBox_Sim.Name = "buttonBox_Sim";
            buttonBox_Sim.Size = new Size(75, 23);
            buttonBox_Sim.TabIndex = 1;
            buttonBox_Sim.Text = "Sim";
            buttonBox_Sim.UseVisualStyleBackColor = true;
            buttonBox_Sim.Click += buttonBox_Sim_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(223, 30);
            label5.TabIndex = 0;
            label5.Text = "Você deseja cancelar a biometria e voltar \r\npara o menu?";
            label5.Click += label5_Click;
            // 
            // groupBox_Aviso_Proximo
            // 
            groupBox_Aviso_Proximo.BackColor = SystemColors.ButtonHighlight;
            groupBox_Aviso_Proximo.Controls.Add(button_Não);
            groupBox_Aviso_Proximo.Controls.Add(button_Sim);
            groupBox_Aviso_Proximo.Controls.Add(label10);
            groupBox_Aviso_Proximo.Font = new Font("Segoe UI", 9F);
            groupBox_Aviso_Proximo.Location = new Point(539, 31);
            groupBox_Aviso_Proximo.Name = "groupBox_Aviso_Proximo";
            groupBox_Aviso_Proximo.Size = new Size(200, 100);
            groupBox_Aviso_Proximo.TabIndex = 23;
            groupBox_Aviso_Proximo.TabStop = false;
            groupBox_Aviso_Proximo.Text = "Aviso";
            // 
            // button_Não
            // 
            button_Não.Location = new Point(38, 67);
            button_Não.Name = "button_Não";
            button_Não.RightToLeft = RightToLeft.No;
            button_Não.Size = new Size(75, 23);
            button_Não.TabIndex = 2;
            button_Não.Text = "Não";
            button_Não.UseVisualStyleBackColor = true;
            button_Não.Click += button_Não_Click;
            // 
            // button_Sim
            // 
            button_Sim.Location = new Point(119, 67);
            button_Sim.Name = "button_Sim";
            button_Sim.Size = new Size(75, 23);
            button_Sim.TabIndex = 1;
            button_Sim.Text = "Sim";
            button_Sim.UseVisualStyleBackColor = true;
            button_Sim.Click += button_Sim_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F);
            label10.Location = new Point(6, 30);
            label10.Name = "label10";
            label10.Size = new Size(140, 15);
            label10.TabIndex = 0;
            label10.Text = "Deseja registrar a equipe?";
            // 
            // groupBox_Aviso_Salvo
            // 
            groupBox_Aviso_Salvo.BackColor = SystemColors.ButtonHighlight;
            groupBox_Aviso_Salvo.Controls.Add(button_ok);
            groupBox_Aviso_Salvo.Controls.Add(label9);
            groupBox_Aviso_Salvo.Controls.Add(groupBox2);
            groupBox_Aviso_Salvo.Font = new Font("Segoe UI", 9F);
            groupBox_Aviso_Salvo.ForeColor = SystemColors.ControlText;
            groupBox_Aviso_Salvo.Location = new Point(539, 147);
            groupBox_Aviso_Salvo.Name = "groupBox_Aviso_Salvo";
            groupBox_Aviso_Salvo.Size = new Size(200, 99);
            groupBox_Aviso_Salvo.TabIndex = 22;
            groupBox_Aviso_Salvo.TabStop = false;
            groupBox_Aviso_Salvo.Text = "Aviso";
            // 
            // button_ok
            // 
            button_ok.Location = new Point(107, 70);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(75, 23);
            button_ok.TabIndex = 1;
            button_ok.Text = "Ok";
            button_ok.UseVisualStyleBackColor = true;
            button_ok.Click += button_ok_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 38);
            label9.Name = "label9";
            label9.Size = new Size(165, 15);
            label9.TabIndex = 0;
            label9.Text = "Dados gravados com sucesso!";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(194, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // Biometria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox_Aviso_Proximo);
            Controls.Add(groupBox_Aviso_Salvo);
            Controls.Add(groupBox_Aviso_Cancelar);
            Controls.Add(button_Salvar);
            Controls.Add(button_Cancelar);
            Controls.Add(comboBox_Nome);
            Controls.Add(label4);
            Controls.Add(comboBox_Tipo);
            Controls.Add(label3);
            Controls.Add(comboBox_Identificacao);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Biometria";
            Text = "Biometria";
            groupBox_Aviso_Cancelar.ResumeLayout(false);
            groupBox_Aviso_Cancelar.PerformLayout();
            groupBox_Aviso_Proximo.ResumeLayout(false);
            groupBox_Aviso_Proximo.PerformLayout();
            groupBox_Aviso_Salvo.ResumeLayout(false);
            groupBox_Aviso_Salvo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox_Identificacao;
        private Label label3;
        private ComboBox comboBox_Tipo;
        private Label label4;
        private ComboBox comboBox_Nome;
        private Button button_Salvar;
        private Button button_Cancelar;
        private GroupBox groupBox_Aviso_Cancelar;
        private Label label5;
        private Button buttonBox_Cancelar;
        private Button buttonBox_Sim;
        private GroupBox groupBox_Aviso_Proximo;
        private Button button_Não;
        private Button button_Sim;
        private Label label10;
        private GroupBox groupBox_Aviso_Salvo;
        private Button button_ok;
        private Label label9;
        private GroupBox groupBox2;
    }
}