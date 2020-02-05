using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eprov2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<CleanCar> cleancar = new List<CleanCar>();
            List<ContrabandCar> contracar = new List<ContrabandCar>();

            int crA = -1;
            bool success = false;
            while (success == false)
            {
                Console.WriteLine("Hur många bilar vill du släppa in?");
                string carAmount = Console.ReadLine();                      //använder detta för att kunna veta hur många bilad personen vill ha.

                success = int.TryParse(carAmount, out crA);     //denna säger vad som är sant

                if (success && crA < 1)                         //denna ser till att checka ifall det är sant. ifall den inte är det så fortsätter den att fråga tills vi får rätt svar. 
                {
                    success = false;
                }
            }
            for (int c = 0; c < crA; c++)                        //denna skapar antal bilar som spelaren bad om att få skapa och lägger in den i en lista
            {                                                   // dock så skulle jag vilja göra detta random. 
                CleanCar clean = new CleanCar();
                ContrabandCar dirty = new ContrabandCar();
                cleancar.Add(clean);
                contracar.Add(dirty);
            }
            
            Console.WriteLine("Du har då " + (cleancar.Count() + contracar.Count()) + " bilar att kolla igenom!" );
            Console.ReadLine();
        }
    }
}
