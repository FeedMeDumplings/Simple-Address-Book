/*Zigmyal Wangchuk
 * Project: Assignment 1 [Address Book]
 * Purpose: Allows user to add and view contacts. Has certain restrictions:
 * 1. Zip has to be 5 digits
 * 2. Phone # has to be 10 digits
 * Language: C# [Windows Application]
 * Due Date: 1/23/2014 [5:30 pm]
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Asg_01
{
    public partial class Form1 : Form
    {
        //class for the variables
        public class ContactInfo
        {
            public string firstName{get;set;} 
            public string lastName {get;set;}
            public string Street{get;set;} 
            public string Zip{get;set;}
            public string Phone {get;set;}

            public override bool Equals(object obj)
            {
                if (obj is ContactInfo)
                {
                    return obj.GetHashCode() == GetHashCode();
                }

                return false;
            }

            public override int GetHashCode()
            {
                return Phone.GetHashCode();
            }
            
        }

        /*creating linked list
         * to hold input before writing to xml file
         * to hold previous data from xml file before update
         * */
        List<ContactInfo> userInfo = new List<ContactInfo>();

        public Form1()
        {
            InitializeComponent();

            //initializing input check for Zip and Phone#
            this.txtZip.TextChanged += txtZip_TextChanged;
            this.txtPhone.TextChanged += txtPhone_TextChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(userInfo.GetType(), new XmlRootAttribute("users"));

            using (FileStream stream = File.OpenRead("Userinfo.xml"))
            {
                userInfo = (List<ContactInfo>)serializer.Deserialize(stream);
            }
        }
       
        //Purpose: To add new user information to xml file
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContactInfo addInfo = new ContactInfo();
            addInfo.firstName = txtFirst.Text.ToString();
            addInfo.lastName = txtLast.Text.ToString();
            addInfo.Street = txtStreet.Text.ToString();
            addInfo.Zip = txtZip.Text.ToString();
            addInfo.Phone = txtPhone.Text.ToString();
            
            if (userInfo.Exists(item => item == addInfo))
            {
                lblUpdate.Text = "Contact already exist!";
            }
            else
            {
                if(txtFirst.Text.Length == 0 ||
                    txtLast.Text.Length == 0 ||
                    txtStreet.Text.Length == 0 ||
                    txtZip.Text.Length == 0 ||
                    txtZip.Text.Length == 0)
                {
                    lblUpdate.Text = "Please make sure all the fields are filled!";
                }
                else if (addInfo.Zip.Length != 5 && addInfo.Phone.Length != 10)
                {
                    /*using error provider feature to prompt
                     * for invalid data entry
                     */
                    errZip.Clear();
                    errPhone.Clear();
                    errZip.SetError(txtZip, "Zip Code needs to be 5 digits! <eg. 05401>");
                    errPhone.SetError(txtPhone, "Phone # should have 10 digits! <eg. 3109095509>");
                }
                else if (addInfo.Zip.Length != 5)
                {
                    errZip.Clear();
                    errPhone.Clear();
                    errZip.SetError(txtZip, "Zip Code needs to be 5 digits! <eg. 05401>");
                }
                else if (addInfo.Phone.Length != 10)
                {
                    errZip.Clear();
                    errPhone.Clear();
                    errPhone.SetError(txtPhone, "Phone # should have 10 digits! <eg. 3109095509>");
                }
                else
                {
                    userInfo.Add(addInfo);

                    //need serializer to write input to xml file
                    XmlSerializer writer = new XmlSerializer(userInfo.GetType(), new XmlRootAttribute("users"));

                    using (StreamWriter file = new StreamWriter("Userinfo.xml"))
                    {
                        writer.Serialize(file.BaseStream, userInfo);
                    }

                    //clearing all text fields and error prompts
                    txtFirst.Clear();
                    txtLast.Clear();
                    txtStreet.Clear();
                    txtZip.Clear();
                    txtPhone.Clear();

                    lblUpdate.Text = "Contact added to address book!";
                    errZip.Clear();
                    errPhone.Clear();
                }
            }    
        }

        //Purpose: Writing from saved file to GridView
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Bindingsource encapsulates data source for a form 
            BindingSource source = new BindingSource();
            source.DataSource = userInfo;
            dgContact.DataSource = source;

            //labeling hearder for the table in gridview box
            dgContact.Columns[0].HeaderText = "First Name";
            dgContact.Columns[1].HeaderText = "Last Name";
            dgContact.Columns[2].HeaderText = "Street";
            dgContact.Columns[3].HeaderText = "Zip Code";
            dgContact.Columns[4].HeaderText = "Phone #";

            dgContact.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //Checking if input in Zip is a string of numbers
        //disabling alphabetic characters from being pressed
        private void txtZip_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.txtZip.Text)
            {
                if (char.IsDigit(ch))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.txtZip.Text = sb.ToString();
                this.txtZip.SelectionStart = this.txtZip.Text.Length;
            }
        }

        //Checking if input in Phone # is a string of numbers
        //disabling alphabetic characters from being pressed
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.txtPhone.Text)
            {
                if (char.IsDigit(ch))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.txtPhone.Text = sb.ToString();
                this.txtPhone.SelectionStart = this.txtPhone.Text.Length;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirst.Clear();
            txtLast.Clear();
            txtStreet.Clear();
            txtZip.Clear();
            txtPhone.Clear();

            txtFirst.Focus();
            txtFirst.Select(0, 0);

            //this.txtFirst.SelectionStart = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactInfo addInfo = new ContactInfo();
            addInfo.firstName = txtFirst.Text.ToString();
            addInfo.lastName = txtLast.Text.ToString();
            addInfo.Street = txtStreet.Text.ToString();
            addInfo.Zip = txtZip.Text.ToString();
            addInfo.Phone = txtPhone.Text.ToString();

            if (userInfo.Exists(item => item == addInfo))
            {
                lblUpdate.Text = "Contact already exist!";
            }
            else
            {
                if (txtFirst.Text.Length == 0 ||
                    txtLast.Text.Length == 0 ||
                    txtStreet.Text.Length == 0 ||
                    txtZip.Text.Length == 0 ||
                    txtZip.Text.Length == 0)
                {
                    lblUpdate.Text = "Please make sure all the fields are filled!";
                }
                else if (addInfo.Zip.Length != 5 && addInfo.Phone.Length != 10)
                {
                    /*using error provider feature to prompt
                     * for invalid data entry
                     */
                    errZip.Clear();
                    errPhone.Clear();
                    errZip.SetError(txtZip, "Zip Code needs to be 5 digits! <eg. 05401>");
                    errPhone.SetError(txtPhone, "Phone # should have 10 digits! <eg. 3109095509>");
                }
                else if (addInfo.Zip.Length != 5)
                {
                    errZip.Clear();
                    errPhone.Clear();
                    errZip.SetError(txtZip, "Zip Code needs to be 5 digits! <eg. 05401>");
                }
                else if (addInfo.Phone.Length != 10)
                {
                    errZip.Clear();
                    errPhone.Clear();
                    errPhone.SetError(txtPhone, "Phone # should have 10 digits! <eg. 3109095509>");
                }
                else
                {
                    userInfo.Add(addInfo);

                    using (StreamWriter file = new StreamWriter("Userinfo.txt"))
                    {
                        foreach (ContactInfo x in userInfo)
                        {
                            string temp = x.firstName + "\t" + x.lastName + "\t" + x.Street + "\t" + x.Zip.ToString() + "\t" + x.Phone.ToString();
                            file.WriteLine(temp);
                        }
                    }

                    //clearing all text fields and error prompts
                    txtFirst.Clear();
                    txtLast.Clear();
                    txtStreet.Clear();
                    txtZip.Clear();
                    txtPhone.Clear();

                    lblUpdate.Text = "Contact added to address book!";
                    errZip.Clear();
                    errPhone.Clear();
                }
            }    
        }

        private void rbXml_CheckedChanged(object sender, EventArgs e)
        {
            //userInfo.Clear();

                gbXml.Visible = true;
                gbText.Visible = false;

                XmlSerializer serializer = new XmlSerializer(userInfo.GetType(), new XmlRootAttribute("users"));

                using (FileStream stream = File.OpenRead("Userinfo.xml"))
                {
                    userInfo = (List<ContactInfo>)serializer.Deserialize(stream);
                }
        }

        private void rbText_CheckedChanged(object sender, EventArgs e)
        {
            userInfo.Clear();

            gbXml.Visible = false;
            gbText.Visible = true;

            try
            {
                   foreach (var line in File.ReadAllLines("Userinfo.txt"))
                   {
                       var columns = line.Split('\t');
                       userInfo.Add(new ContactInfo
                       {
                           firstName = columns[0],
                           lastName = columns[1],
                           Street = columns[2],
                           Zip = columns[3],
                           Phone = columns[4]
                       });
                   }
            }
            catch
           {
               lblUpdate.Text = "File does not exist!";
            }
        }

        private void btnLoadText_Click(object sender, EventArgs e)
        {
            //Bindingsource encapsulates data source for a form 
            BindingSource source = new BindingSource();
            source.DataSource = userInfo;
            dgContact.DataSource = source;

            //labeling hearder for the table in gridview box
            dgContact.Columns[0].HeaderText = "First Name";
            dgContact.Columns[1].HeaderText = "Last Name";
            dgContact.Columns[2].HeaderText = "Street";
            dgContact.Columns[3].HeaderText = "Zip Code";
            dgContact.Columns[4].HeaderText = "Phone #";

            dgContact.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
