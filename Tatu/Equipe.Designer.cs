namespace Tatu
{
    partial class Equipe
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
            txtBox_Equipe = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBox_Instituicao = new TextBox();
            label3 = new Label();
            txtBox_Contato = new TextBox();
            txtBox_Observacao = new TextBox();
            label4 = new Label();
            button_Salvar = new Button();
            button_Cancelar = new Button();
            label5 = new Label();
            groupBox_Aviso_Cancelar = new GroupBox();
            buttonBox_Cancelar = new Button();
            buttonBox_Sim = new Button();
            label11 = new Label();
            groupBox_Aviso_Salvo = new GroupBox();
            button_ok = new Button();
            label6 = new Label();
            groupBox_Aviso_Proximo = new GroupBox();
            button_Não = new Button();
            button_Sim = new Button();
            label10 = new Label();
            groupBox_Aviso_Cancelar.SuspendLayout();
            groupBox_Aviso_Salvo.SuspendLayout();
            groupBox_Aviso_Proximo.SuspendLayout();
            SuspendLayout();
            // 
            // txtBox_Equipe
            // 
            txtBox_Equipe.Location = new Point(128, 75);
            txtBox_Equipe.Name = "txtBox_Equipe";
            txtBox_Equipe.Size = new Size(232, 23);
            txtBox_Equipe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 78);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 139);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Instituição:";
            // 
            // txtBox_Instituicao
            // 
            txtBox_Instituicao.Location = new Point(128, 131);
            txtBox_Instituicao.Name = "txtBox_Instituicao";
            txtBox_Instituicao.Size = new Size(232, 23);
            txtBox_Instituicao.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 200);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Contato:";
            // 
            // txtBox_Contato
            // 
            txtBox_Contato.Location = new Point(128, 195);
            txtBox_Contato.Name = "txtBox_Contato";
            txtBox_Contato.Size = new Size(232, 23);
            txtBox_Contato.TabIndex = 6;
            // 
            // txtBox_Observacao
            // 
            txtBox_Observacao.Location = new Point(128, 261);
            txtBox_Observacao.Multiline = true;
            txtBox_Observacao.Name = "txtBox_Observacao";
            txtBox_Observacao.Size = new Size(285, 99);
            txtBox_Observacao.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 264);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 7;
            label4.Text = "Observação:";
            // 
            // button_Salvar
            // 
            button_Salvar.Location = new Point(694, 415);
            button_Salvar.Name = "button_Salvar";
            button_Salvar.Size = new Size(75, 23);
            button_Salvar.TabIndex = 11;
            button_Salvar.Text = "Salvar";
            button_Salvar.UseVisualStyleBackColor = true;
            button_Salvar.Click += button_Salvar_Click;
            // 
            // button_Cancelar
            // 
            button_Cancelar.Location = new Point(613, 415);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(75, 23);
            button_Cancelar.TabIndex = 10;
            button_Cancelar.Text = "Cancelar";
            button_Cancelar.UseVisualStyleBackColor = true;
            button_Cancelar.Click += button_Cancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(31, 18);
            label5.Name = "label5";
            label5.Size = new Size(180, 28);
            label5.TabIndex = 12;
            label5.Text = "Equipe responsável";
            // 
            // groupBox_Aviso_Cancelar
            // 
            groupBox_Aviso_Cancelar.BackColor = SystemColors.ButtonHighlight;
            groupBox_Aviso_Cancelar.Controls.Add(buttonBox_Cancelar);
            groupBox_Aviso_Cancelar.Controls.Add(buttonBox_Sim);
            groupBox_Aviso_Cancelar.Controls.Add(label11);
            groupBox_Aviso_Cancelar.Font = new Font("Segoe UI", 9F);
            groupBox_Aviso_Cancelar.Location = new Point(549, 281);
            groupBox_Aviso_Cancelar.Name = "groupBox_Aviso_Cancelar";
            groupBox_Aviso_Cancelar.Size = new Size(235, 109);
            groupBox_Aviso_Cancelar.TabIndex = 26;
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
            label11.Size = new Size(208, 30);
            label11.TabIndex = 0;
            label11.Text = "Você deseja cancelar a equipe e voltar \r\npara o menu?";
            // 
            // groupBox_Aviso_Salvo
            // 
            groupBox_Aviso_Salvo.BackColor = SystemColors.ButtonHighlight;
            groupBox_Aviso_Salvo.Controls.Add(button_ok);
            groupBox_Aviso_Salvo.Controls.Add(label6);
            groupBox_Aviso_Salvo.Location = new Point(549, 151);
            groupBox_Aviso_Salvo.Name = "groupBox_Aviso_Salvo";
            groupBox_Aviso_Salvo.Size = new Size(200, 100);
            groupBox_Aviso_Salvo.TabIndex = 27;
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
            button_ok.Click += button_ok_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 35);
            label6.Name = "label6";
            label6.Size = new Size(149, 15);
            label6.TabIndex = 0;
            label6.Text = "Dados salvos com sucesso!";
            // 
            // groupBox_Aviso_Proximo
            // 
            groupBox_Aviso_Proximo.BackColor = SystemColors.ButtonHighlight;
            groupBox_Aviso_Proximo.Controls.Add(button_Não);
            groupBox_Aviso_Proximo.Controls.Add(button_Sim);
            groupBox_Aviso_Proximo.Controls.Add(label10);
            groupBox_Aviso_Proximo.Font = new Font("Segoe UI", 9F);
            groupBox_Aviso_Proximo.Location = new Point(549, 29);
            groupBox_Aviso_Proximo.Name = "groupBox_Aviso_Proximo";
            groupBox_Aviso_Proximo.Size = new Size(200, 100);
            groupBox_Aviso_Proximo.TabIndex = 28;
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
            label10.Size = new Size(149, 15);
            label10.TabIndex = 0;
            label10.Text = "Deseja registrar o cientista?";
            // 
            // Equipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox_Aviso_Proximo);
            Controls.Add(groupBox_Aviso_Salvo);
            Controls.Add(groupBox_Aviso_Cancelar);
            Controls.Add(label5);
            Controls.Add(button_Salvar);
            Controls.Add(button_Cancelar);
            Controls.Add(txtBox_Observacao);
            Controls.Add(label4);
            Controls.Add(txtBox_Contato);
            Controls.Add(label3);
            Controls.Add(txtBox_Instituicao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBox_Equipe);
            Name = "Equipe";
            Text = "Equipe";
            groupBox_Aviso_Cancelar.ResumeLayout(false);
            groupBox_Aviso_Cancelar.PerformLayout();
            groupBox_Aviso_Salvo.ResumeLayout(false);
            groupBox_Aviso_Salvo.PerformLayout();
            groupBox_Aviso_Proximo.ResumeLayout(false);
            groupBox_Aviso_Proximo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBox_Equipe;
        private Label label1;
        private Label label2;
        private TextBox txtBox_Instituicao;
        private Label label3;
        private TextBox txtBox_Contato;
        private TextBox txtBox_Observacao;
        private Label label4;
        private Button button_Salvar;
        private Button button_Cancelar;
        private Label label5;
        private GroupBox groupBox_Aviso_Cancelar;
        private Button buttonBox_Cancelar;
        private Button buttonBox_Sim;
        private Label label11;
        private GroupBox groupBox_Aviso_Salvo;
        private Button button_ok;
        private Label label6;
        private GroupBox groupBox_Aviso_Proximo;
        private Button button_Não;
        private Button button_Sim;
        private Label label10;
    }
}