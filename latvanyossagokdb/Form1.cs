using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latvanyossagokdb
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = latvanyossagokdb; Uid = root; Pwd = ");
            conn.Open(); 
            this.FormClosed += (sender, args) =>
            {
                if (conn != null)
                {
                    conn.Close();
                }

            };
            AdatBetoltes();
            adatlere();
           
        }

        void adatlere()
        {

            var createvarosokComm = conn.CreateCommand();

            createvarosokComm.CommandText = @"
CREATE TABLE IF NOT EXISTS latvanyossagokdb.varosok(
             id INT(10) NOT NULL AUTO_INCREMENT,
             nev TEXT NOT NULL,
             lakossag INT(10) NOT NULL,
             PRIMARY KEY(`id`),
             UNIQUE (nev)
);
";
            createvarosokComm.ExecuteNonQuery();

            var createlatvanyossagokComm = conn.CreateCommand();

            createlatvanyossagokComm.CommandText = @"
CREATE TABLE IF NOT EXISTS latvanyossagokdb.latvanyossagok (
              id INT(10) NOT NULL AUTO_INCREMENT,
              nev TEXT NOT NULL,
              leiras TEXT NOT NULL,
              ar INT(10) NOT NULL DEFAULT '0',
              varos_id INT(10) NOT NULL,
              PRIMARY KEY (id),
              FOREIGN KEY (varos_id) REFERENCES varosok(id)
);
";
            createlatvanyossagokComm.ExecuteNonQuery();


        }


        void AdatBetoltes()
        {
            string sql = @"
SELECT *
FROM varosok
ORDER BY id
";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    int lakosag= reader.GetInt32("lakossag");


                    var varosok = new Varosok(id, nev,lakosag);
                    listBox1.Items.Add(varosok);                  

                }
            }


        }

        private void numericUpDown_lakos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_felvesz_Click(object sender, EventArgs e)
        {
            int id = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Varosok v = (Varosok)listBox1.Items[i];
                id = v.Id;
                id++;
            }
            var nev = textBox_nev.Text;
            var lakossag = (int)numericUpDown_lakos.Value;

            if (textBox_nev.Text == "")
            {
                MessageBox.Show("Kérem adjon meg nevet! ");
            }
            bool l= false;
            List<string> lnevek = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Varosok v = (Varosok)listBox1.Items[i];
                lnevek.Add(v.Nev);
            }
            if (lnevek.Contains(textBox_nev.Text) )
            {
                MessageBox.Show("Van már ilyen város.");
                l = true;
            }


           if(l==false && nev.Length!= 0 )
            {
              
                var varosok = new Varosok(id, nev, lakossag);

                var iVaros = conn.CreateCommand();
                iVaros.CommandText = @"
INSERT INTO varosok (id,nev,lakossag)
VALUES (@id,@nev,@lakossag)";
                iVaros.Parameters.AddWithValue("@id", null);
                iVaros.Parameters.AddWithValue("@nev", nev);
                iVaros.Parameters.AddWithValue("@lakossag", lakossag);
                int sor = iVaros.ExecuteNonQuery();
                listBox1.Items.Add(varosok);
                

            }
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id = 0;
            for (int i = 0; i < listBox_latvany.Items.Count; i++)
            {
                Latvanyossagok l = (Latvanyossagok)listBox_latvany.Items[i];
                id = l.Id;
                id++;
            }
            string nev = textBox_latvany.Text;
            var ar = (int)numericUpDown_ar.Value;
            string leiras = textBox_lerias.Text;

            if (textBox_latvany.Text == "" )
            {
                MessageBox.Show("Kérem adjon meg a látványoság nevét" );
               
            }

            if(leiras.Length == 0)
            {
                MessageBox.Show("Kérem adjon meg a látványoság leirását");
            }
            bool ll = false;
            List<string> lnevek = new List<string>();
            List<string> lleiras = new List<string>();
            for (int i = 0; i < listBox_latvany.Items.Count; i++)
            {
                Latvanyossagok v = (Latvanyossagok)listBox_latvany.Items[i];
                lnevek.Add(v.Nev);
                lleiras.Add(v.Leiras);

            }

            if (lnevek.Contains(textBox_latvany.Text) && lleiras.Contains(textBox_lerias.Text))
            {
                MessageBox.Show("Van már ilyen látványoság fel véve.");
                ll = true;
            }

           if(ll== false && leiras.Length != 0 && nev.Length != 0){
                Varosok l = (Varosok)listBox1.SelectedItem;
                int vid = l.Id;
                

                var latvany = new Latvanyossagok(id,vid,nev,leiras,ar);

                var iVaros = conn.CreateCommand();
                iVaros.CommandText = @"
INSERT INTO latvanyossagok (id,nev,leiras,ar,varos_id)
VALUES (@id,@nev,@leiras,@ar,@vid)";
                iVaros.Parameters.AddWithValue("@id", null);
                iVaros.Parameters.AddWithValue("@vid", vid);
                iVaros.Parameters.AddWithValue("@nev", nev);
                iVaros.Parameters.AddWithValue("@leiras", leiras);
                iVaros.Parameters.AddWithValue("@ar",ar);
                int sor = iVaros.ExecuteNonQuery();
                listBox_latvany.Items.Add(latvany);

                listBox1_SelectedIndexChanged(sender,e);

            }
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Nincs kiválasztva adat.");
            }
            else 
            {
                Varosok p = (Varosok)listBox1.SelectedItem;
                int id = p.Id;
 
                MessageBox.Show(""+listBox_latvany.Items.Count);
                if (listBox_latvany.Items.Count > 0)
                {
                    MessageBox.Show("Van városhoz adva látványoság.\nIgy nem tudod törölni a várost");
                }
                else
                {
                    string torvaros = @"DELETE FROM `varosok` WHERE `varosok`.`id` = @id";
                    var commDeletVar = this.conn.CreateCommand();
                    commDeletVar.CommandText = torvaros;
                    commDeletVar.Parameters.AddWithValue("@id", id);
                    int erinV = commDeletVar.ExecuteNonQuery();
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                

            }
        }

        private void button_modositasi_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Kérem válaszon egyet a városok közul");
                
            }
            else
            {
                Varosok varok = (Varosok)listBox1.SelectedItem;
               int id = varok.Id;

                string update = @"UPDATE varosok SET nev= @nev , lakossag = @lakossag WHERE varosok.id = @id";

                var updatecomm = conn.CreateCommand();
                updatecomm.CommandText = update;
                updatecomm.Parameters.AddWithValue("@id", id);
                updatecomm.Parameters.AddWithValue("@nev", textBox_nev.Text);
                updatecomm.Parameters.AddWithValue("@lakossag", numericUpDown_lakos.Value);
                int sork = updatecomm.ExecuteNonQuery();
                listBox1.Items.Clear();
                AdatBetoltes();
            }
        }
       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Varosok varos = (Varosok)listBox1.SelectedItem;
            if (listBox1.SelectedItem == null)
            {

            }
            else
            {
                listBox_latvany.Items.Clear();
                button_modositasi.Visible = true;
                textBox_nev.Text = varos.Nev;
                numericUpDown_lakos.Value = varos.Lakossag;
                Varosok p = (Varosok)listBox1.SelectedItem;
                int id = p.Id;

                string sql = @"
SELECT nev,ar,leiras,varos_id,id
FROM latvanyossagok
WHERE latvanyossagok.varos_id = @id";

                /*MessageBox.Show("" + id);*/
                var comm = this.conn.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@id", id);
                int ae = comm.ExecuteNonQuery();
                using (var reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        int idv = reader.GetInt32("id");
                        string nev = reader.GetString("nev");
                        string leiras = reader.GetString("leiras");
                        int ar = reader.GetInt32("ar");
                        int varos_id = reader.GetInt32("varos_id");
                        var latvanyok = new Latvanyossagok(idv, varos_id, nev, leiras, ar);
                        listBox_latvany.Items.Add(latvanyok);

                    }

                }



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox_latvany_SelectedIndexChanged(object sender, EventArgs e)
        {

            Latvanyossagok latvany = (Latvanyossagok)listBox_latvany.SelectedItem;
            if (listBox_latvany.SelectedItem == null)
            {

            }
            else
            {
                /*
                label_lat_ar_m.Visible = true;
                numericUpDown_lat_ar_m.Visible = true;
                textBox_lat_ler_m.Visible = true;
                label_lat_ler_m.Visible = true;

                label_lat_nev.Visible = true;
                textBox_lat_nev.Visible = true;*/
                button_torlos_lat.Visible = true;
                button_latvany_modos.Visible = true;

                textBox_latvany.Text = latvany.Nev;
                textBox_lerias.Text = latvany.Leiras;
                numericUpDown_ar.Value = latvany.Ar;

            }

        }

        private void button_torlos_lat_Click(object sender, EventArgs e)
        {

            if (listBox_latvany.SelectedItem == null)
            {
                MessageBox.Show("Kérem válaszon egyet a látványoságok  közul");

            }
            else
            {
            
                Latvanyossagok p = (Latvanyossagok)listBox_latvany.SelectedItem;
                int id = p.Id;

                string torvaros = @"DELETE FROM `latvanyossagok` WHERE `latvanyossagok`.`id` = @id";
                var commDeletVar = this.conn.CreateCommand();
                commDeletVar.CommandText = torvaros;
                commDeletVar.Parameters.AddWithValue("@id", id);
                int erinV = commDeletVar.ExecuteNonQuery();
                listBox_latvany.Items.RemoveAt(listBox_latvany.SelectedIndex);
                
            }
        }

        private void button_latvany_modos_Click(object sender, EventArgs e)
        {
            if (listBox_latvany.SelectedItem == null)
            {
                MessageBox.Show("Kérem válaszon egyet a látványoságok közul");

            }
            else
            {
                Latvanyossagok varok = (Latvanyossagok)listBox_latvany.SelectedItem;
                int id = varok.Id;

                string update = @"UPDATE latvanyossagok SET nev= @nev , ar = @ar, leiras = @leiras WHERE latvanyossagok.id = @id";

                var updatecomm = conn.CreateCommand();
                updatecomm.CommandText = update;
                updatecomm.Parameters.AddWithValue("@id", id);
                updatecomm.Parameters.AddWithValue("@nev", textBox_latvany.Text);
                updatecomm.Parameters.AddWithValue("@leiras", textBox_lerias.Text);
                updatecomm.Parameters.AddWithValue("@ar", numericUpDown_ar.Value);
                int sork = updatecomm.ExecuteNonQuery();
                listBox1.Items.Clear();
                listBox_latvany.Items.Clear();
                
                AdatBetoltes();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
