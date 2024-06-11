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
            SuspendLayout();
            // 
            // txtBox_Equipe
            // 
            txtBox_Equipe.Location = new Point(144, 52);
            txtBox_Equipe.Name = "txtBox_Equipe";
            txtBox_Equipe.Size = new Size(232, 23);
            txtBox_Equipe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 55);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 2;
            label1.Text = "Equipe responsável:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 116);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Instituição:";
            // 
            // txtBox_Instituicao
            // 
            txtBox_Instituicao.Location = new Point(144, 108);
            txtBox_Instituicao.Name = "txtBox_Instituicao";
            txtBox_Instituicao.Size = new Size(232, 23);
            txtBox_Instituicao.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 177);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Contato:";
            // 
            // txtBox_Contato
            // 
            txtBox_Contato.Location = new Point(144, 172);
            txtBox_Contato.Name = "txtBox_Contato";
            txtBox_Contato.Size = new Size(232, 23);
            txtBox_Contato.TabIndex = 6;
            // 
            // txtBox_Observacao
            // 
            txtBox_Observacao.Location = new Point(144, 238);
            txtBox_Observacao.Multiline = true;
            txtBox_Observacao.Name = "txtBox_Observacao";
            txtBox_Observacao.Size = new Size(285, 99);
            txtBox_Observacao.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 241);
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
            // Equipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}