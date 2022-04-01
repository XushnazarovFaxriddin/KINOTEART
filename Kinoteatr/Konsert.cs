using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Konsert : Form
    {
        db _db = new db();
        int _id = 0;
        public Konsert()
        {
            InitializeComponent();
        }
        public Konsert(db list, int i)
        {
            _db = list;
            _id = i-1;
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = numericUpDown1.Value.ToString();
            if (int.Parse(x) > _db.BiletlarSoni)
            {
                MessageBox.Show($@"{_db.Nomi} konsertida {_db.BiletlarSoni} ta bilet bor!");
            }
            else
            if (_db.SotilganBiletlar.Contains(x))
            {
                MessageBox.Show("Ushbu bilet allaqachon sotilgan!");
            }
            else
            {
                //Program.dbList[_id].SotilganBiletlar += $" {x},";
                _db.SotilganBiletlar+= $" {x},";
                //string item=Directory.GetFiles(Program.path)[_id];
                File.WriteAllText(Program.path+$@"\{_db.Nomi}.txt",
                    $@"{_db.Id}*{_db.Nomi}*{_db.SotilganBiletlar}*{_db.BiletlarSoni}*{_db.Vaqti}");
                richTextBox1.Text = _db.SotilganBiletlar == "0," ? richTextBox1.Text : _db.SotilganBiletlar;
                MessageBox.Show($"{x} - bilet sotildi!");
            }
        }

        private void Konsert_Load(object sender, EventArgs e)
        {
            kondertNameTxt.Text = kondertNameTxt.Text + " " + _db.Nomi;
            biletSoniTxt.Text = biletSoniTxt.Text + " " + _db.BiletlarSoni.ToString();
            vaqtitxt.Text = vaqtitxt.Text + " " + _db.Vaqti;
            richTextBox1.Text = _db.SotilganBiletlar == "0," ? richTextBox1.Text : _db.SotilganBiletlar;
        }
    }
}
