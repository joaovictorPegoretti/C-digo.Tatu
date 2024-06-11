namespace Tatu
{
    partial class Ficha_do_Tatu
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
            txtbox_Nome = new TextBox();
            txtlabel2 = new Label();
            txtbox_Altura = new TextBox();
            label2 = new Label();
            txtbox_Peso = new TextBox();
            label3 = new Label();
            check_Sim = new CheckBox();
            check_Não = new CheckBox();
            text_chip = new Label();
            txtbox_Chip = new TextBox();
            Button_Cancelar = new Button();
            Button_Salvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 21);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtbox_Nome
            // 
            txtbox_Nome.Location = new Point(58, 18);
            txtbox_Nome.Name = "txtbox_Nome";
            txtbox_Nome.Size = new Size(242, 23);
            txtbox_Nome.TabIndex = 1;
            // 
            // txtlabel2
            // 
            txtlabel2.AutoSize = true;
            txtlabel2.Location = new Point(12, 79);
            txtlabel2.Name = "txtlabel2";
            txtlabel2.Size = new Size(42, 15);
            txtlabel2.TabIndex = 2;
            txtlabel2.Text = "Altura:";
            // 
            // txtbox_Altura
            // 
            txtbox_Altura.Location = new Point(59, 75);
            txtbox_Altura.Name = "txtbox_Altura";
            txtbox_Altura.Size = new Size(242, 23);
            txtbox_Altura.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 141);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "Peso:";
            // 
            // txtbox_Peso
            // 
            txtbox_Peso.Location = new Point(58, 138);
            txtbox_Peso.Name = "txtbox_Peso";
            txtbox_Peso.Size = new Size(242, 23);
            txtbox_Peso.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 206);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 6;
            label3.Text = "O tatu possui Chip?";
            // 
            // check_Sim
            // 
            check_Sim.AutoSize = true;
            check_Sim.Location = new Point(129, 207);
            check_Sim.Name = "check_Sim";
            check_Sim.Size = new Size(46, 19);
            check_Sim.TabIndex = 7;
            check_Sim.Text = "Sim";
            check_Sim.UseVisualStyleBackColor = true;
            check_Sim.CheckedChanged += check_Sim_CheckedChanged;
            check_Sim.CheckStateChanged += check_Sim_CheckStateChanged;
            // 
            // check_Não
            // 
            check_Não.AutoSize = true;
            check_Não.Location = new Point(181, 207);
            check_Não.Name = "check_Não";
            check_Não.Size = new Size(48, 19);
            check_Não.TabIndex = 8;
            check_Não.Text = "Não";
            check_Não.UseVisualStyleBackColor = true;
            check_Não.CheckedChanged += check_Não_CheckedChanged;
            // 
            // text_chip
            // 
            text_chip.AutoSize = true;
            text_chip.Location = new Point(11, 254);
            text_chip.Name = "text_chip";
            text_chip.Size = new Size(99, 15);
            text_chip.TabIndex = 9;
            text_chip.Text = "Número do Chip:";
            // 
            // txtbox_Chip
            // 
            txtbox_Chip.Location = new Point(110, 251);
            txtbox_Chip.Name = "txtbox_Chip";
            txtbox_Chip.Size = new Size(190, 23);
            txtbox_Chip.TabIndex = 10;
            // 
            // Button_Cancelar
            // 
            Button_Cancelar.Location = new Point(623, 423);
            Button_Cancelar.Name = "Button_Cancelar";
            Button_Cancelar.Size = new Size(75, 23);
            Button_Cancelar.TabIndex = 11;
            Button_Cancelar.Text = "Cancelar";
            Button_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Button_Salvar
            // 
            Button_Salvar.Location = new Point(704, 423);
            Button_Salvar.Name = "Button_Salvar";
            Button_Salvar.Size = new Size(75, 23);
            Button_Salvar.TabIndex = 12;
            Button_Salvar.Text = "Salvar";
            Button_Salvar.UseVisualStyleBackColor = true;
            Button_Salvar.Click += Button_Salvar_Click;
            // 
            // Ficha_do_Tatu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button_Salvar);
            Controls.Add(Button_Cancelar);
            Controls.Add(txtbox_Chip);
            Controls.Add(text_chip);
            Controls.Add(check_Não);
            Controls.Add(check_Sim);
            Controls.Add(label3);
            Controls.Add(txtbox_Peso);
            Controls.Add(label2);
            Controls.Add(txtbox_Altura);
            Controls.Add(txtlabel2);
            Controls.Add(txtbox_Nome);
            Controls.Add(label1);
            Name = "Ficha_do_Tatu";
            Text = "Ficha do Tatu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtbox_Nome;
        private Label txtlabel2;
        private TextBox txtbox_Altura;
        private Label label2;
        private TextBox txtbox_Peso;
        private Label label3;
        private CheckBox check_Sim;
        private CheckBox check_Não;
        private Label text_chip;
        private TextBox txtbox_Chip;
        private Button Button_Cancelar;
        private Button Button_Salvar;
    }
}