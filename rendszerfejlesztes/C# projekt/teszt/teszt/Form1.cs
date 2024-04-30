
namespace teszt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pwd, usr;

            usr = UsrTxt.Text.ToString();
            pwd = PwdTxt.Text.ToString();

            db.Connect();


            int jogosultsag = db.LogIn(usr, pwd);
            db.Disconnect();


            switch (jogosultsag)
            {
                case 0:
                    MessageBox.Show("nincs ilyen felhasználó.");
                    break;
                case 1:
                    this.Hide();
                    Form admin = new Admin();
                    this.Owner = admin;
                    admin.Show();
                    break;
                case 2:
                    this.Hide();
                    Form wh = new Warehouse();
                    wh.Show();
                    break;
                case 4:
                    this.Hide();
                    Form spec = new Professional();
                    spec.Show();
                    break;
                default:
                    MessageBox.Show("nincs ilyen felhasználó.");
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}