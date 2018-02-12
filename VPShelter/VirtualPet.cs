using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPet
    {
        //fields

        
        protected String name;
        protected String description;
        protected int hunger;
        protected bool clean;
        protected int thirst;


        //properties

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        public String Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public bool Clean
        {
            get { return this.clean; }
            set { this.clean = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        //constructors


        public VirtualPet()
        {

        }

        public VirtualPet(string name, string description)
        {
            this.name = name;
            this.description = description;

        }

        public VirtualPet(string name, string description, int hunger,int thirst,bool clean)
        {
            this.name = name;
            this.description = description;
            this.hunger = hunger;
            this.thirst = thirst;
            this.clean = clean;


        }


        //methods

       
        
        public virtual void Feed(string diet)
        {

            if (hunger == 0)
            {
                Console.WriteLine("I am full now");
                
            }
            else
                Console.WriteLine(diet);
                hunger -= hunger;


        }
        public virtual void Thirsty()
        {
           
            if (thirst == 0)
            {
                Console.WriteLine("Not Thirsty");
            }
            else
            {
               // Console.WriteLine("Done \n");
                thirst -= thirst;
            }

        }

        public virtual void Isclean()
        {
            if (clean == false)
            {
                clean = true;
                Console.WriteLine("The cage is cleaned now");
            }
            else
            {
                Console.WriteLine("The cage is already clean");
            }
        }
    }


}