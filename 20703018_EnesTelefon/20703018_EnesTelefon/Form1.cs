using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20703018_EnesTelefon
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        //SqlDataAdapter da;
        public class AracFirmalari
    {
        public int Id { get; set; }
        public string AracMarkasi { get; set; }
        public string AracUlkesi { get; set; }
        public int AracKm { get; set; }
        public int AracModel { get; set; }

    }
    

        public Form1()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=ENESTELEFON;Initial Catalog=AracFirmalari;Integrated Security=True");
            dataGridView1.DataSource = MemberList();
        }
        public void BaglantiAyarla()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            else
            {
                baglanti.Close();
            }
        }
        void Araç_Markaları()
        {
            
            
            
            dataGridView1.DataSource = MemberList();
            
        }
        public List<AracFirmalari> MemberList()
        {
            List<AracFirmalari> CarList = new List<AracFirmalari>();
            try
            {
                komut= new SqlCommand("select * from AracMarkalari", baglanti);
                BaglantiAyarla();
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    CarList.Add(new AracFirmalari()
                    {
                        Id = reader.IsDBNull(0) ? 0 :reader.GetInt32(0),
                        AracMarkasi = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        AracUlkesi = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        AracKm = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                        AracModel = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                        

                    });

                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                BaglantiAyarla();
            }
            return CarList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
              

            private void listBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox5.Text == "")
                label10.Text = "0";
            else if (listBox5.Text == "Audi")
                label10.Text = "78.000";
            else if (listBox5.Text == "Volkswagen")
                label10.Text = "50.000";
            else if (listBox5.Text == "Skoda ")
                label10.Text = "45.000";
            else if (listBox5.Text == "Bmw")
                label10.Text = "80.000";
            else if (listBox5.Text == "Mercedes")
                label10.Text = "84.000";
        }

        private void listBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox4.Text == "")
                label9.Text = "0";
            else if (listBox4.Text == "Mitsubishi")
                label9.Text = "32.000";
            else if (listBox4.Text == "Toyota")
                label9.Text = "42.000";
            else if (listBox4.Text == "Nissan")
                label9.Text = "40.000";
            else if (listBox4.Text == "Honda")
                label9.Text = "39.000";
        }

        private void listBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox3.Text == "")
                label8.Text = "0";
            else if (listBox3.Text == "Ford")
                label8.Text = "57.000";
            else if (listBox3.Text == "Hummer ")
                label8.Text = "70.000";
            else if (listBox3.Text == "Jeep")
                label8.Text = "55.000";
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox2.Text == "")
                label7.Text = "0";
            else if (listBox2.Text == "Rolly Roces")
                label7.Text = "96.000";
            else if (listBox2.Text == "Jaguar")
                label7.Text = "93.000";
            else if (listBox2.Text == "Aston Martin")
                label7.Text = "90.000";
            else if (listBox2.Text == "Land Rover")
                label7.Text = "98.000";
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.Text == "")
                label6.Text = "0";
            else if (listBox1.Text == "Fiat")
                label6.Text = "27.000";
            else if (listBox1.Text == "Alfa Romeo")
                label6.Text = "35.000";
            else if (listBox1.Text == "Ferrari")
                label6.Text = "109.000";
            else if (listBox1.Text == "Iveco")
                label6.Text = "88.000";
        }

        private void button1_Click_1(object sender, EventArgs e) //Seçili Satırı Listbox'a ekliyoruz.
        {

            if (listBox5.Text != "")
                listBox6.Items.Add(listBox5.Text + " " + label10.Text);
            if (listBox4.Text != "")
                listBox6.Items.Add(listBox4.Text + " " + label9.Text);
            if (listBox3.Text != "")
                listBox6.Items.Add(listBox3.Text + " " + label8.Text);
            if (listBox2.Text != "")
                listBox6.Items.Add(listBox2.Text + " " + label7.Text);
            if (listBox1.Text != "")
                listBox6.Items.Add(listBox1.Text + " " + label6.Text);

        }

        private void button2_Click_1(object sender, EventArgs e) //Listeyi Sıfırlıyor.
        {
            listBox6.Items.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e) //Listede Seçili Satırı Siliyor.
        {
            listBox6.Items.RemoveAt(listBox6.Items.IndexOf(listBox6.SelectedItem));
        }

        DataTable tbl = new DataTable(); //Filtreleme Yapmamıza yardımcı olacak kodlar
        DataView filtrele()
        {
            DataView dv = new DataView();
            dv = tbl.DefaultView;
            dv.RowFilter = "AracMarkalari like '" + textBox1.Text + "%'";
            dataGridView1.DataSource = dv;
            return dv;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Veri Tabanında Arama yapar.
        {
            filtrele();
        }

        private void button4_Click(object sender, EventArgs e) //Veri Tabanına kaydetmesini yapar.
        {
            string AracMarkalari = textBox2.Text;
            string AracUlke = textBox3.Text;
            string AracKm = textBox4.Text;
            string AracModel = textBox5.Text;

            baglanti.Open();
            komut = new SqlCommand("INSERT INTO [liste].[dbo].[Table](AracMarkasi, AracUlkesi, AracKm, AracModel) VALUES ('" + AracMarkalari + "', '" + AracUlke + "','" + AracKm + "','" + AracModel + "','" , baglanti);
            komut.ExecuteNonQuery();
            komut.Clone();

            MessageBox.Show("Başarıyla Kaydedildi.");
        }

        private void button5_Click(object sender, EventArgs e) //Yazı kutusunda yazılanları temizler.
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
