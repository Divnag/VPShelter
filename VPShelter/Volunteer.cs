using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee

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

        public Volunteer()
        {

        }

        public Volunteer(string name,int id)
        {
            this.name = name;
            this.EmployeeID = id;
        }


        //methods

        public override void ClockIN(double time)
        {
            Console.WriteLine("your checkin time:"+time);
        }

        public override void ShowID(string name ,int id)
        {
            if (name == "mary")
            {
                Console.WriteLine("Volunteer Id:" + id);
            }
            if(name=="david")
            {
                Console.WriteLine("Volunteer Id:" + id);
            }
            else
            {
                Random r = new Random();

                
            }
        }

        public void Feed(string petType)
        {
            Console.WriteLine("Done Feeding " + petType);
           
        }

        public void Water(string petType)
        {
            Console.WriteLine("Done giving Water :" + petType);
        }
    }
}