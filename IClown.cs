using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IClown
    {
        string FunnyThing { get;  }
        void Honk();
        
        interface IScaryClown : IClown
        {
            string ScaryThingIHave { get; }
            void ScareLittleChildren();
        }
        class FunnyFunny : IClown
        {
            public FunnyFunny(string funnyThingIHave)
            {
                this.funnyThingIHave = funnyThingIHave;
            }
            private string funnyThingIHave
            {
                get { return "HI! + " + funnyThingIHave; }
            }
            public void Honk()
            {
                Console.WriteLine(this.funnyThingIHave);
            }
        }

        class ScaryScary : FunnyFunny, IScaryClown
        {
            public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingsIHave)
            {
                this.numberOfScaryThings = numberOfScaryThings;
            }

            private int numberOfScaryThings;
            public string ScaryThingsIHave
            {
                get { return "Mam " + numberOfScaryThings + " pajakow"; }
            }

            public void ScareLittleChildren()
            {
                Console.WriteLine("BU XD");
            }
        }


    }
}
