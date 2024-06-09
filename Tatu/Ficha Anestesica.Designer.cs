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
            // Ficha_Anestesica
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}