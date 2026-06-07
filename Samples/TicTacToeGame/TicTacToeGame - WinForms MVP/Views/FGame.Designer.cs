namespace TicTacToeGame___MVP.Views
{
    partial class FGame
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
            toolStrip1 = new ToolStrip();
            logForStep = new ToolStripLabel();
            menuStrip1 = new MenuStrip();
            начатьИгруToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { logForStep });
            toolStrip1.Location = new Point(0, 425);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // logForStep
            // 
            logForStep.Name = "logForStep";
            logForStep.Size = new Size(27, 22);
            logForStep.Text = "Ход";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { начатьИгруToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // начатьИгруToolStripMenuItem
            // 
            начатьИгруToolStripMenuItem.Name = "начатьИгруToolStripMenuItem";
            начатьИгруToolStripMenuItem.Size = new Size(86, 20);
            начатьИгруToolStripMenuItem.Text = "Начать игру";
            // 
            // FGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Игра крестики-нолики";
            FormClosed += FGame_FormClosed;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private MenuStrip menuStrip1;
        public ToolStripLabel logForStep;
        public ToolStripMenuItem начатьИгруToolStripMenuItem;
    }
}