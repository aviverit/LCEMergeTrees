using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCEMergeTrees
{
    public class Solution
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            int rootVal;
            if (t1.val != null && t2.val != null) {
                rootVal = t1.val + t2.val;

            }
            var tempResult = new TreeNode(rootVal);
            while (t1.left != null) { }
            return tempResult;
        }
    }
}
