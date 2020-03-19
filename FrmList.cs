using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp___Listbox
{
    public partial class FrmList : Form
    {
        List<string> strList = new List<string>();
        List<Dog> dogList = new List<Dog>();


        public FrmList()
        {
            InitializeComponent();
        }

        private void FrmList_Load(object sender, EventArgs e)
        {
            dogList.Clear();
            dogList.Add(new Dog() { Name = "Bob", Age = 45 });
            dogList.Add(new Dog() { Name = "Joe", Age = 23 });

            strList.Clear();
            strList = new List<string>() { "One", "Two", "Three" };

        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (TxtItem.Text != "")
            {
                strList.Add(ProperCase(TxtItem.Text));
                LbxTest.DataSource = null;
                LbxTest.DataSource = strList;
                TxtItem.Text = "";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LbxTest.DataSource = null;
        }

        private void BtnDog_Click(object sender, EventArgs e)
        {
            //LbxTest.DataSource = null;
            //LbxTest.DataSource = dogList;
            //LbxTest.DisplayMember = "Age";

            foreach (Dog dog in dogList)
            {
                strList.Add($"{dog.Name} - {dog.Age}");
                LbxTest.DataSource = null;
                LbxTest.DataSource = strList;
              
            }

        }

        public string ProperCase(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
        }
    }

    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}


