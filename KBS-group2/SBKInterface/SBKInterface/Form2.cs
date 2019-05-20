using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inference;

namespace SBKInterface
{
    public partial class Form2 : Form
    {
        public List<string> StringList { get; set; }

        //Методы вызова механизма вывода и выдача результата пользователю
        private void Say(string input)
        {
            Form dial = new Form();
            dial.Text = input;
            dial.ShowDialog();
        }
        private string CallInference(string facts, IEnumerable<string> antIds, IEnumerable<string> antVals, IEnumerable<string> consIds, IEnumerable<string> consVals)
        {
            return Inference.Inference.MakeInference(facts, antIds, antVals, consIds, consVals);
        }

        private void CallAndPrintInference(string facts, IEnumerable<string> antIds, IEnumerable<string> antVals, IEnumerable<string> consIds, IEnumerable<string> consVals)
        {
            var res = CallInference(facts, antIds, antVals, consIds, consVals);
            Say(res);
            GC.Collect();
        }
        //конец методов выозова вывода и выдачи результатов

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
                KnowledgeBase.Read();
                CallAndPrintInference(textBox.Text, KnowledgeBase.antId, KnowledgeBase.antVals, KnowledgeBase.consId, KnowledgeBase.consVals);
            }
        }

        private void doneB_Click(object sender, EventArgs e)
        {
           
        }
    }
}
