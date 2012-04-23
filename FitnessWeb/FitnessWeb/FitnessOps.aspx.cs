using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessWeb
{
    public partial class FitnessOps : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

//{
//    public partial class FitnessOps : Form
//    {
//        // this is assigned by calling form, the container where we add an item
//        public List<FitnessClassOpportunity> m_container;

//        public FitnessOps()
//        {
//            InitializeComponent();
//        }
//        //closes FitnessOps form, basically a cancel button
//        private void button2_Click_1(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        //this button adds the class
//        private void button1_Click_1(object sender, EventArgs e)
//        {
//            //Validation, if anything is left blank, it is wrong and it gets told it is wrong.
//            {
//                if (textBox1.Text == "" 
//                    || textBox2.Text == "" 
//                    || textBox3.Text == "" 
//                    || textBox4.Text == "" 
//                    || textBox5.Text == "" 
//                    || textBox7.Text == ""
//                    || textBox10.Text == "")
//                {
//                    MessageBox.Show("All Boxes Must be populated with an entry",
//                        "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    return;
//                }
//                //the variable "op" brings forth the class Fitnessclassopportunity and adds the list of items below which puts the information in the new class via the entry in the text box/date time etc.
//                try
//                {
//                    var op = new FitnessClassOpportunity();
//                    op.id = textBox1.Text;
//                    op.description = textBox2.Text;
//                    op.location = textBox3.Text;
//                    op.spaces = int.Parse(textBox4.Text);
//                    op.day_of_week = textBox6.Text;
//                    op.time_hour = int.Parse(textBox5.Text);
//                    //op.time_min = 0;
//                    op.duration_minutes = int.Parse(textBox7.Text);
//                    op.multiweek_class = checkBox1.Checked;
//                    op.start_date = dateTimePicker1.Value;
//                    op.number_of_sessions = int.Parse(textBox10.Text);

//                    m_container.Add(op);
//                    Close();
//                }
//                    //exception here to say that there is error in the data, i.e if you enter text into a parse, it will say the error message below.
//                catch (Exception)
//                {
//                    MessageBox.Show("There was some error in the data you've entered",
//                        "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//        }

//        //another exception handler, if the id is a duplicate, then the word duplicateId! comes next to the ID text box and the submit button is unuseable
//        private class DuplicateIdException: Exception
//        {
//        }
//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {
//            labelDupId.Visible = false;
//            button1.Enabled = true;
//            try
//            {
//                TestDuplicateIds();
//            }
//            catch (DuplicateIdException)
//            {
//                labelDupId.Visible = true;
//                //turns off the button so its unable to be pressed and makes dupe id's impossible to enter!
//                button1.Enabled = false;
//            }
//        }
//        //checks m_container in Fitness box, if the ID is a duplicate, it THROWS the duplicateIdException into play and loops to the Exception above.
//        private void TestDuplicateIds()
//        {
//            var ops = from o in m_container
//                      where o.id == textBox1.Text
//                      select o;
//            if (ops.Count() > 0)
//            {
//                throw new DuplicateIdException();
//            }
//        }
//    }
//}