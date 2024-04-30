using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;

namespace teszt
{


    internal class db
    {
        static MySqlConnection conn;




        public static void Connect()
        {
            string connectionString = "Server=127.0.0.1; Database=mydb; User Id=root; Password=root;";
            conn = new MySqlConnection(connectionString);

            try
            {
                // Kapcsolat megnyitása
                conn.Open();
                //MessageBox.Show("Sikeres kapcsolodas.");

                // Kapcsolat használata...
            }
            catch (Exception ex)
            {
                // Hiba kezelése
                MessageBox.Show("Hiba történt: " + ex.Message);
            }
        }

        public static void Disconnect()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a kapcsolat megszakitasa soran: "+ex.Message);
            }
        }

        public static int LogIn(string username, string password)
        {
            MySqlCommand cmd = new MySqlCommand("Select Count(*) As sum From users Where Username='"+username+"' AND Password='"+password+"'", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader["sum"].ToString());
            }

            int tipus=0;

            reader.Dispose();

            cmd = new MySqlCommand("Select Type From users where Username='" + username + "' AND Password='" + password + "';", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tipus=int.Parse(reader["Type"].ToString());
            }

            reader.Dispose();
            reader.Close();

            if(tipus >= 0) 
            {
                return tipus;
            }
            return 0;
        }

        public void addproduct(string name, int size, int price)
        {
            Connect();
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into products(ProductName, Quantity, Price) Values(@v1,@v2,@v3);", conn);
                cmd.Parameters.AddWithValue("@v1", name);
                cmd.Parameters.AddWithValue("@v2", size);
                cmd.Parameters.AddWithValue("@v3", price);

                int aff_row = cmd.ExecuteNonQuery();

            }



            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message);
            }
            Disconnect();
        }

        public void updateproduct(string upname, int newprice)
        {
            Connect();
            MySqlCommand cmd = new MySqlCommand("UPDATE products SET Price=@price WHERE ProductName=@name;", conn);

            cmd.Parameters.AddWithValue("@name", upname);
            cmd.Parameters.AddWithValue("@price", newprice);

            cmd.ExecuteNonQuery();

            Disconnect();
        }

        public void loadlb(ListBox lb)
        {
            lb.Items.Clear();

            Connect();
            MySqlCommand cmd = new MySqlCommand("Select * FROM users;", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lb.Items.Add(dr["UserName"]);
            }
        }

        public void delusr(string name,ListBox lb)
        {
            Connect();
            try
            {
                MySqlCommand cmd = new MySqlCommand("Delete From users where UserName=@name;",conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt: " + ex.Message);
            }
            Disconnect();
            loadlb(lb);
        }

        public void adduser(string name, string pwd, int per, ListBox lb)
        {
            Connect();
            try
            {
                MySqlCommand cmd = new MySqlCommand("Insert into users(UserName,Type,Password)Values(@p1,@p2,@p3);", conn);
                cmd.Parameters.AddWithValue("@p1", name);
                cmd.Parameters.AddWithValue("@P2", per);
                cmd.Parameters.AddWithValue("@P3", pwd);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            loadlb(lb);
        }
    }
}