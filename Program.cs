using System;

namespace U4_programa_1
{
    class Program
    {
        static void Main(string[] args)
        { int n1,n2,cuenta;
            Console.WriteLine("Ingresa un número por favor");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro número  por favor");
            n2=int.Parse(Console.ReadLine());

            if (n1>n2){
               cuenta= n1-n2;
               Console.WriteLine("la resta del primer numero con el seguendo es "+cuenta);  
            }else if (n2>n1){
                cuenta=n2*n1;
                Console.WriteLine("el producto del primer numero con el seguendo es "+cuenta);
            }else{
                cuenta=n1+n2;
                Console.WriteLine("la suma del primer numero con el seguendo es "+cuenta);
            }


        }

    }
}
