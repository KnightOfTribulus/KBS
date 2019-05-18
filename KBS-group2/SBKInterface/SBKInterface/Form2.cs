using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBKInterface
{
    public partial class Form2 : Form
    {
        public List<string> StringList { get; set; }

        public Form2()
        {
            InitializeComponent();
            okB.Location = new Point(760, 422);
            StringList = new List<string>();
        }

        private void StartWorkingB_Click(object sender, EventArgs e)
        {
            okB.Show();
            textBox.Show();
        }

        private void okB_Click(object sender, EventArgs e)
        {
            if(textBox.Text.Length > 2)
            {
                StringList.Add(textBox.Text);
                textBox.Clear();
            }
        }

        private void doneB_Click(object sender, EventArgs e)
        {
           
        }
    }
}
