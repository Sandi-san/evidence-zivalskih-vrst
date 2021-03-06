﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using evidence_zivalskih_vrst;
using System.Windows.Forms; //za ListBox in Form1 fore
using Atributi;
using System.Windows.Forms.DataVisualization.Charting;

namespace evidence_zivalskih_vrst
{
    public class Database
    {
        private NpgsqlConnection con;
        
        /*POVEZAVA Z BAZO (HEROKU)*/
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
                        if (string.IsNullOrEmpty(listKraji[3].ToString()))
                        {
                            string imeKraj = listKraji.GetString(1);
                            string cifraPosta = listKraji.GetString(2);
                            
                            listBoxKraji.Items.Add(imeKraj + " | " + cifraPosta);
                        }
                        else
                        {
                            string imeKraj = listKraji.GetString(1);
                            string cifraPosta = listKraji.GetString(2);
                            string velikiUporabnik = listKraji.GetString(3);

                            listBoxKraji.Items.Add(imeKraj + " | " + cifraPosta + " | " + velikiUporabnik);

                        }
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



        /*PRIKAŽI RAZRED*/
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

        /*POSODOBI RAZRED*/
        public void UpdateRazred(Razred updateRazred, int IDlistBoxRazredi)
        {
            using (con) //connection uporabljen le v življenjski dobi item-a
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT update_razredi('" + updateRazred.NazivRazreda + "', '" + IDlistBoxRazredi + "');", con);

                com.ExecuteNonQuery();

                com.Dispose();


                con.Close();
            }
        }

