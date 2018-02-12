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
        public double Time { get; set; }
        public int Id { get; set; }

        //consturctors

        public Volunteer()
        {
            this.Name = name;
            this.EmployeeID = Id;
        }

        public Volunteer(string name,int id)
        {
            this.name = name;
            this.EmployeeID = id;
        }
        public Volunteer(double time)
        {
            this.Time = time;
            
        }


        //methods

        public override void ClockIN(double time)
        {
            this.Time = time;
            Console.WriteLine("your checkin time:"+time);
        }

        public override void ShowID(string name ,int id)
        {
            if (name == "MARY")
            {
                Console.WriteLine("Volunteer Id:" + id);
            }
            if(name=="DAVID")
            {
                Console.WriteLine("Volunteer Id:" + id);
            }
            else
            {
                Console.WriteLine("First time volunteering");
                Random temp = new Random();
                id= temp.Next(100, 200);

                Console.WriteLine("Volunteer Id:"+id);
                EmployeeID = id;
                
            }
        }

        public void Feed(string petType)
        {
            Console.WriteLine("Done Feeding " + petType);
           
        }

        public void Water(string petType)
        {
            Console.WriteLine("Done giving Water to:" + petType);
        }
    }
}