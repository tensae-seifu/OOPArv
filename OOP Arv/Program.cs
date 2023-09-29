using djurar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog pappy=new Dog("Scobby","Friendly");

            pappy.MakeSound();
            pappy.GetFood();
            pappy.GetHabitat();
            pappy.Attit();

         
        }
    }
}
