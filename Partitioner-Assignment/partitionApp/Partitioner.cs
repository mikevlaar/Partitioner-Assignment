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

        /**
         * Method to find all partitions for a given number.
         * @param int n partition value
         * @param int max number to use in partition.
         */ 
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
    }
}
