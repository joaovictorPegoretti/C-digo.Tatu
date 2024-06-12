namespace Tatu
{
    partial class Ficha_Anestesica
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
            Text_Anestesico = new Label();
            txtBox_Anestesico = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtBox_Administracao = new TextBox();
            label3 = new Label();
            button_Salvar = new Button();
            button_Cancelar = new Button();
            txtBox_Observacao = new TextBox();
            groupBox_Aviso_Cancelar = new GroupBox();
            buttonBox_Cancelar = new Button();
            buttonBox_Sim = new Button();
            label11 = new Label();
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
            // Text_Anestesico
            // 
            Text_Anestesico.AutoSize = true;
            Text_Anestesico.Font = new Font("Segoe UI", 10F);
            Text_Anestesico.Location = new Point(15, 53);
            Text_Anestesico.Margin = new Padding(6, 0, 6, 0);
            Text_Anestesico.Name = "Text_Anestesico";
            Text_Anestesico.Size = new Size(198, 19);
            Text_Anestesico.TabIndex = 1;
            Text_Anestesico.Text = "Qual tipo anestésico utilizado? ";
            // 
            // txtBox_Anestesico
            // 
            txtBox_Anestesico.Font = new Font("Segoe UI", 15F);
            txtBox_Anestesico.Location = new Point(15, 78);
            txtBox_Anestesico.Margin = new Padding(6);
            txtBox_Anestesico.Name = "txtBox_Anestesico";
            txtBox_Anestesico.Size = new Size(598, 34);
            txtBox_Anestesico.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(15, 9);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 32);
            label2.TabIndex = 4;
            label2.Text = "Ficha Anestésica";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(15, 137);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(303, 19);
            label1.TabIndex = 5;
            label1.Text = "Qual via foi feita a administração do Anestésico?";
            // 
            // txtBox_Administracao
            // 
            txtBox_Administracao.Font = new Font("Segoe UI", 15F);
            txtBox_Administracao.Location = new Point(15, 162);
            txtBox_Administracao.Margin = new Padding(6);
            txtBox_Administracao.Name = "txtBox_Administracao";
            txtBox_Administracao.Size = new Size(598, 34);
            txtBox_Administracao.TabIndex = 6;
            txtBox_Administracao.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(15, 224);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 7;
            label3.Text = "Observação:";
            // 
            // button_Salvar
            // 
            button_Salvar.Font = new Font("Segoe UI", 8F);
            button_Salvar.Location = new Point(698, 415);
            button_Salvar.Name = "button_Salvar";
            button_Salvar.Size = new Size(75, 23);
            button_Salvar.TabIndex = 9;
            button_Salvar.Text = "Salvar";
            button_Salvar.UseVisualStyleBackColor = true;
            button_Salvar.Click += button_Salvar_Click;
            // 
            // button_Cancelar
            // 
            button_Cancelar.Font = new Font("Segoe UI", 8F);
            button_Cancelar.Location = new Point(605, 415);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(75, 23);
            button_Cancelar.TabIndex = 10;
            button_Cancelar.Text = "Cancelar";
            button_Cancelar.UseVisualStyleBackColor = true;
            button_Cancelar.Click += button_Cancelar_Click;
            // 
            // txtBox_Observacao
            // 
            txtBox_Observacao.Font = new Font("Segoe UI", 15F);
            txtBox_Observacao.Location = new Point(15, 249);
            txtBox_Observacao.Margin = new Padding(6);
            txtBox_Observacao.Multiline = true;
            txtBox_Observacao.Name = "txtBox_Observacao";
            txtBox_Observacao.Size = new Size(598, 118);
            txtBox_Observacao.TabIndex = 11;
            // 
            // groupBox_Aviso_Cancelar
            // 
            groupBox_Aviso_Cancelar.BackColor = SystemColors.ButtonHighlight;
            groupBox_Aviso_Cancelar.Controls.Add(buttonBox_Cancelar);
            groupBox_Aviso_Cancelar.Controls.Add(buttonBox_Sim);
            groupBox_Aviso_Cancelar.Controls.Add(label11);
            groupBox_Aviso_Cancelar.Font = new Font("Segoe UI", 9F);
            groupBox_Aviso_Cancelar.Location = new Point(564, 266);
            groupBox_Aviso_Cancelar.Name = "groupBox_Aviso_Cancelar";
            groupBox_Aviso_Cancelar.Size = new Size(235, 109);
            groupBox_Aviso_Cancelar.TabIndex = 19;
            groupBox_Aviso_Cancelar.TabStop = false;
            groupBox_Aviso_Cancelar.Text = "Aviso";
            // 
            // buttonBox_Cancelar
            // 
            buttonBox_Cancelar.Location = new Point(20, 79);
            buttonBox_Cancelar.Name = "buttonBox_Cancelar";
            buttonBox_Cancelar.Size = new Size(128, 23);
            buttonBox_Cancelar.TabIndex = 3;
            buttonBox_Cancelar.Text = "Cancelar a Ficha";
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
            label11.Size = new Size(198, 30);
            label11.TabIndex = 0;
            label11.Text = "Você deseja cancelar a ficha e voltar \r\npara o menu?";
            // 
            // groupBox_Aviso_Proximo
            // 
            groupBox_Aviso_Proximo.BackColor = SystemColors.ButtonHighlight;
            groupBox_Aviso_Proximo.Controls.Add(button_Não);
            groupBox_Aviso_Proximo.Controls.Add(button_Sim);
            groupBox_Aviso_Proximo.Controls.Add(label10);
            groupBox_Aviso_Proximo.Font = new Font("Segoe UI", 9F);
            groupBox_Aviso_Proximo.Location = new Point(564, 31);
            groupBox_Aviso_Proximo.Name = "groupBox_Aviso_Proximo";
            groupBox_Aviso_Proximo.Size = new Size(200, 100);
            groupBox_Aviso_Proximo.TabIndex = 21;
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
            label10.Size = new Size(147, 15);
            label10.TabIndex = 0;
            label10.Text = "Deseja registrar a amostra?";
            // 
            // groupBox_Aviso_Salvo
            // 
            groupBox_Aviso_Salvo.BackColor = SystemColors.ButtonHighlight;
            groupBox_Aviso_Salvo.Controls.Add(button_ok);
            groupBox_Aviso_Salvo.Controls.Add(label9);
            groupBox_Aviso_Salvo.Controls.Add(groupBox2);
            groupBox_Aviso_Salvo.Font = new Font("Segoe UI", 9F);
            groupBox_Aviso_Salvo.ForeColor = SystemColors.ControlText;
            groupBox_Aviso_Salvo.Location = new Point(564, 152);
            groupBox_Aviso_Salvo.Name = "groupBox_Aviso_Salvo";
            groupBox_Aviso_Salvo.Size = new Size(200, 99);
            groupBox_Aviso_Salvo.TabIndex = 20;
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
            label9.Click += label9_Click;
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
            // Ficha_Anestesica
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox_Aviso_Cancelar);
            Controls.Add(groupBox_Aviso_Proximo);
            Controls.Add(groupBox_Aviso_Salvo);
            Controls.Add(txtBox_Observacao);
            Controls.Add(button_Cancelar);
            Controls.Add(button_Salvar);
            Controls.Add(label3);
            Controls.Add(txtBox_Administracao);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtBox_Anestesico);
            Controls.Add(Text_Anestesico);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(6);
            Name = "Ficha_Anestesica";
            Text = "Ficha_Anestesica";
            Load += Ficha_Anestesica_Load;
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

        private Label Text_Anestesico;
        private TextBox txtBox_Anestesico;
        private Label label2;
        private Label label1;
        private TextBox txtBox_Administracao;
        private Label label3;
        private Button button_Salvar;
        private Button button_Cancelar;
        private TextBox txtBox_Observacao;
        private GroupBox groupBox_Aviso_Cancelar;
        private Button buttonBox_Cancelar;
        private Button buttonBox_Sim;
        private Label label11;
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