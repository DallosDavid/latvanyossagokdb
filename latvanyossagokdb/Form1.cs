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
            Adat();
        }
        void Adat() {

            string sql = @"
SELECT id,nev,leiras,ar,varos_id
FROM latvanyossagok
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
                    string leiras = reader.GetString("leiras");
                    int ar = reader.GetInt32("ar");
                    int varos_id = reader.GetInt32("varos_id");
                    var latvanyok = new Latvanyossagok(id, varos_id, nev, leiras, ar);
                    listBox_latvany.Items.Add(latvanyok);

                }
            }


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
                    listBox_varosok.Items.Add(varosok);

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
                MessageBox.Show("Kérem adjon meg nevet!");
            }
            else
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
                listBox_varosok.Items.Add(varosok);

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
            var nev = textBox_latvany.Text;
            var ar = (int)numericUpDown_ar.Value;
            var leiras = textBox_lerias.Text;

            if (textBox_latvany.Text == "" || textBox_lerias.Text == "")
            {
                MessageBox.Show("2.Kérem adjon meg helyes adatokat!");
                MessageBox.Show("" + ar);
            }
            else
            {
                Varosok l = (Varosok)listBox_varosok.SelectedItem;
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

                Varosok varos = (Varosok)listBox1.SelectedItem;
                int s = varos.Id;
                MessageBox.Show(""+s);
                var elle = conn.CreateCommand();
                elle.CommandText= @"
SELECT *
FROM latvanyossagok
WHERE varod_id == @s
 ";
                elle.Parameters.AddWithValue("@s",s);
                int sar = elle.ExecuteNonQuery();

            }
        }


    }
}
