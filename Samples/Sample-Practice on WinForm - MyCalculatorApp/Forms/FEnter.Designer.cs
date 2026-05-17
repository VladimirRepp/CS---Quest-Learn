namespace MyApp.Forms
{
    partial class FEnter
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
            textBox_login = new TextBox();
            textBox_password = new TextBox();
            label2 = new Label();
            button_enter = new Button();
            linkLabel_reg = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Логин:";
            // 
            // textBox_login
            // 
            textBox_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_login.Location = new Point(100, 17);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(261, 33);
            textBox_login.TabIndex = 1;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_password.Location = new Point(100, 66);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(261, 33);
            textBox_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 2;
            label2.Text = "Пароль:";
            // 
            // button_enter
            // 
            button_enter.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_enter.Location = new Point(117, 126);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(138, 44);
            button_enter.TabIndex = 4;
            button_enter.Text = "Вход";
            button_enter.UseVisualStyleBackColor = true;
            button_enter.Click += button_enter_Click;
            // 
            // linkLabel_reg
            // 
            linkLabel_reg.AutoSize = true;
            linkLabel_reg.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel_reg.Location = new Point(124, 188);
            linkLabel_reg.Name = "linkLabel_reg";
            linkLabel_reg.Size = new Size(121, 25);
            linkLabel_reg.TabIndex = 5;
            linkLabel_reg.TabStop = true;
            linkLabel_reg.Text = "Регистрация";
            linkLabel_reg.LinkClicked += linkLabel_reg_LinkClicked;
            // 
            // FEnter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 231);
            Controls.Add(linkLabel_reg);
            Controls.Add(button_enter);
            Controls.Add(textBox_password);
            Controls.Add(label2);
            Controls.Add(textBox_login);
            Controls.Add(label1);
            Name = "FEnter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_login;
        private TextBox textBox_password;
        private Label label2;
        private Button button_enter;
        private LinkLabel linkLabel_reg;
    }
}