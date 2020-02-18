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
            Countries Austria = new Countries();
            Austria.name = "Austria";
            Austria.Part = true;
            Austria.Vote = 3;
            Austria.population = 8823054;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Austria);
            stream.Close();
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
