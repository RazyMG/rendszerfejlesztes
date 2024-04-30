using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teszt
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void getbtn_Click(object sender, EventArgs e)
        {
            string usr = "";
            if (usersLB.SelectedItem != null)
            {
                usr = usersLB.SelectedItem.ToString();
                db db = new db();
                db.delusr(usr, usersLB);

            }
            else
            {
                MessageBox.Show("Jelöljön ki egy felhasználót");
            }





        }

        private void usersLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            db db = new db();
            db.loadlb(usersLB);
            ComboboxItem it = new ComboboxItem();
            it.text = "Specialist";
            it.value = 4;
            permissionCB.Items.Add(it);
            it = new ComboboxItem();
            it.text = "Warehouseman";
            it.value = 3;
            permissionCB.Items.Add(it);
            it = new ComboboxItem();
            it.text = "Mananger";
            it.value = 2;
            permissionCB.Items.Add(it);
            it = new ComboboxItem();
            it.text = "Admin";
            it.value = 1;
            permissionCB.Items.Add(it);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usr = usrtxt.Text;
            string pwd = pwdtxt.Text;
            db db = new db();


            int vl = (permissionCB.SelectedItem as ComboboxItem).value;
            if (vl > 0)
            {
                MessageBox.Show(vl.ToString());
                db.adduser(usr, pwd, vl, usersLB);
            }
            else
            {
                MessageBox.Show("adjon meg jogosultságot");
            }

        }
    }
}
