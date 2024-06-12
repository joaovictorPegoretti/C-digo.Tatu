namespace Tatu
{
    partial class Captura
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
            text_Local = new Label();
            text_Data = new Label();
            text_Horario = new Label();
            txtbox_Local = new TextBox();
            txtbox_Data = new TextBox();
            txtbox_Horario = new TextBox();
            button_cancelar = new Button();
            button_salvar = new Button();
            groupBox_Aviso_Proximo = new GroupBox();
            button_Box_Não = new Button();
            button_Box_Sim = new Button();
            label1 = new Label();
            button_Proximo = new Button();
            groupBox_Aviso_Cancelar = new GroupBox();
            buttonBox_Cancelar = new Button();
            buttonBox_Sim = new Button();
            label11 = new Label();
            groupBox_Aviso_Salvo = new GroupBox();
            button_ok = new Button();
            label9 = new Label();
            groupBox2 = new GroupBox();
            groupBox_Aviso_Proximo.SuspendLayout();
            groupBox_Aviso_Cancelar.SuspendLayout();
            groupBox_Aviso_Salvo.SuspendLayout();
            SuspendLayout();
            // 
            // text_Local
            // 
            text_Local.AutoSize = true;
            text_Local.Location = new Point(12, 29);
            text_Local.Name = "text_Local";
            text_Local.Size = new Size(38, 15);
            text_Local.TabIndex = 0;
            text_Local.Text = "Local:";
            // 
            // text_Data
            // 
            text_Data.AutoSize = true;
            text_Data.Location = new Point(12, 66);
            text_Data.Name = "text_Data";
            text_Data.Size = new Size(34, 15);
            text_Data.TabIndex = 1;
            text_Data.Text = "Data:";
            // 
            // text_Horario
            // 
            text_Horario.AutoSize = true;
            text_Horario.Location = new Point(12, 123);
            text_Horario.Name = "text_Horario";
            text_Horario.Size = new Size(50, 15);
            text_Horario.TabIndex = 2;
            text_Horario.Text = "Horário:";
            // 
            // txtbox_Local
            // 
            txtbox_Local.Location = new Point(56, 26);
            txtbox_Local.Name = "txtbox_Local";
            txtbox_Local.Size = new Size(249, 23);
            txtbox_Local.TabIndex = 3;
            // 
            // txtbox_Data
            // 
            txtbox_Data.Location = new Point(56, 63);
            txtbox_Data.Name = "txtbox_Data";
            txtbox_Data.Size = new Size(249, 23);
            txtbox_Data.TabIndex = 4;
            // 
            // txtbox_Horario
            // 
            txtbox_Horario.Location = new Point(68, 120);
            txtbox_Horario.Name = "txtbox_Horario";
            txtbox_Horario.Size = new Size(237, 23);
            txtbox_Horario.TabIndex = 5;
            // 
            // button_cancelar
            // 
            button_cancelar.Location = new Point(617, 419);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(75, 23);
            button_cancelar.TabIndex = 6;
            button_cancelar.Text = "Cancelar";
            button_cancelar.UseVisualStyleBackColor = true;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // button_salvar
            // 
            button_salvar.Location = new Point(713, 419);
            button_salvar.Name = "button_salvar";
            button_salvar.Size = new Size(75, 23);
            button_salvar.TabIndex = 7;
            button_salvar.Text = "Salvar";
            button_salvar.UseVisualStyleBackColor = true;
            button_salvar.Click += button_salvar_Click;
            // 
            // groupBox_Aviso_Proximo
            // 
            groupBox_Aviso_Proximo.BackColor = SystemColors.ButtonHighlight;
            groupBox_Aviso_Proximo.Controls.Add(button_Box_Não);
            groupBox_Aviso_Proximo.Controls.Add(button_Box_Sim);
            groupBox_Aviso_Proximo.Controls.Add(label1);
            groupBox_Aviso_Proximo.Location = new Point(557, 12);
            groupBox_Aviso_Proximo.Name = "groupBox_Aviso_Proximo";
            groupBox_Aviso_Proximo.Size = new Size(231, 83);
            groupBox_Aviso_Proximo.TabIndex = 8;
            groupBox_Aviso_Proximo.TabStop = false;
            groupBox_Aviso_Proximo.Text = "Aviso";
            // 
            // button_Box_Não
            // 
            button_Box_Não.Location = new Point(69, 54);
            button_Box_Não.Name = "button_Box_Não";
            button_Box_Não.Size = new Size(75, 23);
            button_Box_Não.TabIndex = 10;
            button_Box_Não.Text = "Não";
            button_Box_Não.UseVisualStyleBackColor = true;
            button_Box_Não.Click += button_Box_Não_Click;
            // 
            // button_Box_Sim
            // 
            button_Box_Sim.Location = new Point(150, 54);
            button_Box_Sim.Name = "button_Box_Sim";
            button_Box_Sim.Size = new Size(75, 23);
            button_Box_Sim.TabIndex = 9;
            button_Box_Sim.Text = "Sim";
            button_Box_Sim.UseVisualStyleBackColor = true;
            button_Box_Sim.Click += button_Box_Sim_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 11;
            label1.Text = "Deseja cadastrar o Tatu?";
            // 
            // button_Proximo
            // 
            button_Proximo.Location = new Point(230, 163);
            button_Proximo.Name = "button_Proximo";
            button_Proximo.Size = new Size(75, 23);
            button_Proximo.TabIndex = 9;
            button_Proximo.Text = "Próximo";
            button_Proximo.UseVisualStyleBackColor = true;
            button_Proximo.Click += button_Proximo_Click;
            // 
            // groupBox_Aviso_Cancelar
            // 
            groupBox_Aviso_Cancelar.BackColor = SystemColors.ButtonHighlight;
            groupBox_Aviso_Cancelar.Controls.Add(buttonBox_Cancelar);
            groupBox_Aviso_Cancelar.Controls.Add(buttonBox_Sim);
            groupBox_Aviso_Cancelar.Controls.Add(label11);
            groupBox_Aviso_Cancelar.Font = new Font("Segoe UI", 9F);
            groupBox_Aviso_Cancelar.Location = new Point(557, 237);
            groupBox_Aviso_Cancelar.Name = "groupBox_Aviso_Cancelar";
            groupBox_Aviso_Cancelar.Size = new Size(235, 109);
            groupBox_Aviso_Cancelar.TabIndex = 21;
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
            label11.Size = new Size(212, 30);
            label11.TabIndex = 0;
            label11.Text = "Você deseja cancelar a captura e voltar \r\npara o menu?";
            // 
            // groupBox_Aviso_Salvo
            // 
            groupBox_Aviso_Salvo.BackColor = SystemColors.ButtonHighlight;
            groupBox_Aviso_Salvo.Controls.Add(button_ok);
            groupBox_Aviso_Salvo.Controls.Add(label9);
            groupBox_Aviso_Salvo.Controls.Add(groupBox2);
            groupBox_Aviso_Salvo.Font = new Font("Segoe UI", 9F);
            groupBox_Aviso_Salvo.ForeColor = SystemColors.ControlText;
            groupBox_Aviso_Salvo.Location = new Point(557, 123);
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
            // Captura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox_Aviso_Cancelar);
            Controls.Add(groupBox_Aviso_Salvo);
            Controls.Add(button_Proximo);
            Controls.Add(button_salvar);
            Controls.Add(button_cancelar);
            Controls.Add(txtbox_Horario);
            Controls.Add(txtbox_Data);
            Controls.Add(txtbox_Local);
            Controls.Add(text_Horario);
            Controls.Add(text_Data);
            Controls.Add(text_Local);
            Controls.Add(groupBox_Aviso_Proximo);
            Name = "Captura";
            Text = " ";
            Load += Captura_Load;
            groupBox_Aviso_Proximo.ResumeLayout(false);
            groupBox_Aviso_Proximo.PerformLayout();
            groupBox_Aviso_Cancelar.ResumeLayout(false);
            groupBox_Aviso_Cancelar.PerformLayout();
            groupBox_Aviso_Salvo.ResumeLayout(false);
            groupBox_Aviso_Salvo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label text_Local;
        private Label text_Data;
        private Label text_Horario;
        private TextBox txtbox_Local;
        private TextBox txtbox_Data;
        private TextBox txtbox_Horario;
        private Button button_cancelar;
        private Button button_salvar;
        private GroupBox groupBox_Aviso_Proximo;
        private Button button_Box_Não;
        private Button button_Box_Sim;
        private Label label1;
        private Button button_Proximo;
        private GroupBox groupBox_Aviso_Cancelar;
        private Button buttonBox_Cancelar;
        private Button buttonBox_Sim;
        private Label label11;
        private GroupBox groupBox_Aviso_Salvo;
        private Button button_ok;
        private Label label9;
        private GroupBox groupBox2;
    }
}