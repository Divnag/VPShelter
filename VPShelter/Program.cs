using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Bird rosy = new Bird("Dove","Carrot","Rosy","Bird",5,5,false);
            Bird peter = new Bird("Parakeet","Honey","Peter","Bird",5,5,false);            
            VirtualPetShelter myVirtualPetShelter = new VirtualPetShelter();
            List<Bird> AllBird = new List<Bird>();
            AllBird.Add(rosy);
            AllBird.Add(peter);

            
                       
            Bunny max = new Bunny("Holland Lop","Hay","Max","Bunny",5,5,false);
            Bunny cuddly = new Bunny("Mini Lop","Grass","Cuddly","Bunny",5,5,false);
            List<Bunny> AllBunny = new List<Bunny>();
            AllBunny.Add(max);
            AllBunny.Add(cuddly);
           

            Volunteer volunteer1 = new Volunteer("MARY",1234);
            Volunteer volunteer2 = new Volunteer("DAVID",2345);
            Volunteer volunteer3 = new Volunteer();
           
            List<Volunteer> AllVolunteer = new List<Volunteer>();
            AllVolunteer.Add(volunteer1);
            AllVolunteer.Add(volunteer2);
            AllVolunteer.Add(volunteer3);
            

            Manager manager1 = new Manager("Jeff",456);
            Manager manager2 = new Manager("Mark",345);
            List<Manager> AllManager = new List<Manager>();
            AllManager.Add(manager1);
            AllManager.Add(manager2);


            VirtualPetShelter myVpShelter = new VirtualPetShelter();
            myVpShelter.AllBird = AllBird;
            myVpShelter.AllBunny = AllBunny;
            myVpShelter.AllVolunteer = AllVolunteer;
            myVpShelter.AllManager = AllManager;
            int input;
            do { 
            Console.WriteLine("Welcome to Al's Virtual Pet Shelter.What employee type are you?");
            Console.WriteLine("Volunteer: Select 1");
            Console.WriteLine("Manager:Select 2");
             Console.WriteLine("Quit:select 3");
            input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.Clear();
                    int input1;
                    Console.WriteLine("Thank you for Volunteering ");


                    Console.WriteLine("Enter your Name from the list below.\nIf your first time volunteering here enter your name.We need only one volunteer today. ");
                    Console.WriteLine("");
                    foreach (string name in myVpShelter.DisplayVolunteerNames())
                    {
                        Console.WriteLine(name);
                    }
                    string name1 = Console.ReadLine().ToUpper();
                    if (name1 == volunteer1.Name)
                    {
                        Console.WriteLine("Punch in your CheckIn Time");
                        double time = int.Parse(Console.ReadLine());
                        Console.Clear();
                        volunteer1.ClockIN(time);
                        volunteer1.ShowID(volunteer1.Name, volunteer1.EmployeeID);
                    }
                    else if (name1 == volunteer2.Name)
                    {
                        Console.WriteLine("Punch in your CheckIn Time");
                        double time = int.Parse(Console.ReadLine());
                        Console.Clear();
                        volunteer2.ClockIN(time);
                        volunteer2.ShowID(volunteer2.Name, volunteer2.EmployeeID);
                    }
                    else
                    { 
                        
                        volunteer3.Name = name1;
                        Console.WriteLine("Punch in your CheckIn Time");
                        double time = int.Parse(Console.ReadLine());
                        Console.Clear();
                        volunteer3.ClockIN(time);
                        volunteer3.ShowID(volunteer3.Name, volunteer3.EmployeeID);
                    }
                
                     do
                     {

                    Console.WriteLine("");
                      
                    Console.WriteLine("This is the Status of the Pets");
                        //display the status
                        Console.Write("Name   |" + "  Diet   |" + "  Hunger |" + "Thirst  |" + "  Cage Clean |"+" Description | "+"Type  \n");
                        Console.Write("------ |---------|---------|--------|--------------|----------------\n");

                        foreach (Bird bird in AllBird)
                        {


                            Console.WriteLine(bird.Name + "   |  " + bird.Diet + " |  " + bird.Hunger + "     |   " + bird.Thirst + "    |  " + bird.Clean+ "       |  " + bird.Description + "   |  " + bird.Type);
                            Console.Write("------ |---------|--------|--------|---------------|----------------\n");
                        }

                        foreach (Bunny bunny in AllBunny)
                        {

                            Console.WriteLine(bunny.Name + "    |  " + bunny.Diet + "    |  " + bunny.Hunger + "     | " + bunny.Thirst + "      | " + bunny.Clean+"     |  " + bunny.Description + "     |  " + bunny.Type);
                            Console.Write("------ |---------|--------|--------|----------|------------|-----------\n");

                        }

                        Console.WriteLine("");
                    
                    Console.WriteLine("Feed the Pets:select 1");
                    Console.WriteLine("Water the Pets:selct 2");
                    Console.WriteLine("To Clean Cage: select 3");
                    Console.WriteLine("Quit:select 4");
                    input1 = int.Parse(Console.ReadLine());
                   
                    switch (input1)
                    {
                        case 1:
                            Console.WriteLine("Pet you would like to feed");
                            string petchoice = Console.ReadLine().ToLower();
                            //call feed method
                            if (petchoice=="rosy")
                            {
                                Console.Clear();
                                    rosy.Feed(rosy.Diet);
                                    volunteer1.Feed("rosy");
                                     Console.WriteLine("");
                                   
                                
                            }
                           else  if(petchoice=="peter")
                            {
                                Console.Clear();
                                peter.Feed(peter.Diet);
                                volunteer1.Feed("peter");
                                Console.WriteLine("");
                                   
                            }
                           else  if(petchoice=="max")
                            {
                                Console.Clear();
                                max.Feed(max.Diet);
                                volunteer1.Feed("max");
                                 Console.WriteLine("");
                            }
                           else if(petchoice=="cuddly")
                            {
                                Console.Clear();
                                cuddly.Feed(cuddly.Diet);
                                 volunteer1.Feed("cuddly");
                                 Console.WriteLine("");
                            }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the Pet name Correctly");
                                }

                             
                            
                            break;
                        case 2:
                            //call water method
                            Console.WriteLine("Pet Name to water ");
                            string petchoice1 = Console.ReadLine().ToLower();
                            //call feed method
                            if (petchoice1 == "rosy")
                            {
                                Console.Clear();
                                rosy.Thirsty();
                                volunteer1.Water("rosy");
                                    Console.WriteLine("");

                            }
                           else if (petchoice1 == "peter")
                            {
                                Console.Clear();
                                peter.Thirsty();
                                volunteer1.Water("peter");
                                Console.WriteLine("");
                            }
                          else  if (petchoice1 == "max")
                            {
                                Console.Clear();
                                max.Thirsty();
                                volunteer1.Water("max");
                                Console.WriteLine("");
                            }
                           else if (petchoice1 == "cuddly")
                            {
                                Console.Clear();
                                cuddly.Thirsty();
                                volunteer1.Water("cuddly");
                                Console.WriteLine("");
                            }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the Pet name Correctly");
                                }

                                break;
                            case 3:
                                Console.WriteLine("Pet you would like to Clean");
                                string petchoice3 = Console.ReadLine().ToLower();
                                //call clean method
                                if (petchoice3 == "rosy")
                                {
                                    Console.Clear();
                                    rosy.Isclean();
                                    Console.WriteLine("");


                                }
                               else if (petchoice3 == "peter")
                                {
                                    Console.Clear();
                                    peter.Isclean();
                                    Console.WriteLine("");
                                }
                               else if (petchoice3 == "max")
                                {
                                    Console.Clear();
                                    max.Isclean();
                                    Console.WriteLine("");
                                }
                                else if (petchoice3 == "cuddly")
                                {
                                    Console.Clear();
                                    cuddly.Isclean();
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the Pet name Correctly");
                                }



                                break;


                            default:
                            break;
                    }
                    
                } while (input1 != 4);
                    Console.Clear();

            }




                if (input == 2)
                {
                    Console.Clear();
                    manager1.ShowID(manager1 .Name,manager1 .EmployeeID);
                    Console.WriteLine("Details of the Volunteers Today");
                    foreach (Volunteer volunteer in AllVolunteer)
                    {
                        Console.WriteLine(volunteer.Name + " " + volunteer.EmployeeID);
                        manager1.ClockIN(volunteer.Time);
                        // Console.WriteLine("Checked in time:"+volunteer.Time);
                    }
                    Console.WriteLine("Press Enter to Proceed");
                    string read = Console.ReadLine();
                    int input2;
                    do
                    {
                        Console.WriteLine("");
                        Console.WriteLine("This is the Status of the Pets");
                        //display the status
                        Console.Write("Name   |" + "  Diet   |" + "  Hunger |" + "Thirst  |" + "  Cage Clean |" + " Description | " + "Type  \n");
                        Console.Write("------ |---------|---------|--------|--------------|----------------\n");

                        foreach (Bird bird in AllBird)
                        {


                            Console.WriteLine(bird.Name + "   |  " + bird.Diet + " |  " + bird.Hunger + "     |   " + bird.Thirst + "    |  " + bird.Clean + "       |  " + bird.Description + "   |  " + bird.Type);
                            Console.Write("------ |---------|--------|--------|---------------|----------------\n");
                        }

                        foreach (Bunny bunny in AllBunny)
                        {

                            Console.WriteLine(bunny.Name + "    |  " + bunny.Diet + "    |  " + bunny.Hunger + "     | " + bunny.Thirst + "      | " + bunny.Clean + "     |  " + bunny.Description + "     |  " + bunny.Type);
                            Console.Write("------ |---------|--------|--------|----------|------------|-----------\n");

                        }

                        Console.WriteLine("");
                        Console.WriteLine("Adopt Pet:select 1");
                        Console.WriteLine("Feed the Pets:select 2");
                        Console.WriteLine("Water the Pets:selct 3");
                        Console.WriteLine("Quit:select 4");
                        input2 = int.Parse(Console.ReadLine());
                        //Console.Clear();

                        switch (input2)
                        {
                            case 1:
                                //call adopt method
                                Console.Clear();
                                foreach (Bird bird in AllBird)
                                Console.WriteLine(bird.Name+"-----"+bird.Description );
                                foreach(Bunny bunny in AllBunny)
                                Console.WriteLine(bunny.Name+"-----"+bunny.Description);
                                Console.WriteLine("Pet you would like to Adopt.\n If you changed your mind to go back: select 4");
                                string petchoice = Console.ReadLine().ToLower();
                                Console.WriteLine("");
                                //call feed method
                              
                                if (petchoice == "rosy")
                                {
                                    Console.Clear();
                                    rosy.ASC();
                                    manager1.Adopt("rosy");
                                    AllBird.Remove(rosy);
                                    Console.WriteLine("");
                                    

                                }
                                else if (petchoice == "peter")
                                {
                                    Console.Clear();
                                    peter.ASC();

                                    manager1.Adopt("peter");
                                    AllBird.Remove(peter);
                                    Console.WriteLine("");
                                }
                                    
                                 else if (petchoice == "max")
                                {
                                    Console.Clear();
                                    max.Asc();
                                    manager1.Adopt("max");
                                    AllBunny.Remove(max);
                                    Console.WriteLine("");
                                    
                                }
                                else if (petchoice == "cuddly")
                                {
                                    Console.Clear();
                                    cuddly.Asc();
                                    manager1.Adopt("cuddly");
                                    AllBunny.Remove(cuddly);
                                    Console.WriteLine("");
                                   
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter Pet Name Correctly");
                                }
                                break;
                            
                            case 2:
                                //call feed method
                                Console.WriteLine("Pet you would like to feed");
                                string petchoice3 = Console.ReadLine().ToLower();

                                if (petchoice3 == "rosy")
                                {
                                   Console.Clear();
                                    manager1.Feed("rosy", rosy.Diet);
                                    Console.WriteLine("");

                                }
                                else if (petchoice3 == "peter")
                                {
                                    Console.Clear();
                                    manager1.Feed("peter", peter.Diet);
                                    Console.WriteLine("");
                                }
                                else if (petchoice3 == "max")
                                {
                                    Console.Clear();
                                    manager1.Feed("max", max.Diet);
                                    Console.WriteLine("");
                                }
                               else  if (petchoice3 == "cuddly")
                                {
                                    Console.Clear();
                                    manager1.Feed("cuddly", cuddly.Diet);
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter Pet Name Correctly");
                                }
                                break;
                            case 3:
                                //call water method
                                Console.WriteLine("Pet Name to water ");
                                string petchoice1 = Console.ReadLine().ToLower();

                                if (petchoice1 == "rosy")
                                {
                                    Console.Clear();
                                    manager1.Water("rosy");
                                    Console.WriteLine("");

                                }
                               else  if (petchoice1 == "peter")
                                {
                                    Console.Clear();
                                    manager1.Water("peter");
                                    Console.WriteLine("");
                                }
                                else if (petchoice1 == "max")
                                {
                                    Console.Clear();
                                    manager1.Water("max");
                                    Console.WriteLine("");
                                }
                                else if (petchoice1 == "cuddly")
                                {
                                    Console.Clear();
                                    manager1.Water("cuddly");
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the Pet name Correctly");
                                }
                               
                                break;

                            default:
                                break;
                        }

                    } while (input2 != 4);
                    Console.Clear();
                }
            } while (input != 3);
        }

       
    }
}

