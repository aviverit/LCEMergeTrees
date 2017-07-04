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
            if (t1.val != null && t2.val != null)
            {
                rootVal = t1.val + t2.val;

            }
            else if (t1.val != null)
            {
                rootVal = t1.val;
            }
            else
            {
                rootVal = t2.val;
            }
            var tempResult = new TreeNode(rootVal);
            if (t1.left.val != null || t2.left.val != null) {
                MergeTrees(t1.left, t2.left);
            } else if (t1.right.val != null || t2.right.val != null) {
                MergeTrees(t1.right, t2.right);
            }
            return tempResult;
        }
    }
}