        /*ZBRIŠI RAZRED*/
        public void DeleteRazred(int IDlistBoxRazredi)
        {
            using (con) //connection uporabljen le v življenjski dobi item-a
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT delete_razredi('" + IDlistBoxRazredi + "');", con);

                com.ExecuteNonQuery();

                com.Dispose();


                con.Close();
            }
        }


        /*PRIKAŽI RAZRED*/
        public void ViewVrsta(ListBox listBoxVrste)
        {
            using (con)
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM view_vrste();", con);
                com.ExecuteNonQuery();

                NpgsqlDataReader listVrste = com.ExecuteReader();

                listBoxVrste.Items.Clear();

                while (listVrste.Read())
                {
                    //int idVrsta = listVrste.GetInt32(0);
                    string imeVrsta = listVrste.GetString(1);
                    string nazivRazreda = listVrste.GetString(2);

                    listBoxVrste.Items.Add(imeVrsta + " | " + nazivRazreda);
                }

                listVrste.Close();

                com.Dispose();


                con.Dispose();
            }
        }

        /*DODAJ VRSTE*/
        public void InsertVrsta(Vrsta novaVrsta, int IDlistBoxRazredi, int IDlistboxKraja)
        {
            using (con) //connection uporabljen le v življenjski dobi item-a
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT insert_vrste('" + novaVrsta.ImeVrste + "', '" + IDlistBoxRazredi + "', '" + IDlistboxKraja + "');", con);

                com.ExecuteNonQuery();

                com.Dispose();


                con.Close();
            }
        }

        /*UPDATE VRSTE*/
        public void UpdateVrsta(Vrsta updateVrsta, int IDlistBoxRazredi, int IDlistbox)
        {
            using (con) //connection uporabljen le v življenjski dobi item-a
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT update_vrste('" + updateVrsta.ImeVrste + "', '" + IDlistBoxRazredi + "', '" + IDlistbox + "');", con);

                com.ExecuteNonQuery();

                com.Dispose();


                con.Close();
            }
        }
        /*UPDATE KRAJ_VRSTE (če je spremenjen kraj)*/
        public void UpdateKrajVrsta(int IDlistBoxKraj, int IDlistbox)
        {
            using (con) //connection uporabljen le v življenjski dobi item-a
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT update_kraj_vrste('" + IDlistBoxKraj + "', '" + IDlistbox + "');", con);

                com.ExecuteNonQuery();

                com.Dispose();


                con.Close();
            }
        }
        /*DELETE VRSTE*/
        public void DeleteVrsta(int IDlistbox)
        {
            using (con) //connection uporabljen le v življenjski dobi item-a
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT delete_vrste('" + IDlistbox + "');", con);

                com.ExecuteNonQuery();

                com.Dispose();


                con.Close();
            }
        }

        /*VIEW KOLIKO VRST V TEM KRAJU (FORM 1)*/
        public void ViewByKraj(Label labelByKraj, int IDlistBoxKraji, Chart chart1)
        {
            using (con)
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT view_by_kraj('" + IDlistBoxKraji + "');", con);
                com.ExecuteNonQuery();

                NpgsqlDataReader getNumber = com.ExecuteReader();

                //Pobriše vsebino starega grafa
                chart1.Series[0].Points.Clear();

                while (getNumber.Read())
                {
                    int stevilo = getNumber.GetInt32(0);
                    //string ime = getNumber.GetString(1);

                    labelByKraj.Text = stevilo.ToString();

                    chart1.Series["Število"].Points.AddXY("Kraj", stevilo.ToString());
                }

                getNumber.Close();

                com.Dispose();


                con.Dispose();
            }
        }

        /*VIEW V KOLIKO KRAJIH TA VRSTA (FORM 1)*/
        public void ViewByVrste(Label labelByVrste, int IDlistboxVrsta, Chart chart1)
        {
            using (con)
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT view_by_vrste('" + IDlistboxVrsta + "');", con);
                com.ExecuteNonQuery();

                NpgsqlDataReader getNumber = com.ExecuteReader();

                //Pobriše vsebino starega grafa
                chart1.Series[0].Points.Clear();

                while (getNumber.Read())
                {
                    int stevilo = getNumber.GetInt32(0);
                    //string ime = getNumber.GetString(1);

                    labelByVrste.Text = stevilo.ToString();

                    chart1.Series["Število"].Points.AddXY("Vrsta", stevilo.ToString());
                }

                getNumber.Close();

                com.Dispose();


                con.Dispose();
            }
        }

        /*PRIDOBI SETTINGS*/
        public void ViewSettings(Label l_font, Label l_background)
        {
            using (con)
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM view_settings();", con);
                com.ExecuteNonQuery();

                NpgsqlDataReader settings = com.ExecuteReader();

                while (settings.Read())
                {
                    //Če je v bazi null, bo ustrezne atribute dal na default
                    //default font = black, default background = white
                    if (string.IsNullOrEmpty(settings[1].ToString()))
                    {
                        if (string.IsNullOrEmpty(settings[2].ToString()))
                        {
                            l_font.Text = "black";
                            l_background.Text = "white";
                        }
                        else
                        {
                            string s_background = settings.GetString(2);

                            l_font.Text = "black";
                            l_background.Text = s_background.ToString();
                        }
                    }
                    else if (string.IsNullOrEmpty(settings[2].ToString()))
                    {
                        if (string.IsNullOrEmpty(settings[1].ToString()))
                        {
                            l_font.Text = "black";
                            l_background.Text = "white";
                        }
                        else
                        {
                            string s_font = settings.GetString(1);

                            l_font.Text = s_font.ToString();
                            l_background.Text = "white";
                        }

                    }
                    else
                    {
                        //int idVrsta = listVrste.GetInt32(0);
                        string s_font = settings.GetString(1);
                        string s_background = settings.GetString(2);

                        l_font.Text = s_font.ToString();
                        l_background.Text = s_background.ToString();
                    }
                }

                settings.Close();

                com.Dispose();


                con.Dispose();
            }
        }
        /*Spremeni barve (doda nove vrednosti v tabelo)*/
        public void UpdateSettings(string font, string background)
        {
            using (con) //connection uporabljen le v življenjski dobi item-a
            {
                con.Open();

                NpgsqlCommand com = new NpgsqlCommand("SELECT update_settings('" + font + "', '" + background + "');", con);

                com.ExecuteNonQuery();

                com.Dispose();


                con.Close();
            }
        }
        
    }
}