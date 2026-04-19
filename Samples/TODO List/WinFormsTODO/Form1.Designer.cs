namespace WinFormsTODO
{
    partial class Form1
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
            dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            textBoxTask = new TextBox();
            comboBoxStatus = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView.Location = new Point(12, 134);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(776, 304);
            dataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Задача";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Статус";
            Column2.Name = "Column2";
            // 
            // textBoxTask
            // 
            textBoxTask.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask.Location = new Point(12, 34);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(359, 29);
            textBoxTask.TabIndex = 1;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Выдана", "В работе", "На проверке", "Завершена" });
            comboBoxStatus.Location = new Point(12, 91);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(359, 23);
            comboBoxStatus.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = "Задача:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 4;
            label2.Text = "Статус:";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(459, 34);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(135, 37);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(524, 77);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(135, 37);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(600, 34);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(135, 37);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxStatus);
            Controls.Add(textBoxTask);
            Controls.Add(dataGridView);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TODO список";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox textBoxTask;
        private ComboBox comboBoxStatus;
        private Label label1;
        private Label label2;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonEdit;
    }
}
