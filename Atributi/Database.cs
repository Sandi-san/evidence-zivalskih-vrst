using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using evidence_zivalskih_vrst;
using System.Windows.Forms; //za ListBox in Form1 fore

namespace evidence_zivalskih_vrst
{
    public class Database
    {
        private NpgsqlConnection con;
        
        public Database()
        {
            con = new NpgsqlConnection("Server=ec2-3-251-0-202.eu-west-1.compute.amazonaws.com; User Id=grnijxyysgxoft;" + "Password=b5f4443d4fac619bece45a244e8e460cfb04b925e400629a38619661145a9d8; Database=darujdc2hvtbsg;");
        }

        public void ViewKraji(ListBox listBoxKraji)
        {
            using(con)
            {
                con.Open();

                using (NpgsqlCommand com = new NpgsqlCommand())
                {
                    com.CommandText = "SELECT * FROM kraji;";
                    com.ExecuteNonQuery();

                    NpgsqlDataReader listKraji = com.ExecuteReader();

                    while(listKraji.Read())
                    {
                        string imeKraj = listKraji.GetString(1);
                        string cifraPosta = listKraji.GetString(2);
                        string velikiUporabnik = listKraji.GetString(3);

                        listBoxKraji.Items.Add(imeKraj + " " + cifraPosta + " " + velikiUporabnik);
                    }

                    listKraji.Close();

                    com.Dispose();
                }

                con.Dispose();
            }
        }
    }
}


/*
ItemsDatabase id = new ItemsDatabase();
                    id.ReadItems(listBox1);
    */