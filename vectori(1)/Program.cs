using System;

namespace vectori_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[100];
            int n, s=0, nrp=0;
            int minn = int.MaxValue;
            int maxx = int.MinValue;
            double med;

            n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                v[i] = Int32.Parse(Console.ReadLine());
                s = s + v[i];
                if (v[i] % 2 == 0) nrp++;
                if (v[i] < minn) minn = v[i];
                if (v[i] > maxx) maxx = v[i];
            }
            double sum = Convert.ToDouble(s);
            double nr = Convert.ToDouble(n);
            med = sum / nr;

            Console.WriteLine("Suma este: "+s);
            Console.WriteLine("Media este: "+med);
            Console.WriteLine("Numarul valorilor pare este: "+nrp);
            Console.WriteLine("Minimul: "+minn);
            Console.WriteLine("Maximul: "+maxx);

        }
    }
}
