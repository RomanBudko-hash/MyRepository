

namespace SomethingProject
{
    public class MostLastClassOnThisProject
    {
        public int[] MergeSort(ref int[] array)
        {
            if (array.Length > 1)
            {
                int[] left = new int[array.Length / 2];

                int[] right = new int[array.Length - left.Length];

                for (int i = 0; i < left.Length; i++)
                {
                    left[i] = array[i];
                }
                for (int i = 0; i < right.Length; i++)
                {
                    right[i] = array[left.Length + i];
                }
                if (left.Length > 1)
                {
                    left = MergeSort(ref left);
                }
                if (right.Length > 1)
                {
                    right = MergeSort(ref right);
                }
                array = Sort(left, right);
            }
            return array;
        }

        public int[] Sort(int[] left, int[] right)
        {
            int[] buff = new int[left.Length + right.Length];

            int i = 0, l = 0, r = 0;
            
            for(; i < buff.Length; i++)
            {
                if (r >= right.Length)
                {
                    buff[i] = left[l];
                    l++;
                }
                else if (l < left.Length && left[l] < right[r])
                {
                    buff[i] = left[l];
                    l++;
                }
                else
                {
                    buff[i] = right[r];
                    r++;
                }
            }
            return buff;
        }
    }
}
