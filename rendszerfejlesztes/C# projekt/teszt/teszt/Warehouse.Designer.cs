namespace teszt
{
    partial class Warehouse
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
            bNewComponent = new Button();
            lName = new Label();
            lPrice = new Label();
            lMax = new Label();
            tbName = new TextBox();
            tbPrice = new TextBox();
            tbMax = new TextBox();
            bAdd = new Button();
            bPriceUpdate = new Button();
            lUpdateName = new Label();
            lNewPrice = new Label();
            tbUpdateName = new TextBox();
            tbNewPrice = new TextBox();
            bUpdatePrice = new Button();
            bMaxQuantityUpdate = new Button();
            lMQUName = new Label();
            tbMQUName = new TextBox();
            bMQURun = new Button();
            tbMQUQuantity = new TextBox();
            lMQUQuantity = new Label();
            SuspendLayout();
            // 
            // bNewComponent
            // 
            bNewComponent.Location = new Point(127, 12);
            bNewComponent.Name = "bNewComponent";
            bNewComponent.Size = new Size(94, 29);
            bNewComponent.TabIndex = 0;
            bNewComponent.Text = "Új alkatrész";
            bNewComponent.UseVisualStyleBackColor = true;
            bNewComponent.Click += bNewComponent_Click;
            // 
            // lName
            // 
            lName.AutoSize = true;
            lName.Location = new Point(127, 69);
            lName.Name = "lName";
            lName.Size = new Size(38, 20);
            lName.TabIndex = 1;
            lName.Text = "Név:";
            lName.Visible = false;
            // 
            // lPrice
            // 
            lPrice.AutoSize = true;
            lPrice.Location = new Point(138, 117);
            lPrice.Name = "lPrice";
            lPrice.Size = new Size(27, 20);
            lPrice.TabIndex = 2;
            lPrice.Text = "Ár:";
            lPrice.Visible = false;
            // 
            // lMax
            // 
            lMax.AutoSize = true;
            lMax.Location = new Point(11, 165);
            lMax.Name = "lMax";
            lMax.Size = new Size(153, 40);
            lMax.TabIndex = 3;
            lMax.Text = "Maximális darabszám\r\negy rekeszben:";
            lMax.Visible = false;
            // 
            // tbName
            // 
            tbName.Location = new Point(171, 67);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 4;
            tbName.Visible = false;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(171, 115);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(125, 27);
            tbPrice.TabIndex = 5;
            tbPrice.Visible = false;
            // 
            // tbMax
            // 
            tbMax.Location = new Point(171, 165);
            tbMax.Name = "tbMax";
            tbMax.Size = new Size(125, 27);
            tbMax.TabIndex = 6;
            tbMax.Visible = false;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(127, 243);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(94, 29);
            bAdd.TabIndex = 7;
            bAdd.Text = "Hozzáad";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Visible = false;
            bAdd.Click += bAdd_Click;
            // 
            // bPriceUpdate
            // 
            bPriceUpdate.Location = new Point(514, 12);
            bPriceUpdate.Name = "bPriceUpdate";
            bPriceUpdate.Size = new Size(94, 29);
            bPriceUpdate.TabIndex = 8;
            bPriceUpdate.Text = "Ár frissítése";
            bPriceUpdate.UseVisualStyleBackColor = true;
            bPriceUpdate.Click += bPriceUpdate_Click;
            // 
            // lUpdateName
            // 
            lUpdateName.AutoSize = true;
            lUpdateName.Location = new Point(363, 69);
            lUpdateName.Name = "lUpdateName";
            lUpdateName.Size = new Size(180, 20);
            lUpdateName.TabIndex = 9;
            lUpdateName.Text = "Frissítendő alkatrész neve:";
            lUpdateName.Visible = false;
            // 
            // lNewPrice
            // 
            lNewPrice.AutoSize = true;
            lNewPrice.Location = new Point(501, 117);
            lNewPrice.Name = "lNewPrice";
            lNewPrice.Size = new Size(43, 20);
            lNewPrice.TabIndex = 10;
            lNewPrice.Text = "Új ár:";
            lNewPrice.Visible = false;
            // 
            // tbUpdateName
            // 
            tbUpdateName.Location = new Point(549, 67);
            tbUpdateName.Name = "tbUpdateName";
            tbUpdateName.Size = new Size(125, 27);
            tbUpdateName.TabIndex = 11;
            tbUpdateName.Visible = false;
            // 
            // tbNewPrice
            // 
            tbNewPrice.Location = new Point(549, 115);
            tbNewPrice.Name = "tbNewPrice";
            tbNewPrice.Size = new Size(125, 27);
            tbNewPrice.TabIndex = 12;
            tbNewPrice.Visible = false;
            // 
            // bUpdatePrice
            // 
            bUpdatePrice.Location = new Point(514, 165);
            bUpdatePrice.Name = "bUpdatePrice";
            bUpdatePrice.Size = new Size(94, 29);
            bUpdatePrice.TabIndex = 13;
            bUpdatePrice.Text = "Futtatás";
            bUpdatePrice.UseVisualStyleBackColor = true;
            bUpdatePrice.Visible = false;
            bUpdatePrice.Click += bUpdatePrice_Click;
            // 
            // bMaxQuantityUpdate
            // 
            bMaxQuantityUpdate.Location = new Point(753, 12);
            bMaxQuantityUpdate.Name = "bMaxQuantityUpdate";
            bMaxQuantityUpdate.Size = new Size(162, 29);
            bMaxQuantityUpdate.TabIndex = 14;
            bMaxQuantityUpdate.Text = "Max darab beállítása";
            bMaxQuantityUpdate.UseVisualStyleBackColor = true;
            bMaxQuantityUpdate.Click += bMaxQuantityUpdate_Click;
            // 
            // lMQUName
            // 
            lMQUName.AutoSize = true;
            lMQUName.Location = new Point(704, 70);
            lMQUName.Name = "lMQUName";
            lMQUName.Size = new Size(107, 20);
            lMQUName.TabIndex = 15;
            lMQUName.Text = "Alkatrész neve:";
            lMQUName.Visible = false;
            // 
            // tbMQUName
            // 
            tbMQUName.Location = new Point(817, 68);
            tbMQUName.Name = "tbMQUName";
            tbMQUName.Size = new Size(125, 27);
            tbMQUName.TabIndex = 18;
            tbMQUName.Visible = false;
            // 
            // bMQURun
            // 
            bMQURun.Location = new Point(777, 165);
            bMQURun.Name = "bMQURun";
            bMQURun.Size = new Size(96, 29);
            bMQURun.TabIndex = 21;
            bMQURun.Text = "Beállítás";
            bMQURun.UseVisualStyleBackColor = true;
            bMQURun.Visible = false;
            bMQURun.Click += bMQURun_Click;
            // 
            // tbMQUQuantity
            // 
            tbMQUQuantity.Location = new Point(817, 115);
            tbMQUQuantity.Name = "tbMQUQuantity";
            tbMQUQuantity.Size = new Size(125, 27);
            tbMQUQuantity.TabIndex = 23;
            tbMQUQuantity.Visible = false;
            // 
            // lMQUQuantity
            // 
            lMQUQuantity.AutoSize = true;
            lMQUQuantity.Location = new Point(728, 118);
            lMQUQuantity.Name = "lMQUQuantity";
            lMQUQuantity.Size = new Size(83, 20);
            lMQUQuantity.TabIndex = 22;
            lMQUQuantity.Text = "Max darab:";
            lMQUQuantity.Visible = false;
            // 
            // Warehouse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 314);
            Controls.Add(tbMQUQuantity);
            Controls.Add(lMQUQuantity);
            Controls.Add(bMQURun);
            Controls.Add(tbMQUName);
            Controls.Add(lMQUName);
            Controls.Add(bMaxQuantityUpdate);
            Controls.Add(bUpdatePrice);
            Controls.Add(tbNewPrice);
            Controls.Add(tbUpdateName);
            Controls.Add(lNewPrice);
            Controls.Add(lUpdateName);
            Controls.Add(bPriceUpdate);
            Controls.Add(bAdd);
            Controls.Add(tbMax);
            Controls.Add(tbPrice);
            Controls.Add(tbName);
            Controls.Add(lMax);
            Controls.Add(lPrice);
            Controls.Add(lName);
            Controls.Add(bNewComponent);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Warehouse";
            Text = "Warehouse";
            FormClosed += Warehouse_FormClosed_1;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button bNewComponent;
        private Label lName;
        private Label lPrice;
        private Label lMax;
        private TextBox tbName;
        private TextBox tbPrice;
        private TextBox tbMax;
        private Button bAdd;
        private Button bPriceUpdate;
        private Label lUpdateName;
        private Label lNewPrice;
        private TextBox tbUpdateName;
        private TextBox tbNewPrice;
        private Button bUpdatePrice;
        private Button bMaxQuantityUpdate;
        private Label lMQUName;
        private TextBox tbMQUName;
        private Button bMQURun;
        private TextBox tbMQUQuantity;
        private Label lMQUQuantity;
    }
}