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
        public int Speed;
        public int Size;

        public Animals(string _Sound,int _Legs,string _Tail,int _speed,int _size) 
        
        { 
            this.Sound = _Sound;
            this.Legs = _Legs;
            this.Tail = _Tail;
            this.Speed = _speed;
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
            Console.WriteLine("");
        }
    }
}
