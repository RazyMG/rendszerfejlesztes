namespace teszt
{
    partial class Admin
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
            usersLB = new ListBox();
            getbtn = new Button();
            usrtxt = new TextBox();
            pwdtxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            permissionCB = new ComboBox();
            SuspendLayout();
            // 
            // usersLB
            // 
            usersLB.FormattingEnabled = true;
            usersLB.ItemHeight = 20;
            usersLB.Location = new Point(46, 68);
            usersLB.Margin = new Padding(3, 4, 3, 4);
            usersLB.Name = "usersLB";
            usersLB.Size = new Size(137, 184);
            usersLB.TabIndex = 0;
            usersLB.SelectedIndexChanged += usersLB_SelectedIndexChanged;
            // 
            // getbtn
            // 
            getbtn.Location = new Point(67, 305);
            getbtn.Margin = new Padding(3, 4, 3, 4);
            getbtn.Name = "getbtn";
            getbtn.Size = new Size(86, 31);
            getbtn.TabIndex = 2;
            getbtn.Text = "Torol";
            getbtn.UseVisualStyleBackColor = true;
            getbtn.Click += getbtn_Click;
            // 
            // usrtxt
            // 
            usrtxt.Location = new Point(385, 124);
            usrtxt.Margin = new Padding(3, 4, 3, 4);
            usrtxt.Name = "usrtxt";
            usrtxt.Size = new Size(114, 27);
            usrtxt.TabIndex = 3;
            // 
            // pwdtxt
            // 
            pwdtxt.Location = new Point(385, 192);
            pwdtxt.Margin = new Padding(3, 4, 3, 4);
            pwdtxt.Name = "pwdtxt";
            pwdtxt.Size = new Size(114, 27);
            pwdtxt.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 128);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 5;
            label1.Text = "Felhasznalonev:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 196);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 5;
            label2.Text = "Jelszo:";
            // 
            // button1
            // 
            button1.Location = new Point(344, 305);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 6;
            button1.Text = "Add user";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 247);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 7;
            label3.Text = "jogkör:";
            // 
            // permissionCB
            // 
            permissionCB.FormattingEnabled = true;
            permissionCB.Location = new Point(385, 247);
            permissionCB.Margin = new Padding(3, 4, 3, 4);
            permissionCB.Name = "permissionCB";
            permissionCB.Size = new Size(138, 28);
            permissionCB.TabIndex = 8;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 391);
            Controls.Add(permissionCB);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pwdtxt);
            Controls.Add(usrtxt);
            Controls.Add(getbtn);
            Controls.Add(usersLB);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin";
            Text = "Admin";
            FormClosed += Admin_FormClosed;
            Load += Admin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox usersLB;
        private Button getbtn;
        private TextBox usrtxt;
        private TextBox pwdtxt;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private ComboBox permissionCB;
    }
}