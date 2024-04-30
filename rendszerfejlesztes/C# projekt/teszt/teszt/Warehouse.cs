using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teszt
{
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }


        private void Warehouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void bNewComponent_Click(object sender, EventArgs e)
        {
            lName.Visible = true;
            tbName.Visible = true;
            lPrice.Visible = true;
            tbPrice.Visible = true;
            lMax.Visible = true;
            tbMax.Visible = true;
            bAdd.Visible = true;
        }

        private void bPriceUpdate_Click(object sender, EventArgs e)
        {
            lUpdateName.Visible = true;
            tbUpdateName.Visible = true;
            lNewPrice.Visible = true;
            tbNewPrice.Visible = true;
            bUpdatePrice.Visible = true;
        }

        private void Warehouse_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private async void bAdd_Click(object sender, EventArgs e)
        {
            string prname = "";
            int prprice = 0, quantity = 0;
            prname = tbName.Text.ToString();
            prprice = int.Parse(tbPrice.Text.ToString());
            quantity = int.Parse(tbMax.Text.ToString());

            var url = "http://localhost:8000/api/product/create";
            var data = new Dictionary<string, string>
            {
                { "ProductName", prname },
                { "Quantity", quantity.ToString() },
                { "Price", prprice.ToString()}
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


        private async void bUpdatePrice_Click(object sender, EventArgs e)
        {
            string name = tbUpdateName.Text.ToString();
            int newprice = int.Parse(tbNewPrice.Text.ToString());

            var url = "http://localhost:8000/api/product/" + name;
            var data = new Dictionary<string, string>
            {
                { "price",  newprice.ToString()}
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

        private int parseInt(TextBox tbName)
        {
            int num;
            if (int.TryParse(tbMQUName.Text, out num))
            {
                return num;
            }
            else
            {
                Console.WriteLine("Value at {0} is not a number.", tbName.ToString());
            }
            return -1;
        }

        private async void bMQURun_Click(object sender, EventArgs e)
        {
            string name = tbMQUName.Text.ToString();
            int quantity = int.Parse(tbMQUQuantity.Text.ToString());

            var url = "http://localhost:8000/api/product/updatequantity/" + name;
            var data = new Dictionary<string, string>
            {
                { "newquantity", quantity.ToString()}
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


        private void bMaxQuantityUpdate_Click(object sender, EventArgs e)
        {
            lMQUName.Visible = true;
            lMQUQuantity.Visible = true;
            tbMQUQuantity.Visible = true;
            tbMQUName.Visible = true;
            bMQURun.Visible = true;
        }
    }
}
