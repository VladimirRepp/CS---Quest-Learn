namespace SimpleSeaBattle
{
    partial class FGame
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
            начатьНовуюИгруToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { начатьНовуюИгруToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(329, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // начатьНовуюИгруToolStripMenuItem
            // 
            начатьНовуюИгруToolStripMenuItem.Name = "начатьНовуюИгруToolStripMenuItem";
            начатьНовуюИгруToolStripMenuItem.Size = new Size(125, 20);
            начатьНовуюИгруToolStripMenuItem.Text = "Начать новую игру";
            // 
            // FGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 349);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Игра Морской бой - для одного";
            FormClosed += FGame_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public MenuStrip menuStrip1;
        public ToolStripMenuItem начатьНовуюИгруToolStripMenuItem;
    }
}
