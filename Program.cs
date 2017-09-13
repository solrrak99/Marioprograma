using System;

namespace mario
{
    class Program
    {
        static void Main(string[] args)
        {
        String cad = "";
        int n,w,y;
        Console.WriteLine("ingrese un numero no mayor a 28:");
        n = Convert.ToInt32(Console.ReadLine());
        for(y=1;y<n+1;y++){
         cad="";
        for(w=1;w<y+1;w++){
        cad=cad+"#";
         }
         Console.WriteLine(cad.PadLeft(n)); 
     }
        //Carlos Alejandro Villegas Nuñez
                                
        //Reyes Aceves Sergio
        }
    }
}
