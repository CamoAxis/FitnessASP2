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
		//public List<FitnessClassOpportunity> m_opportunities = new List<FitnessClassOpportunity>();

		// sort order for list 1=id, 2=loc, 3=date
		//private static int m_sort = 1;
		private static string m_serialize_file = @"class_opportunities.bin";
		
		protected void Page_Load(object sender, EventArgs e)
        {
			LoadAll();
			UpdateLists();
			if (Session["sort"] == null) Session["sort"] = 1;
		}
			
		/// <summary>
		/// Updates displayed list of classes and whatever
		/// </summary>
		private void UpdateLists()
		{
			var L = Session["classes"] as List<FitnessClassOpportunity>;
			if (L == null) L = new List<FitnessClassOpportunity>();

			listClasses.Items.Clear();
			System.Linq.IOrderedEnumerable<FitnessClassOpportunity> ops;
			//switch statement to tell us that the default order, and then the order if another button were to be pressed.
			var sort = Session["sort"] == null ? 1 : (int)Session["sort"];
			switch (sort)
			{
				case 1:
					ops = from o in L
						  orderby o.id, o.start_date, o.location
						  select o;
					break;
				case 2:
					ops = from o in L
						  orderby o.location, o.start_date, o.location
						  select o;
					break;
				// case 3
				default:
					ops = from o in L
						  orderby o.start_date, o.location
						  select o;
					break;
			}

			foreach (var op in ops)
			{
				// text label is created by opportunity.ToString() method
				var listitem = new ListItem(op.ToString(), op.id);
				listClasses.Items.Add(listitem);
			}
			Session["classes"] = L;
		}


		private void LoadAll()
		{
			if (!File.Exists(m_serialize_file)) return;

			// Open the file containing the data that you want to deserialize.
			FileStream fs = new FileStream(m_serialize_file, FileMode.Open);
			try
			{
				BinaryFormatter formatter = new BinaryFormatter();

				// Deserialize the table from the file and 
				// assign the reference to the local variable.
				var L = (List<FitnessClassOpportunity>)formatter.Deserialize(fs);
				Session["classes"] = L;
			}
			catch (SerializationException)
			{
				//MessageBox.Show(this, "Save error:: " + e.Message, "oops",
				//	MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				fs.Close();
			}
		}

		protected void buttonAddClass_Click(object sender, EventArgs e)
		{
			Response.Redirect("FitnessOps.aspx");
		}

		protected void buttonSortId_Click(object sender, EventArgs e)
		{
			Session["sort"] = 1;
			UpdateLists();
		}

		protected void buttonSortLoc_Click(object sender, EventArgs e)
		{
			Session["sort"] = 2;
			UpdateLists();
		}

		protected void buttonSortDate_Click(object sender, EventArgs e)
		{
			Session["sort"] = 3;
			UpdateLists();
		}

		protected void buttonSave_Click(object sender, EventArgs e)
		{
			SaveAll();
		}

		 //saveall function shows that when clicked all the classes will be saved into the file.
		 private void SaveAll()
		 {
		     FileStream outFile;
		     StreamWriter writer;

		     outFile = new FileStream("class.txt", FileMode.Create,
		                              FileAccess.Write);  

		     writer = new StreamWriter(outFile);

		     for (int i = 0; i < listClasses.Items.Count; i++)
		     {
		     writer.WriteLine(Convert.ToString(listClasses.Items[i]));
		     }
		     writer.Close();                       
		     outFile.Close();

		     FileStream fs = new FileStream(m_serialize_file, FileMode.Create);           

		     // Construct a BinaryFormatter and use it to serialize the data to the stream.
		     BinaryFormatter formatter = new BinaryFormatter();
		     try
		     {
				 var L = Session["classes"] as List<FitnessClassOpportunity>;
				 if (L == null) L = new List<FitnessClassOpportunity>();
				 formatter.Serialize(fs, L);
		     }
		         //exception for any error.
		     catch (SerializationException )
		     {
		         //MessageBox.Show(this, "Save error:: " + e.Message, "oops",
		         //    MessageBoxButtons.OK, MessageBoxIcon.Error);
		     }
		     finally
		     {
		         fs.Close();
		     }

		 }

		/// <summary>
		/// Extracts a field from POSTed form, and attempts to select the corresponding
		/// line in listClasses, searching by opportunity.ID
		/// </summary>
		 private void SelectSelectedItem()
		 {
			 var selecteditm = listClasses.Items.FindByValue(Request.Params["listClasses"]);
			 listClasses.SelectedIndex = listClasses.Items.IndexOf(selecteditm);
		 }

		 protected void listClasses_SelectedIndexChanged(object sender, EventArgs e)
		 {
			 SelectSelectedItem();
			 textClassDescr.Text = "";
			 if (listClasses.SelectedIndex < 0)
			 {
				 return;
			 }
			 var opid = listClasses.SelectedItem.Value;

			 var L = Session["classes"] as List<FitnessClassOpportunity>;
			 if (L == null) L = new List<FitnessClassOpportunity>();
	
			 var op = from o in L
					  where o.id == opid
					  select o;
			 if (op.Count() > 0)
			 {
				 textClassDescr.Text = op.First().Present();
			 }
		 }

		 protected void buttonDeleteClass_Click(object sender, EventArgs e)
		 {
			 SelectSelectedItem();
			 if (listClasses.SelectedIndex < 0) return;

			 var L = Session["classes"] as List<FitnessClassOpportunity>;
			 if (L == null) L = new List<FitnessClassOpportunity>();

			 /*
			 var newL = from o in L
					where o.id != listClasses.SelectedItem.Value
					select o;

			 L.Clear();
			 foreach (var Litem in newL) L.Add(Litem);
			 */
			 L = L.FindAll(
				delegate(FitnessClassOpportunity fop)
				{
					return fop.id != listClasses.SelectedItem.Value;
				});

			 Session["classes"] = L;
			 Response.Redirect("Fitness.aspx");
		 }

    }
}
//{
//    public partial class Fitness : Form
//    {

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
//        //loadall function loads classes automatically, no need for button on the UI, makes it more clean.

//        private void Fitness_Load(object sender, EventArgs e)
//        {
//            SaveAll();
//        }
//    }
//}