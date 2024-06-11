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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 59);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtBox_Nome
            // 
            txtBox_Nome.Location = new Point(87, 55);
            txtBox_Nome.Name = "txtBox_Nome";
            txtBox_Nome.Size = new Size(234, 23);
            txtBox_Nome.TabIndex = 1;
            // 
            // txtBox_Email
            // 
            txtBox_Email.Location = new Point(87, 118);
            txtBox_Email.Name = "txtBox_Email";
            txtBox_Email.Size = new Size(234, 23);
            txtBox_Email.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 122);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // txtBox_Telefone
            // 
            txtBox_Telefone.Location = new Point(98, 184);
            txtBox_Telefone.Name = "txtBox_Telefone";
            txtBox_Telefone.Size = new Size(234, 23);
            txtBox_Telefone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 187);
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
            // Cientista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}