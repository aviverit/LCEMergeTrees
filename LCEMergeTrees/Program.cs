using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCEMergeTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tree1 = new TreeNode(1);
            Tree1.left.val = 3;
            Tree1.right.val = 2;
            Tree1.left.left.val = 5;

            var Tree2 = new TreeNode(2);
            Tree2.left.val = 1;
            Tree2.right.val = 3;
            Tree2.left.right.val = 4;
            Tree2.right.right.val = 7;

            var Solution = new Solution();

            TreeNode Result;

            Result = Solution.MergeTrees(Tree1,Tree2);


        }
    }
}
