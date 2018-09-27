using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdClass
{
    class Bird
    {
        // This application is to capture information about New Zealand Birds of Prey that have rescued and banded.
        // This application created by Viliami Fihaki.

        //5 auto implemented properties, this done by typing prop and press tab 2x.
        public string Name { get; set; }
        public string Species { get; set; }
        public string Sex { get; set; }
        public string Weight { get; set; }
        public string BandNo { get; set; }

        //Constractor, has the same name but with _unkown added at the end.
        public Bird(string Name_unknown,string Species_unknown, string Sex_unknown, string Weight_unknown, string BandNo_unknown)
        {
            Name = Name_unknown;
            Species = Species_unknown;
            Sex = Sex_unknown;
            Weight = Weight_unknown;
            BandNo = BandNo_unknown;
            
        }
        //Method to Display all the Bird informatio.
        public string DisplayBird()
        {
            return $"Bird name: {Name}\nSpecies: {Species}\nSex: {Sex}\nWeight: {Weight}\nBandNumber: {BandNo}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Bird object created and default data loaded...\n\n");
            Console.WriteLine("PLEASE UPDATE BIRD DATA\n");
            //Obtain the information about the bird and save them to variable.
            Console.Write("Enter Bird name: ");
            string Bname = Console.ReadLine();
            Console.Write("Enter Species: ");
            string Bspecies = Console.ReadLine();
            Console.Write("Enter sex of the Bird: ");
            string Bsex = Console.ReadLine();
            Console.Write("Enter weight of Bird: ");
            string Bweight = Console.ReadLine();
            Console.Write("Enter Band number of Bird: ");
            string BbandNo = Console.ReadLine();

            //Create a bird object using the constructor and populating it with the variables where we saved the bird information.
            Bird b1 = new Bird(Bname, Bspecies, Bsex, Bweight, BbandNo);

            //Display the information back to the user using the bird object and the display method.
            Console.WriteLine("\n*********************************");
            Console.WriteLine("BIRD OF PREY DATA OUTPUT");
            Console.WriteLine(b1.DisplayBird());
            Console.WriteLine("*********************************");
            Console.ReadLine();
        }
    }
}
