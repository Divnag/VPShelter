using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
   public class Manager:Employee
    {

        Bird bird = new Bird();
        Bunny bunny = new Bunny();

        //fields
        public string name;

        //properties
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        //consturctors

        public Manager()
        {

        }

        public Manager(string name, int id)
        {
            this.name = name;
            this.EmployeeID = id;
        }


        //methods

        public override void ClockIN(double time)
        {
            
            Console.WriteLine("Volunteer Checked in Time"+time);
        }

        public override void ShowID(string name, int id)
        {
            Console.WriteLine("Manager Name and Id: "+name+":"+id);
        }

        public void Feed(string petType,string petDiet)
        {
            Console.WriteLine("Done feeding :"+petType+""+petDiet);
        }

        public void Water(string petType)
        {
            Console.WriteLine("Done giving water to :"+petType);
        }


        public void Adopt(string pet)
        {
            Console.WriteLine("you Adopted :"+pet);
        }
    }
}
    

