namespace Tatu
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            capturaToolStripMenuItem = new ToolStripMenuItem();
            tatuToolStripMenuItem = new ToolStripMenuItem();
            Ficha_Campo = new ToolStripMenuItem();
            fichaAnestesicaToolStripMenuItem = new ToolStripMenuItem();
            amostrasToolStripMenuItem = new ToolStripMenuItem();
            biometriaToolStripMenuItem = new ToolStripMenuItem();
            equipeToolStripMenuItem = new ToolStripMenuItem();
            cientistaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { capturaToolStripMenuItem, tatuToolStripMenuItem, equipeToolStripMenuItem, cientistaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(869, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // capturaToolStripMenuItem
            // 
            capturaToolStripMenuItem.Name = "capturaToolStripMenuItem";
            capturaToolStripMenuItem.Size = new Size(61, 20);
            capturaToolStripMenuItem.Text = "Captura";
            capturaToolStripMenuItem.Click += capturaToolStripMenuItem_Click;
            // 
            // tatuToolStripMenuItem
            // 
            tatuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Ficha_Campo, fichaAnestesicaToolStripMenuItem, amostrasToolStripMenuItem, biometriaToolStripMenuItem });
            tatuToolStripMenuItem.Name = "tatuToolStripMenuItem";
            tatuToolStripMenuItem.Size = new Size(41, 20);
            tatuToolStripMenuItem.Text = "Tatu";
            // 
            // Ficha_Campo
            // 
            Ficha_Campo.Name = "Ficha_Campo";
            Ficha_Campo.Size = new Size(161, 22);
            Ficha_Campo.Text = "Ficha do Tatu";
            Ficha_Campo.Click += Ficha_Campo_Click;
            // 
            // fichaAnestesicaToolStripMenuItem
            // 
            fichaAnestesicaToolStripMenuItem.Name = "fichaAnestesicaToolStripMenuItem";
            fichaAnestesicaToolStripMenuItem.Size = new Size(161, 22);
            fichaAnestesicaToolStripMenuItem.Text = "Ficha Anestesica";
            fichaAnestesicaToolStripMenuItem.Click += fichaAnestesicaToolStripMenuItem_Click;
            // 
            // amostrasToolStripMenuItem
            // 
            amostrasToolStripMenuItem.Name = "amostrasToolStripMenuItem";
            amostrasToolStripMenuItem.Size = new Size(161, 22);
            amostrasToolStripMenuItem.Text = "Amostras";
            amostrasToolStripMenuItem.Click += amostrasToolStripMenuItem_Click;
            // 
            // biometriaToolStripMenuItem
            // 
            biometriaToolStripMenuItem.Name = "biometriaToolStripMenuItem";
            biometriaToolStripMenuItem.Size = new Size(161, 22);
            biometriaToolStripMenuItem.Text = "Biometria";
            biometriaToolStripMenuItem.Click += biometriaToolStripMenuItem_Click;
            // 
            // equipeToolStripMenuItem
            // 
            equipeToolStripMenuItem.Name = "equipeToolStripMenuItem";
            equipeToolStripMenuItem.Size = new Size(55, 20);
            equipeToolStripMenuItem.Text = "Equipe";
            equipeToolStripMenuItem.Click += equipeToolStripMenuItem_Click;
            // 
            // cientistaToolStripMenuItem
            // 
            cientistaToolStripMenuItem.Name = "cientistaToolStripMenuItem";
            cientistaToolStripMenuItem.Size = new Size(65, 20);
            cientistaToolStripMenuItem.Text = "Cientista";
            cientistaToolStripMenuItem.Click += cientistaToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(869, 488);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tatuToolStripMenuItem;
        private ToolStripMenuItem equipeToolStripMenuItem;
        private ToolStripMenuItem Ficha_Campo;
        private ToolStripMenuItem capturaToolStripMenuItem;
        private ToolStripMenuItem fichaAnestesicaToolStripMenuItem;
        private ToolStripMenuItem amostrasToolStripMenuItem;
        private ToolStripMenuItem biometriaToolStripMenuItem;
        private ToolStripMenuItem cientistaToolStripMenuItem;
    }
}
