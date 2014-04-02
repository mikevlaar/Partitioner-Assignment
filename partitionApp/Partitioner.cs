using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partitionApp
{
    class Partitioner
    {
        public int numberOfPartitions = 0;

        public void partition(int n, int max, String prefix)
        {
            if (n == 0)
            {
                Console.WriteLine(prefix);
                numberOfPartitions++;
                return;
            }

            for (int i = Math.Min(n,max); i >= 1; i--)
            {
                partition(n - i, i, prefix + " " + i);
            }
        }

        public void printPartitions(int target, int max, String suffix)
        {
            if (target == 0)
               Console.WriteLine(suffix);
            else
            {
                for (int i = 1; i <= max && i <= target; i++)
                {
                    printPartitions(target - i, i, i + " " + suffix);
                }
            }
        }
    }
}
