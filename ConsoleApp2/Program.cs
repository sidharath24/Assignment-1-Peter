using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            CountrySide c = new CountrySide();
        }
    }
    class UsingRecursion
    {
        // Create an application which 
        // calculates the sum of all the numbers from n to m recursively:

        public static int CalculateRecursively(int n, int m)
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += CalculateRecursively(n, m);
            }
            return sum;
        }


    }

    class CountrySide
    {
        // Create the LinkedList to reflect the Map in the PowerPoint Instructions
        Village Maeland;
        Village Helmholtz;
        Village Alst;
        Village Wessig;
        Village Badden;
        Village Uster;
        Village Schvenig;

        public void Run()
        {
            this.CreateMap();
        }

        public void CreateMap()
        {
            Maeland = new Village("Maeland", false);
            Alst = new Village("Alst", false);
            Schvenig = new Village("Schvenig", true);

            Alst.east = Schvenig;
            Alst.distanceToNextVillage = 14;

            Alst.west = Wessig;
            Alst.distanceToNextVillage = 19;
        }

        public Village traverse(Village startingPoint)
        {
            if(startingPoint.isAstrildgeHere)
            {
                Console.WriteLine("Huyaa!!! Hugi found astrilde! He found her in village {0}",curentVillage.VillageName);
            }

        }


        class Village
        {
            public Village(string _villageName, bool _isAHere)
            {
                isAstrildgeHere = _isAHere;
                VillageName = _villageName;
            }

            public Village west;
            public Village east;
            public string VillageName;
            public int distanceToNextVillage;
            public int distanceToPreviousVillage;
            public bool isAstrildgeHere;

           
        }
    }
}
