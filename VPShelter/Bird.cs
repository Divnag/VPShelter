using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Bird : VirtualPet
    {
        
        //fields
        private string type;
        private string diet;


        //properties



        public String Type
        {
            get { return this.type; }
            set { this.type = value; }
        }


        public string Diet
        {
            get { return this.diet; }
            set { this.diet = value; }
        }


        //constructors
        public Bird()
        {

        }

        
        public Bird(string type, string diet,string name,string description,int hunger,int thirst,bool clean):base(name,description,hunger,thirst,clean)
        {
            this.type = type;
            this.diet = diet;
        }


        //methods

       
        public override void Feed(string diet)
        {
            Console.WriteLine("Diet for Bird "+Name);
            base.Feed(diet);
         
           
        }
        public override void Thirsty()
        {
            base.Thirsty();

        }
        public override void Isclean()
        {
            base.Isclean();
        }












    }
}
