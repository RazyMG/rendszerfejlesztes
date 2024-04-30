namespace teszt
{
    partial class Professional
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
            bNewProject = new Button();
            lNPPlace = new Label();
            tbNPPlace = new TextBox();
            lNPDescription = new Label();
            rtbNPDescription = new RichTextBox();
            bNPSave = new Button();
            bListProjects = new Button();
            bListParts = new Button();
            tbNPName = new TextBox();
            lNPName = new Label();
            tbAMMProjectName = new TextBox();
            lAMMProjectName = new Label();
            tbWorkTime = new TextBox();
            lWorkTime = new Label();
            tbCost = new TextBox();
            lCost = new Label();
            bTPRun = new Button();
            dgvList = new DataGridView();
            bNewClient = new Button();
            tbNCLastName = new TextBox();
            lNCLastName = new Label();
            tbNCFirstName = new TextBox();
            lNCFirstName = new Label();
            tbNCAdress = new TextBox();
            lNCAdress = new Label();
            tbNCCity = new TextBox();
            lNCCity = new Label();
            tbNCZip = new TextBox();
            lNCZip = new Label();
            bNCSave = new Button();
            bSetWorkingTimeAndPrice = new Button();
            dgvCustomers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // bNewProject
            // 
            bNewProject.Location = new Point(91, 12);
            bNewProject.Name = "bNewProject";
            bNewProject.Size = new Size(94, 29);
            bNewProject.TabIndex = 0;
            bNewProject.Text = "Új projekt";
            bNewProject.UseVisualStyleBackColor = true;
            bNewProject.Click += bNewProject_Click;
            // 
            // lNPPlace
            // 
            lNPPlace.AutoSize = true;
            lNPPlace.Location = new Point(12, 103);
            lNPPlace.Name = "lNPPlace";
            lNPPlace.Size = new Size(114, 20);
            lNPPlace.TabIndex = 1;
            lNPPlace.Text = "Projekt helyszín:";
            lNPPlace.Visible = false;
            // 
            // tbNPPlace
            // 
            tbNPPlace.Location = new Point(146, 100);
            tbNPPlace.Name = "tbNPPlace";
            tbNPPlace.Size = new Size(125, 27);
            tbNPPlace.TabIndex = 2;
            tbNPPlace.Visible = false;
            // 
            // lNPDescription
            // 
            lNPDescription.AutoSize = true;
            lNPDescription.Location = new Point(12, 136);
            lNPDescription.Name = "lNPDescription";
            lNPDescription.Size = new Size(105, 20);
            lNPDescription.TabIndex = 3;
            lNPDescription.Text = "Projekt leírása:";
            lNPDescription.Visible = false;
            // 
            // rtbNPDescription
            // 
            rtbNPDescription.Location = new Point(146, 133);
            rtbNPDescription.Name = "rtbNPDescription";
            rtbNPDescription.Size = new Size(125, 120);
            rtbNPDescription.TabIndex = 9;
            rtbNPDescription.Text = "";
            rtbNPDescription.Visible = false;
            // 
            // bNPSave
            // 
            bNPSave.Location = new Point(91, 374);
            bNPSave.Name = "bNPSave";
            bNPSave.Size = new Size(94, 29);
            bNPSave.TabIndex = 12;
            bNPSave.Text = "Mentés";
            bNPSave.UseVisualStyleBackColor = true;
            bNPSave.Visible = false;
            bNPSave.Click += bNPSave_Click;
            // 
            // bListProjects
            // 
            bListProjects.Location = new Point(336, 12);
            bListProjects.Name = "bListProjects";
            bListProjects.Size = new Size(177, 29);
            bListProjects.TabIndex = 14;
            bListProjects.Text = "Projektek listázása";
            bListProjects.UseVisualStyleBackColor = true;
            bListProjects.Click += bListProjects_Click;
            // 
            // bListParts
            // 
            bListParts.Location = new Point(533, 12);
            bListParts.Name = "bListParts";
            bListParts.Size = new Size(177, 29);
            bListParts.TabIndex = 15;
            bListParts.Text = "Alkatrészek listázása";
            bListParts.UseVisualStyleBackColor = true;
            bListParts.Click += bListParts_Click;
            // 
            // tbNPName
            // 
            tbNPName.Location = new Point(146, 67);
            tbNPName.Name = "tbNPName";
            tbNPName.Size = new Size(125, 27);
            tbNPName.TabIndex = 20;
            tbNPName.Visible = false;
            // 
            // lNPName
            // 
            lNPName.AutoSize = true;
            lNPName.Location = new Point(12, 70);
            lNPName.Name = "lNPName";
            lNPName.Size = new Size(93, 20);
            lNPName.TabIndex = 19;
            lNPName.Text = "Projekt neve:";
            lNPName.Visible = false;
            // 
            // tbAMMProjectName
            // 
            tbAMMProjectName.Location = new Point(853, 96);
            tbAMMProjectName.Name = "tbAMMProjectName";
            tbAMMProjectName.Size = new Size(129, 27);
            tbAMMProjectName.TabIndex = 22;
            tbAMMProjectName.Visible = false;
            // 
            // lAMMProjectName
            // 
            lAMMProjectName.AutoSize = true;
            lAMMProjectName.Location = new Point(755, 99);
            lAMMProjectName.Name = "lAMMProjectName";
            lAMMProjectName.Size = new Size(93, 20);
            lAMMProjectName.TabIndex = 21;
            lAMMProjectName.Text = "Projekt neve:";
            lAMMProjectName.Visible = false;
            // 
            // tbWorkTime
            // 
            tbWorkTime.Location = new Point(853, 133);
            tbWorkTime.Name = "tbWorkTime";
            tbWorkTime.Size = new Size(125, 27);
            tbWorkTime.TabIndex = 28;
            tbWorkTime.Visible = false;
            // 
            // lWorkTime
            // 
            lWorkTime.AutoSize = true;
            lWorkTime.Location = new Point(769, 136);
            lWorkTime.Name = "lWorkTime";
            lWorkTime.Size = new Size(78, 20);
            lWorkTime.TabIndex = 27;
            lWorkTime.Text = "Munkaidő:";
            lWorkTime.Visible = false;
            // 
            // tbCost
            // 
            tbCost.Location = new Point(853, 168);
            tbCost.Name = "tbCost";
            tbCost.Size = new Size(125, 27);
            tbCost.TabIndex = 30;
            tbCost.Visible = false;
            // 
            // lCost
            // 
            lCost.AutoSize = true;
            lCost.Location = new Point(774, 171);
            lCost.Name = "lCost";
            lCost.Size = new Size(73, 20);
            lCost.TabIndex = 29;
            lCost.Text = "Munkadíj:";
            lCost.Visible = false;
            // 
            // bTPRun
            // 
            bTPRun.Location = new Point(831, 228);
            bTPRun.Name = "bTPRun";
            bTPRun.Size = new Size(94, 29);
            bTPRun.TabIndex = 32;
            bTPRun.Text = "Rögzít";
            bTPRun.UseVisualStyleBackColor = true;
            bTPRun.Visible = false;
            bTPRun.Click += bTPRun_Click;
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(277, 65);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 51;
            dgvList.RowTemplate.Height = 29;
            dgvList.Size = new Size(472, 188);
            dgvList.TabIndex = 34;
            dgvList.Visible = false;
            // 
            // bNewClient
            // 
            bNewClient.Location = new Point(66, 420);
            bNewClient.Name = "bNewClient";
            bNewClient.Size = new Size(124, 29);
            bNewClient.TabIndex = 36;
            bNewClient.Text = "Új megrendelő";
            bNewClient.UseVisualStyleBackColor = true;
            bNewClient.Click += bNewClient_Click;
            // 
            // tbNCLastName
            // 
            tbNCLastName.Location = new Point(196, 508);
            tbNCLastName.Name = "tbNCLastName";
            tbNCLastName.Size = new Size(125, 27);
            tbNCLastName.TabIndex = 40;
            tbNCLastName.Visible = false;
            // 
            // lNCLastName
            // 
            lNCLastName.AutoSize = true;
            lNCLastName.Location = new Point(12, 511);
            lNCLastName.Name = "lNCLastName";
            lNCLastName.Size = new Size(174, 20);
            lNCLastName.TabIndex = 39;
            lNCLastName.Text = "Megrendelő keresztneve:";
            lNCLastName.Visible = false;
            // 
            // tbNCFirstName
            // 
            tbNCFirstName.Location = new Point(196, 463);
            tbNCFirstName.Name = "tbNCFirstName";
            tbNCFirstName.Size = new Size(125, 27);
            tbNCFirstName.TabIndex = 38;
            tbNCFirstName.Visible = false;
            // 
            // lNCFirstName
            // 
            lNCFirstName.AutoSize = true;
            lNCFirstName.Location = new Point(12, 466);
            lNCFirstName.Name = "lNCFirstName";
            lNCFirstName.Size = new Size(178, 20);
            lNCFirstName.TabIndex = 37;
            lNCFirstName.Text = "Megrendelő vezetékneve:";
            lNCFirstName.Visible = false;
            // 
            // tbNCAdress
            // 
            tbNCAdress.Location = new Point(413, 508);
            tbNCAdress.Name = "tbNCAdress";
            tbNCAdress.Size = new Size(125, 27);
            tbNCAdress.TabIndex = 44;
            tbNCAdress.Visible = false;
            // 
            // lNCAdress
            // 
            lNCAdress.AutoSize = true;
            lNCAdress.Location = new Point(349, 511);
            lNCAdress.Name = "lNCAdress";
            lNCAdress.Size = new Size(58, 20);
            lNCAdress.TabIndex = 43;
            lNCAdress.Text = "Lakcím:";
            lNCAdress.Visible = false;
            // 
            // tbNCCity
            // 
            tbNCCity.Location = new Point(413, 463);
            tbNCCity.Name = "tbNCCity";
            tbNCCity.Size = new Size(125, 27);
            tbNCCity.TabIndex = 42;
            tbNCCity.Visible = false;
            // 
            // lNCCity
            // 
            lNCCity.AutoSize = true;
            lNCCity.Location = new Point(349, 466);
            lNCCity.Name = "lNCCity";
            lNCCity.Size = new Size(48, 20);
            lNCCity.TabIndex = 41;
            lNCCity.Text = "Város:";
            lNCCity.Visible = false;
            // 
            // tbNCZip
            // 
            tbNCZip.Location = new Point(413, 552);
            tbNCZip.Name = "tbNCZip";
            tbNCZip.Size = new Size(125, 27);
            tbNCZip.TabIndex = 46;
            tbNCZip.Visible = false;
            // 
            // lNCZip
            // 
            lNCZip.AutoSize = true;
            lNCZip.Location = new Point(310, 555);
            lNCZip.Name = "lNCZip";
            lNCZip.Size = new Size(96, 20);
            lNCZip.TabIndex = 45;
            lNCZip.Text = "Irányítószám:";
            lNCZip.Visible = false;
            // 
            // bNCSave
            // 
            bNCSave.Location = new Point(310, 420);
            bNCSave.Name = "bNCSave";
            bNCSave.Size = new Size(94, 29);
            bNCSave.TabIndex = 47;
            bNCSave.Text = "Mentés";
            bNCSave.UseVisualStyleBackColor = true;
            bNCSave.Visible = false;
            bNCSave.Click += bNCSave_Click;
            // 
            // bSetWorkingTimeAndPrice
            // 
            bSetWorkingTimeAndPrice.Location = new Point(797, 12);
            bSetWorkingTimeAndPrice.Name = "bSetWorkingTimeAndPrice";
            bSetWorkingTimeAndPrice.Size = new Size(156, 49);
            bSetWorkingTimeAndPrice.TabIndex = 48;
            bSetWorkingTimeAndPrice.Text = "Munkaidő és munkadíj rögzítése";
            bSetWorkingTimeAndPrice.UseVisualStyleBackColor = true;
            bSetWorkingTimeAndPrice.Click += bSetWorkingTimeAndPrice_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(12, 259);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.RowTemplate.Height = 29;
            dgvCustomers.Size = new Size(259, 109);
            dgvCustomers.TabIndex = 49;
            // 
            // Professional
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 603);
            Controls.Add(dgvCustomers);
            Controls.Add(bSetWorkingTimeAndPrice);
            Controls.Add(bNCSave);
            Controls.Add(tbNCZip);
            Controls.Add(lNCZip);
            Controls.Add(tbNCAdress);
            Controls.Add(lNCAdress);
            Controls.Add(tbNCCity);
            Controls.Add(lNCCity);
            Controls.Add(tbNCLastName);
            Controls.Add(lNCLastName);
            Controls.Add(tbNCFirstName);
            Controls.Add(lNCFirstName);
            Controls.Add(bNewClient);
            Controls.Add(dgvList);
            Controls.Add(bTPRun);
            Controls.Add(tbCost);
            Controls.Add(lCost);
            Controls.Add(tbWorkTime);
            Controls.Add(lWorkTime);
            Controls.Add(tbAMMProjectName);
            Controls.Add(lAMMProjectName);
            Controls.Add(tbNPName);
            Controls.Add(lNPName);
            Controls.Add(bListParts);
            Controls.Add(bListProjects);
            Controls.Add(bNPSave);
            Controls.Add(rtbNPDescription);
            Controls.Add(lNPDescription);
            Controls.Add(tbNPPlace);
            Controls.Add(lNPPlace);
            Controls.Add(bNewProject);
            Name = "Professional";
            Text = "Professional";
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bNewProject;
        private Label lNPPlace;
        private TextBox tbNPPlace;
        private Label lNPDescription;
        private RichTextBox rtbNPDescription;
        private Button bNPSave;
        private Button bListProjects;
        private Button bListParts;
        private Button bSetWorkingTime;
        private Button bSetCost;
        private TextBox tbNPName;
        private Label lNPName;
        private TextBox tbAMMProjectName;
        private Label lAMMProjectName;
        private TextBox tbWorkTime;
        private Label lWorkTime;
        private TextBox tbCost;
        private Label lCost;
        private Button bTPRun;
        private Button bCostRun;
        private DataGridView dgvList;
        private Button bNewClient;
        private TextBox tbNCLastName;
        private Label lNCLastName;
        private TextBox tbNCFirstName;
        private Label lNCFirstName;
        private TextBox tbNCAdress;
        private Label lNCAdress;
        private TextBox tbNCCity;
        private Label lNCCity;
        private TextBox tbNCZip;
        private Label lNCZip;
        private Button bNCSave;
        private Button bSetWorkingTimeAndPrice;
        private DataGridView dgvCustomers;
    }
}