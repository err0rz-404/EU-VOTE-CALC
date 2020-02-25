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
        public List<CheckBox> chkCountriesList = new List<CheckBox>();//making them all together
        List<Countries> countri = new List<Countries>();
        List<ComboBox> cmbCountriesList = new List<ComboBox>();
        List<Label> lblCountries = new List<Label>();
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

            // Tom H test comment.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //adding all the checkboxes into a list to have them all bunched
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
                countri.Add(cs);//adding the class to the class, adding the info the each instance
                stream.Close();
                x = x + 1;                
            }

            //adding all the labels into a list to have them all bunched
            lblCountries.Add(lbl);
            lblCountries.Add(label1);
            lblCountries.Add(label2);
            lblCountries.Add(label3);
            lblCountries.Add(label4);
            lblCountries.Add(label5);
            lblCountries.Add(label6);
            lblCountries.Add(label7);
            lblCountries.Add(label8);
            lblCountries.Add(label9);
            lblCountries.Add(label10);
            lblCountries.Add(label11);
            lblCountries.Add(label12);
            lblCountries.Add(label13);
            lblCountries.Add(label14);
            lblCountries.Add(label15);
            lblCountries.Add(label16);
            lblCountries.Add(label17);
            lblCountries.Add(label18);
            lblCountries.Add(label19);
            lblCountries.Add(label20);
            lblCountries.Add(label21);
            lblCountries.Add(label22);
            lblCountries.Add(label23);
            lblCountries.Add(label24);
            lblCountries.Add(label25);
            lblCountries.Add(label26);

            //adding all the comboboxes into a list to have them all bunched
            cmbCountriesList.Add(cmbAustria);
            cmbCountriesList.Add(cmbBelgium);
            cmbCountriesList.Add(cmbBulgaria);
            cmbCountriesList.Add(cmbCroatia);
            cmbCountriesList.Add(cmbCyprus);
            cmbCountriesList.Add(cmbCzechRepublic);
            cmbCountriesList.Add(cmbDenmark);
            cmbCountriesList.Add(cmbEstonia);
            cmbCountriesList.Add(cmbFinland);
            cmbCountriesList.Add(cmbFrance);
            cmbCountriesList.Add(cmbGermany);
            cmbCountriesList.Add(cmbGreece);
            cmbCountriesList.Add(cmbHungary);
            cmbCountriesList.Add(cmbIreland);
            cmbCountriesList.Add(cmbItaly);
            cmbCountriesList.Add(cmbLativa);
            cmbCountriesList.Add(cmbLithuania);
            cmbCountriesList.Add(cmbLuxemborg);
            cmbCountriesList.Add(cmbMalta); 
            cmbCountriesList.Add(cmbNetherlands);
            cmbCountriesList.Add(cmbPoland);
            cmbCountriesList.Add(cmbPortugal);
            cmbCountriesList.Add(cmbRomania);
            cmbCountriesList.Add(cmbSlovakia);
            cmbCountriesList.Add(cmbSlovenia);
            cmbCountriesList.Add(cmbSpain);
            cmbCountriesList.Add(cmbSweden);

            for (int i = 0; i < cmbCountriesList.Count; i++)//setting all the loaded votes to yes by default
            {
                lblCountries[i].Text = countri[i].name;
                cmbCountriesList[i].SelectedIndex = countri[i].Vote - 1;
            }            
        }

        private void canVote(object sender, EventArgs e)
        {
            int canVoteAmount = 0;//allows for all them to be in one number
            //if they can vote the combo box isnt disabled 
            for (int i = 0; i < 26; i++)//looping through all the countries
            {
                countri[i].changePart(chkCountriesList[i].Checked);//allowing for the form to not allow certain countries to vote
                if (chkCountriesList[i].Checked == true)//if it they can vote
                {
                    canVoteAmount++;//add the the amount that can vote
                    cmbCountriesList[i].Enabled = true;//making it so it can be used in case it was disabled before
                }
                else//if it was not checked
                {
                    cmbCountriesList[i].Enabled = false;//making it not function as the country isnt able to vote
                }
            }
        }

        private void changeVote(object sender, EventArgs e)
        {            
            for (int i = 0; i < 26; i++)//getting their votes
            {
                //changing the class value in method to say what each country vote is
                if (cmbCountriesList[i].Text == "Yes")//1 is yes
                {
                    countri[i].changeVote(1);
                }
                else if(cmbCountriesList[i].Text == "No")//2 is no
                {
                    countri[i].changeVote(2);
                }
                else//3 is abstain
                {
                    countri[i].changeVote(3);
                }
            }
        }

        public void majQualifiedVote()
        {
            //looping
            for (int i = 0; i < 26; i++)
            {
                //check to see if they can vote
                if(chkCountriesList[i].Checked == )
                {

                }
            }
        }
    }
}
