using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teszt
{
    public partial class WHWorker : Form
    {
        public WHWorker()
        {
            InitializeComponent();
        }

        private async void bListProjects_Click(object sender, EventArgs e)
        {
            dgvList.Visible = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using var client = new HttpClient();

            var response = await client.GetAsync("http://127.0.0.1:8000/api/project/all");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                MessageBox.Show(content);
                var data = JsonConvert.DeserializeObject<List<Data>>(content);
                dgvList.DataSource = data;

            }
            else
            {

                MessageBox.Show("Request failed with status code: " + response.StatusCode);
            }
        }
        class Data
        {
            public int Id { get; set; }
            public string ProjectName { get; set; }
            public int CustomerId { get; set; }
            public int UserId { get; set; }
            public int state { get; set; }
            public string Place { get; set; }
            public string Description { get; set; }
            public string WorkTime { get; set; }
            public int Price { get; set; }
        }

        private async void bListPartsOfProject_Click(object sender, EventArgs e)
        {
            int projectId;
            if (dgvParts.SelectedRows.Count == 1)
            {
                projectId = Convert.ToInt32(dgvParts.CurrentRow.Cells["Id"].Value);
            }
            else
            {
                MessageBox.Show("Kérem válasszon ki egy vásárlót.");
                return;
            }

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using var client = new HttpClient();

            var response = await client.GetAsync("http://127.0.0.1:8000/api/product");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                MessageBox.Show(content);
                var data = JsonConvert.DeserializeObject<List<product>>(content);
                dgvList.DataSource = data;
            }
            else
            {
                MessageBox.Show("Request failed with status code: " + response.StatusCode);
            }
        }
        class product
        {
            public int projectId { get; set; }

            public string productName { get; set; }

            public int row { get; set; }

            public int level { get; set; }

            public char shelf { get; set; }
            
        }
    }
}
