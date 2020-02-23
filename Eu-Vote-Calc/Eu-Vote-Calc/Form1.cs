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
        public List<CheckBox> chkCountriesList = new List<CheckBox>();
        List<Countries> countri = new List<Countries>();
        List<ComboBox> cmbCountriesList = new List<ComboBox>();
        [Serializable]
        class Countries
        {
            public string name;
            public bool Part;
            public int Vote;
            public int population;

            public void changePart(bool input)
            {
                Part = input;
            }
            public void changeVote(int newVote)
            {
                Vote = newVote;
            }
        }
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkCountriesList.Add(chkAustria);
            chkCountriesList.Add(chkBelgium);
            chkCountriesList.Add(chkBulgaria);
            chkCountriesList.Add(chkCrotia);
            chkCountriesList.Add(chkCyprus);
            chkCountriesList.Add(chkCzech_Republic);
            chkCountriesList.Add(chkEstonia);
            chkCountriesList.Add(chkDenmark);
            chkCountriesList.Add(chkFinland);
            chkCountriesList.Add(chkFrance);
            chkCountriesList.Add(checkBox10);
            chkCountriesList.Add(checkBox11);
            chkCountriesList.Add(checkBox12);
            chkCountriesList.Add(checkBox13);
            chkCountriesList.Add(checkBox14);
            chkCountriesList.Add(checkBox15);
            chkCountriesList.Add(checkBox16);
            chkCountriesList.Add(checkBox17);
            chkCountriesList.Add(checkBox18);
            chkCountriesList.Add(checkBox19);
            chkCountriesList.Add(checkBox20);
            chkCountriesList.Add(checkBox21);
            chkCountriesList.Add(checkBox23);
            chkCountriesList.Add(checkBox24);
            chkCountriesList.Add(checkBox25);
            chkCountriesList.Add(checkBox26);

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

            cmbCountriesList.Add(cmbAustria);
            cmbCountriesList.Add(comboBox1);
            cmbCountriesList.Add(comboBox2);
            cmbCountriesList.Add(comboBox3);
            cmbCountriesList.Add(comboBox4);
            cmbCountriesList.Add(comboBox5);
            cmbCountriesList.Add(comboBox6);
            cmbCountriesList.Add(comboBox7);
            cmbCountriesList.Add(comboBox8);
            cmbCountriesList.Add(comboBox9);
            cmbCountriesList.Add(comboBox10);
            cmbCountriesList.Add(comboBox11);
            cmbCountriesList.Add(comboBox12);
            cmbCountriesList.Add(comboBox13);
            cmbCountriesList.Add(comboBox14);
            cmbCountriesList.Add(comboBox15);
            cmbCountriesList.Add(comboBox16);
            cmbCountriesList.Add(comboBox17);
            cmbCountriesList.Add(comboBox18); 
            cmbCountriesList.Add(comboBox19);
            cmbCountriesList.Add(comboBox20);
            cmbCountriesList.Add(comboBox21);
            cmbCountriesList.Add(comboBox22);
            cmbCountriesList.Add(comboBox23);
            cmbCountriesList.Add(comboBox24);
            cmbCountriesList.Add(comboBox25);
            cmbCountriesList.Add(comboBox26);

            for (int i = 0; i < cmbCountriesList.Count; i++)//setting all the loaded votes in to yes by default
            {
                //MessageBox.Show(countri[i].Vote.ToString());
                cmbCountriesList[i].SelectedIndex = countri[i].Vote - 1;
            }
            //cmbAustria.SelectedIndex = countri[0].Vote - 1;//default is abstain
        }

        private void canVote(object sender, EventArgs e)
        {
            int canVoteAmount = 0;

            for (int i = 0; i < 26; i++)
            {
                countri[i].changePart(chkCountriesList[i].Checked);
                //MessageBox.Show(countri[i].name + " " + countri[i].Part + " " + countri[i].Vote);
                //countri[i].Part = box[i].Checked;
                if (chkCountriesList[i].Checked == true)
                {
                    canVoteAmount++;
                    cmbCountriesList[i].Enabled = true;
                }
                else
                {
                    cmbCountriesList[i].Enabled = false;                    
                }
            }
            textBox1.Clear();
            textBox1.Text = "amount of votes that can be done " + canVoteAmount.ToString();
        }

        private void changeVote(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 26; i++)
            {
                if (cmbCountriesList[i].Text == "Yes")//1 is yes
                {
                    countri[i].changeVote(1);
                    MessageBox.Show(countri[i].Vote.ToString());
                }
                else if(cmbCountriesList[i].Text == "No")//2 is no
                {
                    countri[i].changeVote(2);
                    MessageBox.Show(countri[i].Vote.ToString());
                }
                else//3 is abstain
                {
                    countri[i].changeVote(3);
                    MessageBox.Show(countri[i].Vote.ToString());
                }

            }
        }
    }
}
