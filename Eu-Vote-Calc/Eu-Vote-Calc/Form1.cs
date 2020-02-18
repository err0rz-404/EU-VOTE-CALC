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
            int x = 0;
            Countries Austria = new Countries();
            Austria.name = "Austria";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 8823054;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream((x.ToString()+".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Belgium";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 11413058;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Blugaria";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 7101859;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Croatia";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 4154213;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Cyprus";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 845800;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Czech Republic";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 10610055;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Denmark";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 5781190;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Estonia";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 1319133;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Finland";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 5516224;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "France";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 67187000;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Germany";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 82850000;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Greece";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 10768193;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Hungray";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 9771000;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Ireland";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 4921500;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Italy";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 60483973;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Latvia";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 1929900;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Lithuanaia";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 2807495;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Luxembourg";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 590667;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Malta";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 460297;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Netherlands";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 17261622;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Poland";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 38426000;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Portugal";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 10309573;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Romania";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 19638309;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Slovakia";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 5441899;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Slovenia";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 2065890;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Spain";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 46549045;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Austria.name = "Sweden";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 10142686;
            stream = new FileStream((x.ToString() + ".txt"), FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
            x = x + 1;
            Loading();
        }
        public void Loading()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream("Myfile.bin", FileMode.Open, FileAccess.Read);

            Countries cs = (Countries)formatter.Deserialize(stream);

            Console.WriteLine(cs.name);
            stream.Close();
        }
    }
}
