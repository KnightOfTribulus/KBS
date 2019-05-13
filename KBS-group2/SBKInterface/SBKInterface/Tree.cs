using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBKInterface
{

    class Tree
    {
        public bool IsClause { get; set; } = true;

        public string Text { get; set; }

        public bool IsActive { get; set; } = false;
        public string Id; 
        public Tree Left { get; set; } = null;
        public Tree Right { get; set; } = null;
        public Tree Prev { get; set; } = null;


        Tree res = null;

        public Tree(string id)
        {
            this.Id = id;
        }

        public Tree AddLeft(string id)
        {
            Left = new Tree(id);
            Left.Prev = this;
            return Left;
        }

        public Tree AddRight(string id)
        {
            Right = new Tree(id);
            Right.Prev = this;
            return Right;
        }

        public Tree FindName(Tree node, string name)
        {
            if (node.Id == name)
            {
                return node;
            }
            if(node.Left != null)
            {
                res = FindName(node.Left, name);
            }
            if (node.Right != null)
            {
                res = FindName(node.Right, name);
            }

            return res;
        }

        public static void Serialize(Tree node, ref string str)
        {
            if (node.Prev == null && node != null)
            {
                str = "";
            }
            if (node == null || node.IsActive == false)
            {
                str = str + "#;";
            }
            else
            {
                str = str + node.Text + "|" + node.IsClause + ";";
                Serialize(node.Left, ref str);
                Serialize(node.Right, ref str);
            }
        }
       
        public static List<List<Tree>> GetPath(Tree node, ref List<List<Tree>> way, ref List<Tree> current_way)
        {
                if (way == null)
                {
                    way = new List<List<Tree>>();
                }
                if (current_way == null)
                {
                    current_way = new List<Tree>();
                }
                current_way.Add(node);

                try
                {
                    if (node.Left.Text == null && node.Right.Text == null)
                    {
                    way.Add(current_way);
                    }
                    else
                    {
                    if (node.Left.Text != null)
                        {
                        List<Tree> copy = current_way.ToList();
                        GetPath(node.Left, ref way, ref copy);
                        }
                    if (node.Right.Text != null)
                        {
                        List<Tree> copy = current_way.ToList();
                        GetPath(node.Right, ref way, ref copy);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                way.Add(current_way);
            }
            return way;
      

        }
    }
}
