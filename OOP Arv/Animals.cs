using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Animals
    {
        public string Sound;
        public int Legs;
        public string Tail;
        public string food;
        public int Size;

        public Animals(string _Sound,int _Legs,string _Tail,string _food,int _size) 
        
        { 
            this.Sound = _Sound;
            this.Legs = _Legs;
            this.Tail = _Tail;
            this.food = _food;
            this.Size = _size;
        
        }

        public virtual void GetSound() 
        {

            Console.WriteLine("");

        }

        public virtual void GetLegs() 
        
        {

            Console.WriteLine("");
        
        }

        public virtual void GetTail()

        {
            Console.WriteLine("hello world");
        }
    }
}
