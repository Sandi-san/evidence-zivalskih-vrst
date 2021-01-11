using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using evidence_zivalskih_vrst;
using System.Windows.Forms; //za ListBox in Form1 fore
using Atributi;

namespace evidence_zivalskih_vrst
{
    public class Database
    {
        private NpgsqlConnection con;
        
        public Database()
        {
            con = new NpgsqlConnection("User ID=grnijxyysgxoft;Password=b5f4443d4fac619bece45a244e8e460cfb04b925e4004629a38619661145a9d8;Host=ec2-3-251-0-202.eu-west-1.compute.amazonaws.com;Port=5432;Database=darujdc2hvtbsg;Pooling=true;SSL Mode=Require;TrustServerCertificate=True;");
            //con = new NpgsqlConnection("Server=ec2-3-251-0-202.eu-west-1.compute.amazonaws.com; User Id=grnijxyysgxoft;" + "Password=b5f4443d4fac619bece45a244e8e460cfb04b925e400629a38619661145a9d8; Database=darujdc2hvtbsg;");
        }

        public void ViewKraji(ListBox listBoxKraji)
        {
            using(con)
            {
                con.Open();

                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM kraji;",con);
                    com.ExecuteNonQuery();

                    NpgsqlDataReader listKraji = com.ExecuteReader();

                    listBoxKraji.Items.Clear();

                    while(listKraji.Read())
                    {
                        string imeKraj = listKraji.GetString(1);
                        string cifraPosta = listKraji.GetString(2);
                        //string velikiUporabnik = listKraji.GetString(3);

                        listBoxKraji.Items.Add(imeKraj + " " + cifraPosta);
                    }

                    listKraji.Close();

                    com.Dispose();
                

                con.Dispose();
            }
        }

        public void NovKraj(Kraj novKraj)
        {
            using (con) //connection uporabljen le v življenjski dobi item-a
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("INSERT INTO kraji (ime, posta, veliki_uporabniki) VALUES ('" + novKraj.ImeKraja + "', '" + novKraj.CifraKraja + "', '" + novKraj.VelikiUporabnik + "');", con);
               
                    com.ExecuteNonQuery();

                    com.Dispose();
                

                con.Close();
            }
        }

        public void UpdateKraj(Kraj updateKraj, int IDlistBoxKraji)
        {
            using (con) //connection uporabljen le v življenjski dobi item-a
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("UPDATE kraji SET ime = '" +updateKraj.ImeKraja + "', posta = '" + updateKraj.CifraKraja + "', veliki_uporabniki = '" + updateKraj.VelikiUporabnik + "' WHERE id_k = '" + IDlistBoxKraji + "';", con);

                com.ExecuteNonQuery();

                com.Dispose();


                con.Close();
            }
        }

        public void DeleteKraj(int IDlistBoxKraji)
        {
            using (con) //connection uporabljen le v življenjski dobi item-a
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("DELETE FROM kraji WHERE id_k = '" + IDlistBoxKraji + "';", con);

                com.ExecuteNonQuery();

                com.Dispose();


                con.Close();
            }
        }
    }
}


/*
ItemsDatabase id = new ItemsDatabase();
                    id.ReadItems(listBox1);
    */