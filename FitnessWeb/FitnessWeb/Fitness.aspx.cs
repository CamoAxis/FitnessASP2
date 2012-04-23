using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Serialization;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace FitnessWeb
{
    public partial class Fitness : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {

        }

        protected void button2_Click(object sender, EventArgs e)
        {
             
        }

        protected void button3_Click(object sender, EventArgs e)
        {
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void button4_Click(object sender, EventArgs e)
        {

        }

        protected void button5_Click(object sender, EventArgs e)
        {

        }

        protected void button6_Click(object sender, EventArgs e)
        {

        }

    }
}
//{
//    public partial class Fitness : Form
//    {
//        public List<FitnessClassOpportunity> m_opportunities = new List<FitnessClassOpportunity>();
		
//        // sort order for list 1=id, 2=loc, 3=date
//        private int m_sort = 1;
//        private string m_serialize_file = @"class_opportunities.bin";

//        public Fitness()
//        {
//            InitializeComponent();
//            LoadAll();
//            UpdateLists();
//        }

//        private void button3_Click_1(object sender, EventArgs e)
//        {
//            FitnessOps frm = new FitnessOps();
//            frm.m_container = m_opportunities;
//            frm.ShowDialog();
//            UpdateLists();
//        }

//        /// <summary>
//        /// Updates displayed list of classes and whatever
//        /// </summary>
//        private void UpdateLists()
//        {
//            listBox1.Items.Clear();
//            System.Linq.IOrderedEnumerable<FitnessClassOpportunity> ops;
//            //switch statement to tell us that the default order, and then the order if another button were to be pressed.
//            switch (m_sort)
//            {
//                case 1:
//                        ops = from o in m_opportunities
//                              orderby o.id, o.start_date, o.location
//                              select o;
//                        break;
//                case 2:
//                        ops = from o in m_opportunities
//                              orderby o.location, o.start_date, o.location
//                              select o;
//                        break;
//                // case 3
//                default:
//                        ops = from o in m_opportunities
//                              orderby o.start_date, o.location
//                              select o;
//                        break;
//            }

//            foreach(var op in ops) {
//                // text label is created by opportunity.ToString() method
//                listBox1.Items.Add(op);
//            }
//        }
//        //m_sort for switch, just assigns a value of 1/2/3 to the buttons and updates lists after theyre clicked.
//        private void button1_Click(object sender, EventArgs e)
//        {
//            m_sort = 1;
//            UpdateLists();
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            m_sort = 2;
//            UpdateLists();
//        }

//        private void button6_Click(object sender, EventArgs e)
//        {
//            m_sort = 3;
//            UpdateLists();
//        }

//        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            textBox1.Text = "";
//            if (listBox1.SelectedIndex < 0)
//            {
//                return;
//            }
//            var op = listBox1.SelectedItem as FitnessClassOpportunity;
//            textBox1.Text = op.Present();
//        }
//        //deletes the selected class, with some verification that it wont just delete if you press delete without selecting a class.
//        private void button4_Click(object sender, EventArgs e)
//        {
//            if (listBox1.SelectedIndex < 0)
//            {
//                MessageBox.Show(this, "You haven't selected a class", "Select a Class",
//                    MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }
//            var op = listBox1.SelectedItem as FitnessClassOpportunity;
//            m_opportunities.Remove(op);
//            UpdateLists();
//        }
//        //button 5 named save all saves everything to filestream, below
//        private void button5_Click(object sender, EventArgs e)
//        {
//            SaveAll();
//        }
//        //saveall function shows that when clicked all the classes will be saved into the file.
//        private void SaveAll()
//        {
//            FileStream outFile;
//            StreamWriter writer;

//            outFile = new FileStream("class.txt", FileMode.Create,
//                                     FileAccess.Write);  
          
//            writer = new StreamWriter(outFile);

//            for (int i = 0; i < listBox1.Items.Count; i++)
//            {
//            writer.WriteLine(Convert.ToString(listBox1.Items[i]));
//            }
//            writer.Close();                       
//            outFile.Close();

//            FileStream fs = new FileStream(m_serialize_file, FileMode.Create);           

//            // Construct a BinaryFormatter and use it to serialize the data to the stream.
//            BinaryFormatter formatter = new BinaryFormatter();
//            try
//            {
//                formatter.Serialize(fs, m_opportunities);
//            }
//                //exception for any error.
//            catch (SerializationException e)
//            {
//                MessageBox.Show(this, "Save error:: " + e.Message, "oops",
//                    MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            finally
//            {
//                fs.Close();
//            }

//        }
//        //loadall function loads classes automatically, no need for button on the UI, makes it more clean.
//        private void LoadAll()
//        {
//            if (!File.Exists(m_serialize_file)) return;

//            // Open the file containing the data that you want to deserialize.
//            FileStream fs = new FileStream(m_serialize_file, FileMode.Open);
//            try
//            {
//                BinaryFormatter formatter = new BinaryFormatter();

//                // Deserialize the table from the file and 
//                // assign the reference to the local variable.
//                m_opportunities = (List<FitnessClassOpportunity>)formatter.Deserialize(fs);
//            }
//            catch (SerializationException e)
//            {
//                MessageBox.Show(this, "Save error:: " + e.Message, "oops",
//                    MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            finally
//            {
//                fs.Close();
//            }
//        }

//        private void Fitness_Load(object sender, EventArgs e)
//        {
//            SaveAll();
//        }
//    }
//}