using System;

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            Program c1 = new Program();
            Console.Write("n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("r : ");
            int r = Convert.ToInt32(Console.ReadLine());
            double size = c1.Kombinasyon(n, r);
            Console.WriteLine(n + "'in " + r +"'li kombinasyonu : " + size);
        }
        public double Faktoriyel(int n){
            
            double facValue = 1;
            if(n == 0 || n == 1) facValue = 1;
            else{
                for(int i =1 ; i <= n ; i++){
                    facValue = facValue * i;
                }
            }
            return facValue;

        }
        public double Kombinasyon(int n, int r ){
            
            double sonuc = Faktoriyel(n)/((Faktoriyel(r) * Faktoriyel(n - r)));
            return sonuc;
        }
    }
}
