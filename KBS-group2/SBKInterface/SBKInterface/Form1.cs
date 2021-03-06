﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBKInterface
{
    public partial class Form1 : Form
    {
        private string doneTree = "";

        private bool paintFlag = false;
        private bool newTreeFlag = true;
        private bool clauseFlag = true;
        private bool alreadyClicked = false;

        private string clicked = "";

        private Tree mainTree = null;

        private List<Button> positionsList = new List<Button>();

        public Form1()
        {
            InitializeComponent();

            AddPanel.Visible = false;

            positionsList.Add(button0);
            button0.Enabled = false;
            button0.Visible = false;

            mainTree = new Tree(button0.Name);


            Button button = new Button()
            {
                Size = new Size(200, 100),
                Name = "button1",
                Location = new Point(450, 100 + 150),
                Enabled = false,
                Visible = false,
            };

            button.Click += control_button_Click;
            this.Controls.Add(button);
            positionsList.Add(button);

            mainTree.AddLeft(button.Name);

            Button button2 = new Button()
            {
                Size = new Size(200, 100),
                Name = "button2",
                Location = new Point(1290, 100 + 150),
                Enabled = false,
                Visible = false
            };

            button2.Click += control_button_Click;
            this.Controls.Add(button2);
            positionsList.Add(button2);

            mainTree.AddRight(button2.Name);

            Tree curLeft = mainTree.Left;
            Tree curRight = mainTree.Right;

            for (int i = 0; i < 2; i++)
            {
                Button button3 = new Button()
                {
                    Size = new Size(200, 100),
                    Name = "button" + (3 + i),
                    Location = new Point(240 + 420 * i, 100 + 300),
                    Enabled = false,
                    Visible = false
                };

                button3.Click += control_button_Click;
                this.Controls.Add(button3);
                positionsList.Add(button3);

                if(i % 2 == 0)
                {
                    curLeft.AddLeft(button3.Name);
                }
                else
                {
                    curLeft.AddRight(button3.Name);
                }
                

                Button button4 = new Button()
                {
                    Size = new Size(200, 100),
                    Name = "button" + (5 + i),
                    Location = new Point(1080 + 420 * i, 100 + 300),
                    Enabled = false,
                    Visible = false
                };

                if (i % 2 == 0)
                {
                    curRight.AddLeft(button4.Name);
                }
                else
                {
                    curRight.AddRight(button4.Name);
                }

                button4.Click += control_button_Click;
                this.Controls.Add(button4);
                positionsList.Add(button4);
            }

            curLeft = mainTree.Left.Left;
            curRight = mainTree.Right.Left;

            for (int i = 0; i < 4; i++)
            {
                

                Button button5 = new Button()
                {
                    Size = new Size(200, 100),
                    Name = "button" + (7 + i),
                    Location = new Point(135 + 210 * i, 100 + 450),
                    Enabled = false,
                    Visible = false
                };

                if (i % 2 == 0)
                {
                    curLeft.AddLeft(button5.Name);
                }
                else
                {
                    curLeft.AddRight(button5.Name);
                    curLeft = mainTree.Left.Right;
                }

                button5.Click += control_button_Click;
                this.Controls.Add(button5);
                positionsList.Add(button5);

                Button button6 = new Button()
                {
                    Size = new Size(200, 100),
                    Name = "button" + (11 + i),
                    Location = new Point(975 + 210 * i, 100 + 450),
                    Enabled = false,
                    Visible = false
                };

                if (i % 2 == 0)
                {
                    curRight.AddLeft(button6.Name);
                }
                else
                {
                    curRight.AddRight(button6.Name);
                    curRight = mainTree.Right.Right;
                }

                button6.Click += control_button_Click;
                this.Controls.Add(button6);
                positionsList.Add(button6);
            }

            curLeft = mainTree.Left.Left.Left;
            curRight = mainTree.Right.Left.Left;
            bool trFlag = false;
            byte trbFlag = 0;

            for (int i = 0; i < 8; i++)
            {
                int koef = default(int);
                if(i % 2 == 0)
                {
                    koef = 600;
                }
                else
                {
                    koef = 700;
                }

                Button button7 = new Button()
                {
                    Size = new Size(200, 100),
                    Name = "button" + (15 + i),
                    Location = new Point(82 + 105 * i, 100 + koef),
                    Enabled = false,
                    Visible = false
                };

                if (i % 2 == 0 && trFlag == false)
                {
                    curLeft.AddLeft(button7.Name);
                }
                else
                {
                    if(trFlag == false)
                    {
                        curLeft.AddRight(button7.Name);
                        curLeft = mainTree.Left.Left.Right;
                        ++trbFlag;
                        if (trbFlag == 2)
                        {
                            curLeft = mainTree.Left.Right.Left;
                        }
                    }
                    
                }

                if (i % 2 == 0 && trFlag == true)
                {
                    curLeft.AddLeft(button7.Name);
                }
                else
                {
                    if(trFlag == true)
                    {
                        curLeft.AddRight(button7.Name);
                        curLeft = mainTree.Left.Right.Right;
                    }
                    
                }

                button7.Click += control_button_Click;
                this.Controls.Add(button7);
                positionsList.Add(button7);
                
                Button button8 = new Button()
                {
                    Size = new Size(200, 100),
                    Name = "button" + (23 + i),
                    Location = new Point(922 + 105 * i, 100 + koef),
                    Enabled = false,
                    Visible = false
                };

                if(i % 2 == 0 && trFlag == true)
                {
                    curRight.AddLeft(button8.Name);
                }
                else
                {
                    if(trFlag == true)
                    {
                        curRight.AddRight(button8.Name);
                        curRight = mainTree.Right.Right.Right;
                    }
                }

                if (i % 2 == 0 && trFlag == false)
                {
                    curRight.AddLeft(button8.Name);
                }
                else
                {
                    if(trFlag == false)
                    {
                        curRight.AddRight(button8.Name);
                        curRight = mainTree.Right.Left.Right;
                        if (trbFlag == 2)
                        {
                            curRight = mainTree.Right.Right.Left;
                            trFlag = true;
                        }
                    }
                    
                }

                button8.Click += control_button_Click;
                this.Controls.Add(button8);
                positionsList.Add(button8);
            }
        }

        private void CreateTreeB_Click(object sender, EventArgs e)
        {
            CreateTreeB.Hide();
            paintFlag = true;
            Refresh();
            foreach (Button b in positionsList)
            {
                b.Visible = true;
            }
            RuleOrTextPanel.Location = new Point(870, 100);
            positionsList[0].Hide();

            CreateTextB.Enabled = false;
            RuleOrTextPanel.Show();
            doneB.Location = new Point(100, 100);
            doneB.Show();
            legendPanel.Visible = true;
            minusLabel.Visible = true;
            plusLabel.Visible = true;
        }

        private void CreateRuleB_Click(object sender, EventArgs e)
        {
            if(newTreeFlag == true)
            {
                DeleteNewRuleB.Enabled = false;
            }

            Button b = sender as Button;
            AddPanel.Location = b.Parent.Parent.Location;
            AddPanel.Show();
            RuleOrTextPanel.Hide();

            clauseFlag = true;
        }

        private void CreateTextB_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            AddPanel.Location = b.Parent.Parent.Location;
            AddPanel.Show();
            RuleOrTextPanel.Hide();

            clauseFlag = false;
        }

        private void SaveNewRuleB_Click(object sender, EventArgs e)
        {
            if(RuleTextTB.Text.Length < 2)
            {
                return;
            }

            if(newTreeFlag == true)
            {

                AddPanel.Hide();

                mainTree.Text = RuleTextTB.Text;
                mainTree.IsActive = true;

                TableLayoutPanel zero = new RuleTextPanelPreset(RuleTextTB.Text, "button0").Table;
                this.Controls.Add(zero);
                Button zeroLoc = sender as Button;
                zero.Location = zeroLoc.Parent.Parent.Location;
                RuleTextTB.Clear();

                positionsList[1].Enabled = true;
                positionsList[2].Enabled = true;
                CreateTextB.Enabled = true;

                DeleteNewRuleB.Enabled = true;
                newTreeFlag = false;
                return;
            }

            AddPanel.Hide();
            Tree cell = mainTree.FindName(mainTree, clicked);
            cell.Text = RuleTextTB.Text;
            cell.IsActive = true;

            

            RuleTextTB.Clear();

            TableLayoutPanel tlp = new RuleTextPanelPreset(cell.Text, cell.Id).Table;

            this.Controls.Add(tlp);
            Button bLoc = sender as Button;
            tlp.Location = bLoc.Parent.Parent.Location;

            if (clauseFlag == true)
            {

            }

            if (clauseFlag == false)
            {
                tlp.BackColor = SystemColors.GradientActiveCaption;
                tlp.GetControlFromPosition(0,1).BackColor = SystemColors.GradientActiveCaption;
                cell.IsClause = false;
            }

            if (cell.Prev.IsClause)
            {
                foreach (Button a in positionsList)
                {
                    if (cell.Left != null)
                    {
                        if (a.Name == cell.Left.Id)
                        {
                            a.Enabled = true;
                        }
                    }
                    
                    if(cell.Right != null)
                    {
                        if (a.Name == cell.Right.Id)
                        {
                            a.Enabled = true;
                        }
                    }
                }
            }
            if (!cell.Prev.IsClause)
            {
                foreach (Button a in positionsList)
                {
                    if (a.Name == cell.Left.Id || a.Name == cell.Right.Id)
                    {
                        a.Enabled = true;
                    }
                }
                if(cell.Prev.Left.Id == cell.Id)
                {
                    foreach (Button a2 in positionsList)
                    {
                        if(cell.Prev.Right.Id == a2.Name)
                        {
                            a2.Enabled = false;
                        }
                    }
                }
                else
                {
                    foreach (Button a2 in positionsList)
                    {
                        if (cell.Prev.Left.Id == a2.Name)
                        {
                            a2.Enabled = false;
                        }
                    }
                }
            }

            alreadyClicked = false;
        }

        private void DeleteNewRuleB_Click(object sender, EventArgs e)
        {
            AddPanel.Hide();
            RuleTextTB.Clear();
            //RuleOrTextPanel.Show();
            foreach (Button a in positionsList)
            {
                if(a.Location == AddPanel.Location)
                {
                    a.Enabled = true;
                    a.Show();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(paintFlag == true)
            {
                Pen blackPen = new Pen(Color.Black, 2);

                int x1 = 970;
                int y1 = 200;
                int x2 = 550;
                int y2 = 250;
                e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);

                x2 = 1390;
                e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);

                y1 = 350;
                y2 = 400;
                for (int i = 0; i < 2; i++)
                {
                    x1 = 550;
                    x2 = 340 + 420 * i;
                    e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);


                    x1 = 1390;
                    x2 = 1180 + 420 * i;
                    e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);
                }

                int koef = -1;
                y1 = 500;
                y2 = 550;
                for (int i = 0; i < 4; i++)
                {

                    if (i % 2 == 0)
                    {
                        ++koef;
                    }

                    x1 = 340 + 420 * koef;
                    x2 = 235 + 210 * i;
                    e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);

                    x1 = 1180 + 420 * koef;
                    x2 = 1075 + 210 * i;
                    e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);
                }

                koef = -1;
                y1 = 650;
                y2 = 700;
                for (int i = 0; i < 8; i++)
                {
                    if (i % 2 == 0)
                    {
                        ++koef;
                        y2 = 700;
                    }
                    else
                    {
                        y2 = 850;
                    }

                    x1 = 287 + 210 * koef;
                    x2 = 182 + 105 * i;
                    e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);

                    x1 = 1127 + 210 * koef;
                    x2 = 1022 + 105 * i;
                    e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);
                }
            }
        }

        private void control_button_Click(object sender, EventArgs e)
        {
            if(alreadyClicked == false)
            {
                Button b = sender as Button;
                clicked = b.Name;
                b.Visible = false;

                RuleOrTextPanel.Visible = true;
                RuleOrTextPanel.Location = b.Location;
                CreateTextB.Enabled = true;

                Tree t = mainTree.FindName(mainTree, b.Name);
                if (!t.Prev.IsClause)
                {
                    CreateTextB.Enabled = false;
                }
                
            }

            if(alreadyClicked == true)
            {
                foreach (Button b2 in positionsList)
                {
                    if(b2.Location == RuleOrTextPanel.Location)
                    {
                        b2.Show();
                        b2.BackColor = SystemColors.Control;
                        AddPanel.Hide();
                        RuleOrTextPanel.Hide();
                    }
                }

                Button b = sender as Button;
                clicked = b.Name;
                b.Visible = false;

                RuleOrTextPanel.Visible = true;
                RuleOrTextPanel.Location = b.Location;
                CreateTextB.Enabled = true;

                Tree t = mainTree.FindName(mainTree, b.Name);
                if (!t.Prev.IsClause)
                {
                    CreateTextB.Enabled = false;
                }
                
            }

            alreadyClicked = true;
        }

        private void doneB_Click(object sender, EventArgs e)
        {
            List<List<Tree>> way = null;
            List<Tree> curr_way = null;
            List<List<Tree>> a = Tree.GetPath(mainTree,ref way, ref curr_way);

            List<string> id_konsikventi = new List<string>();
            List<string> var_konsikventi = new List<string>();
            List<string> id_antisidenti = new List<string>();
            List<string> var_antisidenti = new List<string>();

            foreach (List<Tree> i in a)
            {
                foreach (Tree j in i)
                {
                    if (j.Text != null)
                    {
                        if (j.IsClause == false)
                        {

                            string[] tmp = j.Text.Split('-');

                            id_antisidenti.Add(tmp[0]);
                            var_antisidenti.Add(tmp[1]);
                        }
                        else
                        {   

                            string[] tmp = j.Text.Split('-');
                            
                            id_konsikventi.Add(tmp[0]);
                            var_konsikventi.Add(tmp[1]);
                        }    
                    }
                    
                }
            }





            PrintTreeInFile(doneTree);
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
        
        private void PrintTreeInFile(string str)
        {
            string file = Directory.GetCurrentDirectory() + "\\tree.txt";
            File.AppendAllText(file, str);
        }

    }
}
