using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace felhasznal_keppel
{
    
    public partial class Form1 : Form
    {   
        Database database = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HiagyzoAdat())
            {
                return;
            }
            felhasznalo insertFelhasznalo = new felhasznalo(1, textBox_nev.Text, dateTimePicker1.Text, textBox_profilkep.Text);
            if (database.insertfelhasznalo(insertFelhasznalo))
            {
                MessageBox.Show("Sikeres rögzites!");
                textBox_id.Text = "";
                textBox_nev.Text = "";
                textBox_profilkep.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen rögzites!");
            }
            felhasznalokBetoltese();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.mainform.listBox_adatok.Text + " adatainak a módositása");
            felhasznalo ja = (felhasznalo)Program.mainform.listBox_adatok.SelectedItem;
            

            if (HiagyzoAdat())
            {
                return;
            }
            felhasznalo updateFelhasznalo = new felhasznalo(1, textBox_nev.Text, dateTimePicker1.Text, textBox_profilkep.Text);

            if (database.updatefelhasznalo(updateFelhasznalo))
            {
                MessageBox.Show("Sikeres rögzites!");
                textBox_id.Text = "";
                textBox_nev.Text = "";
                textBox_profilkep.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen rögzites!");
            }
            felhasznalokBetoltese();
            
        }
        public void felhasznalokBetoltese()
        {

            listBox_adatok.Items.Clear();
            foreach (felhasznalo item in database.getAllfelhasznalo())
            {
                listBox_adatok.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            felhasznalokBetoltese();
           

        }
        private bool HiagyzoAdat()
        {
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Adja meg a felhasználó nevét!");
                textBox_nev.Focus();
                return true;
            }          
            if (string.IsNullOrEmpty(textBox_profilkep.Text))
            {
                MessageBox.Show("Adja meg a fájl nevét!");
                textBox_nev.Focus();
                return true;
            }
                return false;
        }

        private void listBox_adatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_adatok.SelectedIndex < 0)
            {
                return;
            }
            felhasznalo kivalasztoottfel = (felhasznalo)listBox_adatok.SelectedItem;
            textBox_id.Text = kivalasztoottfel.Id.ToString();
            textBox_nev.Text = kivalasztoottfel.Nev.ToString();
            dateTimePicker1.Text = kivalasztoottfel.Szuletesidatum.ToString();
            textBox_profilkep.Text = kivalasztoottfel.Profilkep.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\kepek\" + kivalasztoottfel.Profilkep.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Nem jó profilkép nevet adott meg!");
                return;
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            felhasznalo deleteFelhasznalo = new felhasznalo(1, textBox_nev.Text, dateTimePicker1.Text, textBox_profilkep.Text);
            if (database.deletefelhasznalo(deleteFelhasznalo))
            {
                MessageBox.Show("Sikeres rögzites!");
                textBox_id.Text = "";
                textBox_nev.Text = "";
                textBox_profilkep.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen rögzites!");
            }
            felhasznalokBetoltese();
        }

        private void button_be_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory+@"\kepek");
        }
    }
    
}
