using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Dog:Animals
    {

        public int Numberoflegs=4;
        public string Dogsound = "Bark";
        public string Dogtail = "Long";
      

        public  Dog (string _Dogsound,string _Dogtail, int _speed, int _size,int _Numberoflegs) : base(_Dogsound,_Numberoflegs,_Dogtail, _speed, _size)
        { 
        
            this.Legs = _Numberoflegs;
            this.Sound = _Dogsound;
            this.Tail = _Dogtail;
        
        }
        public override void GetLegs()
        {
            Console.WriteLine($"Have {Numberoflegs} Legs ");
        }
        public override void GetSound()
        {
            Console.WriteLine($"Dogs {Dogsound} Loud ");
        }
        public override void GetTail() 
        {
            Console.WriteLine($"Dogs have {Dogtail} tails ");
        }
    }
}
