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
            groupBox_Aviso = new GroupBox();
            label1 = new Label();
            button_Box_Não = new Button();
            button_Box_Sim = new Button();
            button_Proximo = new Button();
            groupBox_Aviso.SuspendLayout();
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
            // 
            // button_salvar
            // 
            button_salvar.Location = new Point(713, 419);
            button_salvar.Name = "button_salvar";
            button_salvar.Size = new Size(75, 23);
            button_salvar.TabIndex = 7;
            button_salvar.Text = "Salvar";
            button_salvar.UseVisualStyleBackColor = true;
            // 
            // groupBox_Aviso
            // 
            groupBox_Aviso.BackColor = SystemColors.ButtonHighlight;
            groupBox_Aviso.Controls.Add(label1);
            groupBox_Aviso.Controls.Add(button_Box_Não);
            groupBox_Aviso.Controls.Add(button_Box_Sim);
            groupBox_Aviso.Location = new Point(346, 144);
            groupBox_Aviso.Name = "groupBox_Aviso";
            groupBox_Aviso.Size = new Size(231, 83);
            groupBox_Aviso.TabIndex = 8;
            groupBox_Aviso.TabStop = false;
            groupBox_Aviso.Text = "Aviso";
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
            // Captura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Proximo);
            Controls.Add(groupBox_Aviso);
            Controls.Add(button_salvar);
            Controls.Add(button_cancelar);
            Controls.Add(txtbox_Horario);
            Controls.Add(txtbox_Data);
            Controls.Add(txtbox_Local);
            Controls.Add(text_Horario);
            Controls.Add(text_Data);
            Controls.Add(text_Local);
            Name = "Captura";
            Text = "Captura";
            groupBox_Aviso.ResumeLayout(false);
            groupBox_Aviso.PerformLayout();
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
        private GroupBox groupBox_Aviso;
        private Button button_Box_Não;
        private Button button_Box_Sim;
        private Label label1;
        private Button button_Proximo;
    }
}