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
    public partial class Kinoteatr : Form
    {
        int listboxId = -1;
        string listboxName = "";

        public Kinoteatr()
        {
            InitializeComponent();
        }

        public void Kinoteatr_Load(object sender, EventArgs e)
        {
            //Program.dbList.Clear();
            listBox1.Items.Clear();
            try
            {
                foreach (String item in Directory.GetFiles(Program.path))
                {
                    String[] file_Txt = File.ReadAllText(item).Split('*');
                    Program.dbList.Add(new db()
                    {
                        Id = Convert.ToInt32(file_Txt[0]),
                        Nomi = file_Txt[1],
                        BiletlarSoni=Convert.ToInt32(file_Txt[3]),
                        SotilganBiletlar=file_Txt[2],
                        Vaqti=file_Txt[4]
                    }); 
                }
                Program.dbList.ForEach(x =>
                {
                    listBox1.Items.Add(x.Nomi);
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kinoteatr_Load xatolik   =>   " + ex.Message);
            }
        }


        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listboxId != -1)
            {
                int i = 0;
                db list=new db();
                Program.dbList.ForEach(x => { if (x.Nomi == listboxName) { list = x; i++;} });
                Hide();
                Program.konsert = new Konsert(list,i);
                Program.konsert.ShowDialog();
                Show();
            }
            //MessageBox.Show(listboxId.ToString());
        }

        private void deleteKonsertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (listboxId != -1)
                {
                    Program.dbList.ForEach(x =>
                    {
                        if (x.Nomi == listboxName)
                        {
                            File.Delete(Program.path + $@"\{x.Nomi}.txt");
                        }
                    });
                    listBox1.Items.RemoveAt(listboxId);
                    listboxId = -1;
                    listboxName = "";
                }
                else
                {
                    MessageBox.Show("Konsertni tanlang!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("deleteBtn da xatolik:   =>    "+ex.Message);
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            listboxId = listBox1.SelectedIndex;
            listboxName = listboxId != -1 ? listBox1.Items[listboxId].ToString() : "";
        }

        private void newKonsertBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Program.newkonsert.ShowDialog();
            Show();
        }
    }
}
