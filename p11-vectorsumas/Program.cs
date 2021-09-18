using System;

namespace p11_vectorsumas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[30];
            Random rnd = new Random();
            int np=0, nn=0, sp=0, sn=0;

            for(int i=0; i<v.Length; i++) {
                v[i] = rnd.Next(-100,100);
                Console.Write($"{v[i]} ");
                if(v[i]>0) {
                    np++;
                    sp += v[i];
                } else {
                    nn++;
                    sn += v[i];
                }
            }
            Console.WriteLine($"\nPositivos {np} y la suma {sp}");
            Console.WriteLine($"\nNegativos {nn} y la suma {sn}");
        }
    }
}
