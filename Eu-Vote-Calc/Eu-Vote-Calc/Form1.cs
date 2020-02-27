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
        private Timer timer1;
        public List<CheckBox> chkCountriesList = new List<CheckBox>();//making them all together
        List<Countries> countri = new List<Countries>();//used to hold all the country classes
        List<ComboBox> cmbCountriesList = new List<ComboBox>();//used to hold all countries votes
        List<Label> lblCountries = new List<Label>();//used to output all countries names
        List<Label> lblCountriesPopulation = new List<Label>();//used to output all the countries population

        [Serializable]
        class Countries
        {
            private string name;
            public bool Part;
            public int Vote;
            private int population;

            public void changePart(bool input)
            {
                Part = input;//used to alter if the country can vote or not
            }
            public void changeVote(int newVote)
            {
                Vote = newVote;//used to the countries vote
            }
            public string printName()
            {
                return name;//used to output name 
            }
            public int printPopulation()
            {
                return population;//used to output population
            }
        }
        public Form1()
        {
            InitTimer();
            InitializeComponent();

            // Tom H test comment.
        }
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 100; // in miliseconds
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            CalcUpdate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CMBVoteType.Items.Add("Qualified majority");
            CMBVoteType.Items.Add("Reinforced qualified majority");
            CMBVoteType.Items.Add("Simple majority");
            CMBVoteType.Items.Add("Unanimity");
           
            //adding all the checkboxes into a list to have them all bunched
            chkCountriesList.Add(chkAustria);
            chkCountriesList.Add(chkBelgium);
            chkCountriesList.Add(chkBulgaria);
            chkCountriesList.Add(chkCroatia);
            chkCountriesList.Add(chkCyprus);
            chkCountriesList.Add(chkCzech_Republic);
            chkCountriesList.Add(chkEstonia);
            chkCountriesList.Add(chkDenmark);
            chkCountriesList.Add(chkFinland);
            chkCountriesList.Add(chkFrance);
            chkCountriesList.Add(chkGermany);
            chkCountriesList.Add(chkGreece);
            chkCountriesList.Add(chkHungary);
            chkCountriesList.Add(chkIreland);
            chkCountriesList.Add(chkItaly);
            chkCountriesList.Add(chkLatvia);
            chkCountriesList.Add(chkLithuania);
            chkCountriesList.Add(chkLuxembourg);
            chkCountriesList.Add(chkMalta);
            chkCountriesList.Add(chkNetherlands);
            chkCountriesList.Add(chkPoland);
            chkCountriesList.Add(chkPortugal);
            chkCountriesList.Add(chkRomania);
            chkCountriesList.Add(chkSlovakia);
            chkCountriesList.Add(chkSlovenia);
            chkCountriesList.Add(chkSpain);
            chkCountriesList.Add(chkSweden);

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
            lblCountries.Add(lblAustria);
            lblCountries.Add(lblBulgaria);
            lblCountries.Add(lblBelgium);
            lblCountries.Add(lblCroatia);
            lblCountries.Add(lblCyprus);
            lblCountries.Add(lblCzech_Republic);
            lblCountries.Add(lblDenmark);
            lblCountries.Add(lblEstonia);
            lblCountries.Add(lblFinland);
            lblCountries.Add(lblFrance);
            lblCountries.Add(lblGermany);
            lblCountries.Add(lblGreece);
            lblCountries.Add(lblHungary);
            lblCountries.Add(lblIreland);
            lblCountries.Add(lblItaly);
            lblCountries.Add(lblLatvia);
            lblCountries.Add(lblLithuania);
            lblCountries.Add(lblMalta);
            lblCountries.Add(lblLuxembourg);
            lblCountries.Add(lblNetherlands);
            lblCountries.Add(lblPoland);
            lblCountries.Add(lblPortugal);
            lblCountries.Add(lblRomania);
            lblCountries.Add(lblSlovakia);
            lblCountries.Add(lblSlovenia);
            lblCountries.Add(lblSpain);
            lblCountries.Add(lblSweden);

            //adding all the labels into a list to contain the population
            lblCountriesPopulation.Add(label1);
            lblCountriesPopulation.Add(label2);
            lblCountriesPopulation.Add(label3);
            lblCountriesPopulation.Add(label4);
            lblCountriesPopulation.Add(label5);
            lblCountriesPopulation.Add(label6); 
            lblCountriesPopulation.Add(label7);
            lblCountriesPopulation.Add(label8);
            lblCountriesPopulation.Add(label9);
            lblCountriesPopulation.Add(label10);
            lblCountriesPopulation.Add(label11);
            lblCountriesPopulation.Add(label12); 
            lblCountriesPopulation.Add(label13);
            lblCountriesPopulation.Add(label14);
            lblCountriesPopulation.Add(label15);
            lblCountriesPopulation.Add(label16);
            lblCountriesPopulation.Add(label17);
            lblCountriesPopulation.Add(label18);
            lblCountriesPopulation.Add(label19);
            lblCountriesPopulation.Add(label20);
            lblCountriesPopulation.Add(label21);
            lblCountriesPopulation.Add(label22);
            lblCountriesPopulation.Add(label23);
            lblCountriesPopulation.Add(label24);
            lblCountriesPopulation.Add(label25);
            lblCountriesPopulation.Add(label26);
            lblCountriesPopulation.Add(label27);

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
                lblCountries[i].Text = countri[i].printName();//printing outputting all the names
                lblCountriesPopulation[i].Text = countri[i].printPopulation().ToString();
                cmbCountriesList[i].SelectedIndex = countri[i].Vote - 1;
            }
        }

        private void canVote(object sender, EventArgs e)
        {
            int canVoteAmount = 0;//allows for all them to be in one number
            //if they can vote the combo box isnt disabled 
            for (int i = 0; i < 27; i++)//looping through all the countries
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
            for (int i = 0; i < 27; i++)//getting their votes
            {
                //changing the class value in method to say what each country vote is
                if (cmbCountriesList[i].Text == "Yes")//1 is yes
                {
                    countri[i].changeVote(1);
                }
                else if (cmbCountriesList[i].Text == "No")//2 is no
                {
                    countri[i].changeVote(2);
                }
                else//3 is abstain
                {
                    countri[i].changeVote(3);
                }
            }
        }
        public void CalcUpdate()
        {
            int TotalCountries = 0;
            int yesCountries = 0;
            int noCountries = 0;
            int absCountries = 0;
            int votetype = 1;
            int population = 0;
            int popfor = 0;
            int popagainst = 0;
            int popabstain = 0;
            for (int i = 0; i < 27; i++)
            {
                
                //check to see if they can vote
                if (chkCountriesList[i].Checked == true)
                {
                    population = population + countri[i].printPopulation();
                    TotalCountries++;
                    if (cmbCountriesList[i].Text == "Yes")
                    {
                        yesCountries++;
                        popfor = popfor + countri[i].printPopulation();
                    }
                    else if (cmbCountriesList[i].Text == "No")
                    {
                        noCountries++;
                        popagainst = popagainst + countri[i].printPopulation();
                    }
                    else
                    {
                        absCountries++;
                        popabstain = popabstain + countri[i].printPopulation();
                    }
                }
            }
            if (CMBVoteType.SelectedIndex == 0)
            {
                votetype = 1;
                lblVoteRule.Text = ("minimum 'yes' requrited for adoption: (55%) " + ((int)(TotalCountries * 0.55f)).ToString());
                lblPopulationRule.Text = "Minimum “Yes” required for adoption: 65%";
            }
            else if (CMBVoteType.SelectedIndex == 1)
            {
                votetype = 2;
                lblVoteRule.Text = ("minimum 'yes' requrited for adoption: (72%) " + ((int)(TotalCountries * 0.72f)).ToString());
                lblPopulationRule.Text = "Minimum “Yes” required for adoption: 65%";
            }
            else if (CMBVoteType.SelectedIndex == 2)
            {
                votetype = 3;
                lblVoteRule.Text = ("minimum 'yes' requrited for adoption: (50%) " + ((int)(TotalCountries * 0.50f)).ToString());
                lblPopulationRule.Text = "Minimum “Yes” required for adoption: 0%";
            }
            else if (CMBVoteType.SelectedIndex == 3)
            {
                votetype = 4;

                lblVoteRule.Text = ("minimum 'yes' requrited for adoption: (100%) " + ((int)(TotalCountries * 1.0f)).ToString());
                lblPopulationRule.Text = "Minimum “Yes” required for adoption: %";

            }
            else
            {
                CMBVoteType.SelectedIndex = 0;
            }
            lblTotalAmountVoting.Text = (TotalCountries).ToString();
            float yes;
            float no;
            float abs;
            float yesper;
            float noper;
            float absper;
            float totalper = population * 1.0f;
            float total = (TotalCountries) * 1.0f;
            yes = (yesCountries / total) * 100;
            no = (noCountries / total) * 100;
            abs = (absCountries / total) * 100;// comments to 100
            yesper = (popfor / totalper)*100;
            noper = (popagainst / totalper)*100;
            absper = (popabstain/totalper)*100;
            pictureBox28.Width = (int)(yes * 6);
            pictureBox29.Width = (int)(no * 6);
            pictureBox30.Width = (int)(abs * 6);
            pictureBox31.Width = (int)(yesper * 6);
            pictureBox32.Width = (int)(noper * 6);
            pictureBox33.Width = (int)(absper * 6);
            lblVoteYes.Text = yesCountries.ToString();
            lblVoteNo.Text = noCountries.ToString();
            lblVoteAbstain.Text = absCountries.ToString();
            lblPopYes.Text = yesper.ToString("0.##");
            lblPopNo.Text = noper.ToString("0.##");
            lblPopAbstain.Text = absper.ToString("0.##");
            result((int)yes, (int)yesper, votetype);
        }
        public void result(int yes, int yespop,int vote){
            Console.WriteLine(yes);
          switch (vote)
            {
                case 1:
                    if((yes>55 & yespop > 65))
                    {
                        pictureBox34.Image = Eu_Vote_Calc.Properties.Resources.Green_Arrow_Top_512;
                        label42.Text = "Approved";
                    }
                    else
                    {
                        pictureBox34.Image = Eu_Vote_Calc.Properties.Resources.Red_Arrow_Down_512;
                        label42.Text = "Rejected";
                    }
                    break;

                case 2:
                    if ((yes > 72 & yespop > 65))
                    {
                        pictureBox34.Image = Eu_Vote_Calc.Properties.Resources.Green_Arrow_Top_512;
                        label42.Text = "Approved";
                    }
                    else
                    {
                        pictureBox34.Image = Eu_Vote_Calc.Properties.Resources.Red_Arrow_Down_512;
                        label42.Text = "Rejected";
                    }
                    break;

                case 3:
                    if ((yes > 50 & yespop > 0))
                    {
                        pictureBox34.Image = Eu_Vote_Calc.Properties.Resources.Green_Arrow_Top_512;
                        label42.Text = "Approved";
                    }
                    else
                    {
                        pictureBox34.Image = Eu_Vote_Calc.Properties.Resources.Red_Arrow_Down_512;
                        label42.Text = "Rejected";
                    }
                    break;

                case 4:
                    Console.WriteLine("testing");
                    if ((yes >100 & yespop > 0))
                    {
                        pictureBox34.Image = Eu_Vote_Calc.Properties.Resources.Green_Arrow_Top_512;
                        label42.Text = "Approved";
                    }
                    else
                    {
                        pictureBox34.Image = Eu_Vote_Calc.Properties.Resources.Red_Arrow_Down_512;
                        label42.Text = "Rejected";
                    }
                    break;
            }
        }
    }
}
