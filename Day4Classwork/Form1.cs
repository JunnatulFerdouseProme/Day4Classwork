using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day4Classwork
{
    public partial class ListUi : Form
    {
        List<string> name = new List<string> { "Junnatul Ferdouse Prome" };
        List<int> age = new List<int> { 10 };
        public ListUi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowCustomer();
           
        }
        private  void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(ageTextBox.Text))
                {
                    MessageBox.Show("Please Enter Age");
                    return;
                }
                else
                {
                    age.Add(Convert.ToInt32(ageTextBox.Text));
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            name.Add(nameTextBox.Text);
            //age.Add(Convert.ToInt32(ageTextBox.Text));
            ShowCustomer();
            //MessageBox.Show("Add");
            
        }
        private void ShowCustomer()
        {
            string message = "";
            for (int i = 0; i < name.Count; i++)
            {
                message += "Name:" + name[i] + "\n" +"Age:" +age[i]+"\n";
            }
            itemRichTextBox.Text = message;
            //foreach (string name in names)
            //{
            //    message += "Name:" + name + "\n";
            //}
            //itemRichTextBox.Text = message;
        }
    }
}
