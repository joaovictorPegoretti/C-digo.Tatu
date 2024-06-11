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
            groupBox_Aviso = new GroupBox();
            buttonBox_Cancelar = new Button();
            buttonBox_Sim = new Button();
            label5 = new Label();
            groupBox_Aviso.SuspendLayout();
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
            // groupBox_Aviso
            // 
            groupBox_Aviso.AccessibleDescription = "";
            groupBox_Aviso.Controls.Add(buttonBox_Cancelar);
            groupBox_Aviso.Controls.Add(buttonBox_Sim);
            groupBox_Aviso.Controls.Add(label5);
            groupBox_Aviso.Location = new Point(318, 137);
            groupBox_Aviso.Name = "groupBox_Aviso";
            groupBox_Aviso.Size = new Size(249, 132);
            groupBox_Aviso.TabIndex = 10;
            groupBox_Aviso.TabStop = false;
            groupBox_Aviso.Text = "Aviso";
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
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(0, 19);
            label5.Name = "label5";
            label5.Size = new Size(251, 42);
            label5.TabIndex = 0;
            label5.Text = "Você deseja cancelar a biometria e \r\nvoltar para o menu?";
            label5.Click += label5_Click;
            // 
            // Biometria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox_Aviso);
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
            groupBox_Aviso.ResumeLayout(false);
            groupBox_Aviso.PerformLayout();
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
        private GroupBox groupBox_Aviso;
        private Label label5;
        private Button buttonBox_Cancelar;
        private Button buttonBox_Sim;
    }
}