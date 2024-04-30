namespace teszt
{
    partial class WHWorker
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
            dgvList = new DataGridView();
            bListProjects = new Button();
            bListPartsOfProject = new Button();
            dgvParts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParts).BeginInit();
            SuspendLayout();
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(12, 64);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 51;
            dgvList.RowTemplate.Height = 29;
            dgvList.Size = new Size(472, 188);
            dgvList.TabIndex = 36;
            dgvList.Visible = false;
            // 
            // bListProjects
            // 
            bListProjects.Location = new Point(161, 12);
            bListProjects.Name = "bListProjects";
            bListProjects.Size = new Size(177, 29);
            bListProjects.TabIndex = 35;
            bListProjects.Text = "Projektek listázása";
            bListProjects.UseVisualStyleBackColor = true;
            bListProjects.Click += bListProjects_Click;
            // 
            // bListPartsOfProject
            // 
            bListPartsOfProject.Location = new Point(161, 279);
            bListPartsOfProject.Name = "bListPartsOfProject";
            bListPartsOfProject.Size = new Size(177, 48);
            bListPartsOfProject.TabIndex = 37;
            bListPartsOfProject.Text = "Projekthez tartozó alkatrészek";
            bListPartsOfProject.UseVisualStyleBackColor = true;
            bListPartsOfProject.Click += bListPartsOfProject_Click;
            // 
            // dgvParts
            // 
            dgvParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParts.Location = new Point(12, 333);
            dgvParts.Name = "dgvParts";
            dgvParts.RowHeadersWidth = 51;
            dgvParts.RowTemplate.Height = 29;
            dgvParts.Size = new Size(472, 188);
            dgvParts.TabIndex = 38;
            dgvParts.Visible = false;
            // 
            // WHWorker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 533);
            Controls.Add(dgvParts);
            Controls.Add(bListPartsOfProject);
            Controls.Add(dgvList);
            Controls.Add(bListProjects);
            Name = "WHWorker";
            Text = "Warehouse Worker";
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvList;
        private Button bListProjects;
        private Button bListPartsOfProject;
        private DataGridView dgvParts;
    }
}