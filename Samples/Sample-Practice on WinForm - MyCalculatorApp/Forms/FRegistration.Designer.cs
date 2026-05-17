namespace MyApp.Forms
{
    partial class FRegistration
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
            linkLabel1 = new LinkLabel();
            button_registration = new Button();
            textBox_password = new TextBox();
            label2 = new Label();
            textBox_login = new TextBox();
            label1 = new Label();
            textBox_email = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.Location = new Point(139, 223);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 25);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Вход";
            // 
            // button_registration
            // 
            button_registration.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_registration.Location = new Point(100, 164);
            button_registration.Name = "button_registration";
            button_registration.Size = new Size(138, 44);
            button_registration.TabIndex = 10;
            button_registration.Text = "Регистрация";
            button_registration.UseVisualStyleBackColor = true;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_password.Location = new Point(100, 55);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(261, 33);
            textBox_password.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 8;
            label2.Text = "Пароль:";
            // 
            // textBox_login
            // 
            textBox_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_login.Location = new Point(100, 6);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(261, 33);
            textBox_login.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 6;
            label1.Text = "Логин:";
            // 
            // textBox_email
            // 
            textBox_email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_email.Location = new Point(100, 108);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(261, 33);
            textBox_email.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 12;
            label3.Text = "Email:";
            // 
            // FRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 256);
            Controls.Add(textBox_email);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(button_registration);
            Controls.Add(textBox_password);
            Controls.Add(label2);
            Controls.Add(textBox_login);
            Controls.Add(label1);
            Name = "FRegistration";
            Text = "FRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button button_registration;
        private TextBox textBox_password;
        private Label label2;
        private TextBox textBox_login;
        private Label label1;
        private TextBox textBox_email;
        private Label label3;
    }
}