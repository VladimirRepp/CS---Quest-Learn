namespace TicTacToeGame
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
            button0_0 = new Button();
            button0_1 = new Button();
            button0_2 = new Button();
            button1_2 = new Button();
            button1_1 = new Button();
            button1_0 = new Button();
            button2_2 = new Button();
            button2_1 = new Button();
            button2_0 = new Button();
            toolStrip1 = new ToolStrip();
            toolStripLabel_Log = new ToolStripLabel();
            menuStrip1 = new MenuStrip();
            начатьСначалаToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button0_0
            // 
            button0_0.Location = new Point(26, 65);
            button0_0.Name = "button0_0";
            button0_0.Size = new Size(71, 71);
            button0_0.TabIndex = 0;
            button0_0.UseVisualStyleBackColor = true;
            button0_0.Click += button0_0_Click;
            // 
            // button0_1
            // 
            button0_1.Location = new Point(103, 65);
            button0_1.Name = "button0_1";
            button0_1.Size = new Size(71, 71);
            button0_1.TabIndex = 1;
            button0_1.UseVisualStyleBackColor = true;
            button0_1.Click += button0_1_Click;
            // 
            // button0_2
            // 
            button0_2.Location = new Point(180, 65);
            button0_2.Name = "button0_2";
            button0_2.Size = new Size(71, 71);
            button0_2.TabIndex = 2;
            button0_2.UseVisualStyleBackColor = true;
            button0_2.Click += button0_2_Click;
            // 
            // button1_2
            // 
            button1_2.Location = new Point(180, 142);
            button1_2.Name = "button1_2";
            button1_2.Size = new Size(71, 71);
            button1_2.TabIndex = 5;
            button1_2.UseVisualStyleBackColor = true;
            button1_2.Click += button1_2_Click;
            // 
            // button1_1
            // 
            button1_1.Location = new Point(103, 142);
            button1_1.Name = "button1_1";
            button1_1.Size = new Size(71, 71);
            button1_1.TabIndex = 4;
            button1_1.UseVisualStyleBackColor = true;
            button1_1.Click += button1_1_Click;
            // 
            // button1_0
            // 
            button1_0.Location = new Point(26, 142);
            button1_0.Name = "button1_0";
            button1_0.Size = new Size(71, 71);
            button1_0.TabIndex = 3;
            button1_0.UseVisualStyleBackColor = true;
            button1_0.Click += button1_0_Click;
            // 
            // button2_2
            // 
            button2_2.Location = new Point(180, 219);
            button2_2.Name = "button2_2";
            button2_2.Size = new Size(71, 71);
            button2_2.TabIndex = 8;
            button2_2.UseVisualStyleBackColor = true;
            button2_2.Click += button2_2_Click;
            // 
            // button2_1
            // 
            button2_1.Location = new Point(103, 219);
            button2_1.Name = "button2_1";
            button2_1.Size = new Size(71, 71);
            button2_1.TabIndex = 7;
            button2_1.UseVisualStyleBackColor = true;
            button2_1.Click += button2_1_Click;
            // 
            // button2_0
            // 
            button2_0.Location = new Point(26, 219);
            button2_0.Name = "button2_0";
            button2_0.Size = new Size(71, 71);
            button2_0.TabIndex = 6;
            button2_0.UseVisualStyleBackColor = true;
            button2_0.Click += button2_0_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel_Log });
            toolStrip1.Location = new Point(0, 311);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(277, 25);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel_Log
            // 
            toolStripLabel_Log.Name = "toolStripLabel_Log";
            toolStripLabel_Log.Size = new Size(27, 22);
            toolStripLabel_Log.Text = "Ход";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { начатьСначалаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(277, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // начатьСначалаToolStripMenuItem
            // 
            начатьСначалаToolStripMenuItem.Name = "начатьСначалаToolStripMenuItem";
            начатьСначалаToolStripMenuItem.Size = new Size(106, 20);
            начатьСначалаToolStripMenuItem.Text = "Начать сначала";
            начатьСначалаToolStripMenuItem.Click += начатьСначалаToolStripMenuItem_Click;
            // 
            // FGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 336);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(button2_2);
            Controls.Add(button2_1);
            Controls.Add(button2_0);
            Controls.Add(button1_2);
            Controls.Add(button1_1);
            Controls.Add(button1_0);
            Controls.Add(button0_2);
            Controls.Add(button0_1);
            Controls.Add(button0_0);
            MainMenuStrip = menuStrip1;
            Name = "FGame";
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

        private Button button0_0;
        private Button button0_1;
        private Button button0_2;
        private Button button1_2;
        private Button button1_1;
        private Button button1_0;
        private Button button2_2;
        private Button button2_1;
        private Button button2_0;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel_Log;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem начатьСначалаToolStripMenuItem;
    }
}
