using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace PopulateNameId
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllNames();
        }
        private void GetAllNames()
        {
            List<string> names = new List<string>();
            BLL.Demo demo = new Demo();
            names= demo.GetName();
            foreach(string name in names)
            {
                comboBox1.Items.Add(name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetId();
        }
        private void GetId()
        {
            BLL.Demo demo = new Demo();
            demo.Name = comboBox1.SelectedItem.ToString();
            string Id= demo.GetIdByName();
            label1.Text = Id;
        }
    }
}
