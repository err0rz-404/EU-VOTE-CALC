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
        public List<CheckBox> box = new List<CheckBox>();
        List<Countries> countri = new List<Countries>();

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

        private void Form1_Load(object sender, EventArgs e)
        {
            box.Add(chkAustria);
            box.Add(chkBelgium);
            box.Add(chkBulgaria);
            box.Add(chkCrotia);
            box.Add(chkCyprus);
            box.Add(chkCzech_Republic);
            box.Add(chkEstonia);
            box.Add(chkDenmark);
            box.Add(chkFinland);
            box.Add(chkFrance);
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
            while (x < 27)
            {
                IFormatter formatter = new BinaryFormatter();

                Stream stream = new FileStream((x.ToString() + ".txt"), FileMode.Open, FileAccess.Read);

                Countries cs = (Countries)formatter.Deserialize(stream);
                countri.Add(cs);
                stream.Close();
                x = x + 1;
            }
        }

        private void canVote(object sender, EventArgs e)
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
            textBox1.Clear();
            textBox1.Text = "amount of votes that can be done " + canVoteAmount.ToString();
        }
    }
}
