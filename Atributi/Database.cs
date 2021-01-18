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
        
        /*POVEZAVA Z BAZO*/
        public Database()
        {
            con = new NpgsqlConnection("User ID=grnijxyysgxoft;Password=b5f4443d4fac619bece45a244e8e460cfb04b925e4004629a38619661145a9d8;Host=ec2-3-251-0-202.eu-west-1.compute.amazonaws.com;Port=5432;Database=darujdc2hvtbsg;Pooling=true;SSL Mode=Require;TrustServerCertificate=True;");
            //con = new NpgsqlConnection("Server=ec2-3-251-0-202.eu-west-1.compute.amazonaws.com; User Id=grnijxyysgxoft;" + "Password=b5f4443d4fac619bece45a244e8e460cfb04b925e400629a38619661145a9d8; Database=darujdc2hvtbsg;");
        }

        /*PRIKAŽI KRAJ (V LISTBOXU)*/
        public void ViewKraji(ListBox listBoxKraji)
        {
            using(con)
            {
                con.Open();

                    NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM view_kraji();",con);
                    com.ExecuteNonQuery();

                    NpgsqlDataReader listKraji = com.ExecuteReader();

                    listBoxKraji.Items.Clear();

                    while(listKraji.Read())
                    {
                        //int idKraj = listKraji.GetInt32(0);
                        string imeKraj = listKraji.GetString(1);
                        string cifraPosta = listKraji.GetString(2);
                        //string velikiUporabnik = listKraji.GetString(3);

                        listBoxKraji.Items.Add(imeKraj + " (" + cifraPosta + ")");
                        //evidence_zivalskih_vrst.novKraj
                    }

                    listKraji.Close();

                    com.Dispose();
                

                con.Dispose();
            }
        }

        /*DODAJ KRAJ*/
        public void InsertKraj(Kraj novKraj)
        {
            using (con) //connection uporabljen le v življenjski dobi item-a
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT insert_kraji('" + novKraj.ImeKraja + "', '" + novKraj.CifraKraja + "', '" + novKraj.VelikiUporabnik + "');", con);
               
                    com.ExecuteNonQuery();

                    com.Dispose();
                

                con.Close();
            }
        }

        /*POSODOBI KRAJ*/
        public void UpdateKraj(Kraj updateKraj, int IDlistBoxKraji)
        {
            using (con) //connection uporabljen le v življenjski dobi item-a
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT update_kraji('" + updateKraj.ImeKraja + "', '" + updateKraj.CifraKraja + "', '" + updateKraj.VelikiUporabnik + "', '" + IDlistBoxKraji + "');", con);

                com.ExecuteNonQuery();

                com.Dispose();


                con.Close();
            }
        }

        /*ZBRIŠI KRAJ*/
        public void DeleteKraj(int IDlistBoxKraji)
        {
            using (con) //connection uporabljen le v življenjski dobi item-a
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT delete_kraji('" + IDlistBoxKraji + "');", con);

                com.ExecuteNonQuery();

                com.Dispose();


                con.Close();
            }
        }

        /*PRIKAŽI KRAJ (V LISTBOXU)*/
        public void ViewRazredi(ListBox listBoxRazredi)
        {
            using (con)
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM view_razredi();", con);
                com.ExecuteNonQuery();

                NpgsqlDataReader listRazredi = com.ExecuteReader();

                listBoxRazredi.Items.Clear();

                while (listRazredi.Read())
                {
                    //int idRazred = listRazredi.GetInt32(0);
                    string nazivRazred = listRazredi.GetString(1);

                    listBoxRazredi.Items.Add(nazivRazred);
                }

                listRazredi.Close();

                com.Dispose();


                con.Dispose();
            }
        }

        /*DODAJ RAZRED*/
        public void InsertRazred(Razred novRazred)
        {
            using (con) //connection uporabljen le v življenjski dobi item-a
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT insert_razredi('" + novRazred.NazivRazreda + "');", con);

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