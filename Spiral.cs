using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralTest
{
    public class Spiral
    {
        public static IEnumerable<int> Decode(int[,] a)
        {
            int i, k = 0, l = 0;
            var n = a.GetLength(1);
            var m = a.GetLength(0);
            while (k < m && l < n)
            {
                for (i = l; i < n; ++i)
                    yield return a[k, i];
                k++;
                for (i = k; i < m; ++i)
                    yield return a[i, n - 1];
                n--;
                if (k < m)
                {
                    for (i = n - 1; i >= l; --i)
                        yield return a[m - 1, i];
                    m--;
                }
                if (l < n)
                {
                    for (i = m - 1; i >= k; --i)
                        yield return a[i, l];
                    l++;
                }
            }
        }

        static public int[,] Encode(int[] vec)
        {
            int idx = 0;
            var m = (int)Math.Ceiling(Math.Sqrt(vec.Count()));
            var n = m;
            var a = new int[m, n];
            int k = 0, l = 0;
            while (k < m && l < n)
            {
                for (int i = l; i < n; ++i)
                    a[k, i] = vec[idx++];
                k++;
                for (int i = k; i < m; ++i)
                    a[i, n - 1] = vec[idx++];
                n--;
                if (k < m)
                { 
                    for (int i = n - 1; i >= l; --i)
                        a[m - 1, i] = vec[idx++];
                    m--;
                }
                if (l < n)
                {
                    for (int i = m - 1; i >= k; --i)
                        a[i, l] = vec[idx++];
                    l++;
                }
            }
            return a;
        }
    }
}
