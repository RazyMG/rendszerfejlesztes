using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Google.Protobuf.WellKnownTypes;
using System.Net;

namespace teszt
{
    public partial class Professional : Form
    {
        public Professional()
        {
            InitializeComponent();
        }
        private void bNewProject_Click(object sender, EventArgs e)
        {
            lNPDescription.Visible = true;
            lNPPlace.Visible = true;
            tbNPPlace.Visible = true;
            rtbNPDescription.Visible = true;
            bNPSave.Visible = true;
            dgvCustomers.Visible = true;
            lNPName.Visible = true;
            tbNPName.Visible = true;
        }

        private async Task<string> getCustomerID(string firstname, string lastname)
        {
            var url = "http://localhost:8000/api/customer/get";
            var data = new Dictionary<string, string>
            {
                { "FirstName", firstname},
                { "LastName", lastname}
            };

            using (var client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(data);
                var response = client.PostAsync(url, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Sikeres POST kérés. Válasz: {responseString}");
                    return responseString;
                }
                else
                {
                    MessageBox.Show($"Sikertelen POST kérés. Státuszkód: {response.StatusCode}");
                }
            }
            return "0";
        }

        struct customer
        {
            public string LastName;
            public string FirstName;
            public int id;
            public string city;
            public int zipcode;
            public string address;
        }
        private async void Professional_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("http://127.0.0.1:8000/api/customers/all");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<customer>>(content);
                    dgvCustomers.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Request failed with status code: " + response.StatusCode);
                }
            }
        }
        private async void bNPSave_Click(object sender, EventArgs e)
        {
            string projectname = tbNPName.Text.ToString();
            string place = tbNPPlace.Text.ToString();
            string description = rtbNPDescription.Text.ToString();
            int customerId;
            if (dgvCustomers.SelectedRows.Count == 1)
            {
                customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["Id"].Value);
            }
            else
            {
                MessageBox.Show("Kérem válasszon ki egy vásárlót.");
                return;
            }
            var url = "http://localhost:8000/api/project/create";
            var data = new Dictionary<string, string>
            {
                { "ProjectName", projectname },
                { "CustomerId", customerId.ToString()},
                { "UserId", "1" },
                { "state", "1" },
                { "Place", place },
                { "Description", description },
                { "WorkTime", "0" },
                { "Price", "0" }
            };

            using (var client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(data);
                var response = client.PostAsync(url, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Sikeres POST kérés. Válasz: {responseString}");
                }
                else
                {
                    MessageBox.Show($"Sikertelen POST kérés. Státuszkód: {response.StatusCode}");
                }
            }

        }

        private void bNewClient_Click(object sender, EventArgs e)
        {
            lNCAdress.Visible = true;
            lNCCity.Visible = true;
            lNCFirstName.Visible = true;
            lNCLastName.Visible = true;
            lNCZip.Visible = true;
            tbNCAdress.Visible = true;
            tbNCCity.Visible = true;
            tbNCFirstName.Visible = true;
            tbNCLastName.Visible = true;
            tbNCZip.Visible = true;
            bNCSave.Visible = true;
        }

        private void bSetWorkingTimeAndPrice_Click(object sender, EventArgs e)
        {
            lAMMProjectName.Visible = true;
            tbAMMProjectName.Visible = true;
            lWorkTime.Visible = true;
            tbWorkTime.Visible = true;
            lCost.Visible = true;
            tbCost.Visible = true;
            bTPRun.Visible = true;
        }

        private async void bTPRun_Click(object sender, EventArgs e)
        {
            string projectname = tbAMMProjectName.Text.ToString();
            string munkaido = tbWorkTime.Text.ToString();
            string munkadij = tbCost.Text.ToString();
            var url = "http://localhost:8000/api/project/addworktimeandprice/" + projectname;
            var data = new Dictionary<string, string>
            {

                { "workhour", munkaido },
                { "newprice", munkadij }
            };

            using (var client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(data);
                var response = await client.PutAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Sikeres PUT kérés. Válasz: {responseString}");
                }
                else
                {
                    MessageBox.Show($"Sikertelen PUT kérés. Státuszkód: {response.StatusCode}");
                }
            }
        }

        private async void bNCSave_Click(object sender, EventArgs e)
        {
            string firstname = tbNCFirstName.Text.ToString();
            string lastname = tbNCLastName.Text.ToString();
            string city = tbNCCity.Text.ToString();
            string address = tbNCAdress.Text.ToString();
            string zip = tbNCZip.Text.ToString();

            var url = "http://localhost:8000/api/customer/create";
            var data = new Dictionary<string, string>
            {
                { "FirstName", firstname},
                { "LastName", lastname},
                { "City", city},
                { "Address", address},
                { "Zipcode", zip},
            };

            using (var client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(data);
                var response = client.PostAsync(url, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Sikeres POST kérés. Válasz: {responseString}");
                }
                else
                {
                    MessageBox.Show($"Sikertelen POST kérés. Státuszkód: {response.StatusCode}");
                }
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
                dgvList.Columns.Clear();
                //dgvList.Rows.Clear();
                dgvList.Columns.Add("Id", "Id");
                dgvList.Columns.Add("ProjectName", "Project Name");
                dgvList.Columns.Add("Description", "Description");
                dgvList.Columns.Add("state", "state");

                dgvList.Columns["Id"].DataPropertyName = "Id";
                dgvList.Columns["ProjectName"].DataPropertyName = "ProjectName";
                dgvList.Columns["Description"].DataPropertyName = "Description";
                dgvList.Columns["state"].DataPropertyName = "state";
            }
            else
            {
                MessageBox.Show("Request failed with status code: " + response.StatusCode);
            }
        }

        class product
        {
            public int Id { get; set; }
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public int Price { get; set; }
            public int SumReserved { get; set; }
            public int SumAvailable { get; set; }

        }

        private async void bListParts_Click(object sender, EventArgs e)
        {
            dgvList.Visible = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using var client = new HttpClient();

            var response = await client.GetAsync("http://127.0.0.1:8000/api/product");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                MessageBox.Show(content);
                var data = JsonConvert.DeserializeObject<List<product>>(content);
                dgvList.DataSource = data;
                dgvList.Columns.Clear();
                dgvList.Columns.Add("Id", "Id");
                dgvList.Columns.Add("ProductName", "Product Name");
                dgvList.Columns.Add("Quantity", "Max Quantity");
                dgvList.Columns.Add("Price", "Price");

                dgvList.Columns["Id"].DataPropertyName = "Id";
                dgvList.Columns["ProductName"].DataPropertyName = "ProductName";
                dgvList.Columns["Quantity"].DataPropertyName = "Quantity";
                dgvList.Columns["Price"].DataPropertyName = "Price";
            }
            else
            {
                MessageBox.Show("Request failed with status code: " + response.StatusCode);
            }
        }
    }
}
