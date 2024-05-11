using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Practices.Topics
{
    public class RefOutINRecursion
    {

        public Node SendRefRecursion()
        {
            //int height = 0;
            Node height = new Node();
            return SendRefRecursion(ref height);
        }
        public Node SendRefRecursion(ref Node height)
        {
            height.raight++;
            if (height.raight == 5)
                return height;

            return SendRefRecursion(ref height);

        }
        public int SendRefRecursion(ref int height)
        {
            height++;
            if (height == 5)
                return height;

            return SendRefRecursion(ref height);

        }


        // out
        public int SendOutRecursion()
        {
            int height;
            return SendOutRecursion(out height);
        }

        public int SendOutRecursion(out int height)
        {
            return SendOutRecursion(out height) + 1;
        }
    }
    public class Node
    {
       internal int raight = 0;
       internal int left = 0;

    }
}
