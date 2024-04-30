namespace teszt
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
            LoginBtn = new Button();
            UsrTxt = new TextBox();
            PwdTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(140, 142);
            LoginBtn.Margin = new Padding(3, 4, 3, 4);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(86, 31);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += button1_Click;
            // 
            // UsrTxt
            // 
            UsrTxt.Location = new Point(193, 38);
            UsrTxt.Margin = new Padding(3, 4, 3, 4);
            UsrTxt.Name = "UsrTxt";
            UsrTxt.Size = new Size(114, 27);
            UsrTxt.TabIndex = 1;
            // 
            // PwdTxt
            // 
            PwdTxt.Location = new Point(193, 76);
            PwdTxt.Margin = new Padding(3, 4, 3, 4);
            PwdTxt.Name = "PwdTxt";
            PwdTxt.Size = new Size(114, 27);
            PwdTxt.TabIndex = 1;
            PwdTxt.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 42);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 2;
            label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 80);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "Jelszó";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 228);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PwdTxt);
            Controls.Add(UsrTxt);
            Controls.Add(LoginBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Login";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginBtn;
        private TextBox UsrTxt;
        private TextBox PwdTxt;
        private Label label1;
        private Label label2;
    }
}