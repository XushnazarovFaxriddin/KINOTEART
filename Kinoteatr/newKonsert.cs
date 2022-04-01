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
    public partial class newKonsert : Form
    {
        public newKonsert()
        {
            InitializeComponent();
        }

        private void newKonsert_Load(object sender, EventArgs e)
        {
        }

        private void yaratishBtn_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            bool yaratish = true;
            Program.dbList.ForEach(x =>
            {
                if (x.Nomi == konsertNomiTxt.Text)
                {
                    MessageBox.Show("Ushbu nomdagi konsert mavjud boshqa nom qoying!");
                    yaratish = false;
                }
                if (x.Vaqti == dateTimePicker1.Text)
                {
                    MessageBox.Show("Ushbu sanada konset mavjud boshqa sanani tanlag!");
                    yaratish = false;
                }
                id++;
            });
            id++;
            if (yaratish)
            {
                File.WriteAllText($@"{Program.path}\{konsertNomiTxt.Text}.txt",
                    $@"{id}*{konsertNomiTxt.Text}*{"0,"}*{numericUpDown1.Value}*{dateTimePicker1.Text}");
                Program.kinoteatr.listBox1.Items.Add(konsertNomiTxt.Text);
                Program.dbList.Add(new db()
                {
                    Id=id,
                    Nomi=konsertNomiTxt.Text,
                    SotilganBiletlar="0,",
                    BiletlarSoni=Convert.ToInt32(numericUpDown1.Value),
                    Vaqti=dateTimePicker1.Text
                });
                Close();
            }
            //MessageBox.Show("Ushbu sanada konset mavjud boshqa sanani tanlag!");
            //MessageBox.Show("Ushbu nomdagi konsert mavjud boshqa nom qoying!");
            //MessageBox.Show(dateTimePicker1.Text);
            
        }
    }
}
