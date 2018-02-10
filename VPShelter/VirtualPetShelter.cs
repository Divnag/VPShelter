using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
   public class VirtualPetShelter
    {

        //properties
        public List<Bird> AllBird { get; set; }
        public List<Bunny> AllBunny { get; set; }
        public List<Volunteer> AllVolunteer { get; set; }
        public List<Manager> AllManager { get; set; }

        
        public List<String> DisplayBirdNames()
        {
            List<String> birdNames = new List<string>();
            foreach (Bird bird in AllBird)
            {
                birdNames.Add(bird.Name);



            }
            return birdNames;
        }

       
        public List<String> DisplayBunnyNames()
        {
            List<String> bunnyNames = new List<string>();
            foreach (Bunny bunny in AllBunny)
            {
                bunnyNames.Add(bunny.Name);



            }
            return bunnyNames;
        }

        public List<string> DisplayVolunteerNames()
        {
            List<String> volunteerNames = new List<string>();
            foreach(Volunteer volunteer in AllVolunteer)
            {
                volunteerNames.Add(volunteer.Name);
               
            }
            return volunteerNames;
        }

        public List<string> DisplayManagerNames()
        {
            List<String> managerNames = new List<string>();
            foreach (Manager manager in AllManager)
            {
                managerNames.Add(manager.Name);
            }
            return managerNames;
        }

    }
}
