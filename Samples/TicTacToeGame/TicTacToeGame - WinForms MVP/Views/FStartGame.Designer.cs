namespace TicTacToeGame___MVP
{
    partial class FStartGame
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
            label1 = new Label();
            numericUpDown_SizeField = new NumericUpDown();
            button_StartGame = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_SizeField).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(270, 25);
            label1.TabIndex = 0;
            label1.Text = "Выберите  размерность поля:";
            // 
            // numericUpDown_SizeField
            // 
            numericUpDown_SizeField.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDown_SizeField.Location = new Point(288, 25);
            numericUpDown_SizeField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_SizeField.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown_SizeField.Name = "numericUpDown_SizeField";
            numericUpDown_SizeField.Size = new Size(74, 33);
            numericUpDown_SizeField.TabIndex = 1;
            numericUpDown_SizeField.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // button_StartGame
            // 
            button_StartGame.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_StartGame.Location = new Point(72, 78);
            button_StartGame.Name = "button_StartGame";
            button_StartGame.Size = new Size(243, 35);
            button_StartGame.TabIndex = 2;
            button_StartGame.Text = "Начать игру";
            button_StartGame.UseVisualStyleBackColor = true;
            // 
            // FStartGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 151);
            Controls.Add(button_StartGame);
            Controls.Add(numericUpDown_SizeField);
            Controls.Add(label1);
            Name = "FStartGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Начало игры";
            FormClosed += FStartGame_FormClosed;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_SizeField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
       
        // Лучше сделать отдельный интерфейс 
        // через который получить доступ к данным элементам 
        // Но, хотя бы так (public):
        public NumericUpDown numericUpDown_SizeField;
        public Button button_StartGame;
    }
}
