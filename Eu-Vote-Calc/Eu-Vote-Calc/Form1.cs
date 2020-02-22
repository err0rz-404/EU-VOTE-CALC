using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Microsoft.VisualBasic;

namespace Eu_Vote_Calc
{

    public partial class Form1 : Form
    {
        List<Countries> countri = new List<Countries>();
        public List<CheckBox> box = new List<CheckBox>();

        [Serializable]
        class Countries
        {
            public string name;
            public bool Part;
            public int Vote;
            public int population;
        }
        public Form1()
        {
            
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Loading();
        }
        public void Loading()
        {
            box.Add(Austria);
            box.Add(checkBox1);
            box.Add(checkBox2);
            box.Add(checkBox3);
            box.Add(checkBox4);
            box.Add(checkBox5);
            box.Add(checkBox6);
            box.Add(checkBox7);
            box.Add(checkBox8);
            box.Add(checkBox9);
            box.Add(checkBox10);
            box.Add(checkBox11);
            box.Add(checkBox12);
            box.Add(checkBox13);
            box.Add(checkBox14);
            box.Add(checkBox15);
            box.Add(checkBox16);
            box.Add(checkBox17);
            box.Add(checkBox18);
            box.Add(checkBox19);
            box.Add(checkBox20);
            box.Add(checkBox21);
            box.Add(checkBox23);
            box.Add(checkBox24);
            box.Add(checkBox25);
            box.Add(checkBox26);

            int x = 0;
            while (x < 27){
                IFormatter formatter = new BinaryFormatter();

                Stream stream = new FileStream((x.ToString() + ".txt"), FileMode.Open, FileAccess.Read);

                Countries cs = (Countries)formatter.Deserialize(stream);
                countri.Add(cs);
                Console.WriteLine(cs.name);
                stream.Close();
                x = x + 1;
            }

        }
        void canVote()
        {
            int canVoteAmount = 0;

            for (int i = 0; i < 26; i++)
            {
                countri[i].Part = box[i].Checked;
                if (box[i].Checked == true)
                {
                    canVoteAmount++;
                }
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
