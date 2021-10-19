using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Zadanie13
    {
        static void Main(string[] args)
        {
            Building building1 = new Building();
            Console.WriteLine(building1);

        }

    }
    public class Building
    {
        public string BuildingAddress { get; set; }
        public int BuildingLength { get; set; }
        public int BuildingWidth { get; set; }
        public int BuildingHeigth { get; set; }

        public Building(int H, int W, int L, string A, string Result)
        {            
            Console.WriteLine("Введите Адрес");
            A = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("Введите Длину");
            L = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Ширину");
            W = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите Высоту");
            H = Convert.ToInt32(Console.ReadLine());

            BuildingAddress = A;
            BuildingLength = L;
            BuildingWidth = W;
            BuildingHeigth = H;

            Result = A + L + W + H;
            return;
        }

        public Building()
        {


        string Print(int buildingHeigth, int buildingWidth, int buildingLength, string buildingAddress)
            {
                buildingHeigth = BuildingHeigth;
                Console.WriteLine("Высота = {0}", buildingHeigth);
                buildingWidth = BuildingWidth;
                Console.WriteLine("Ширина = {0}", buildingWidth);
                buildingLength = BuildingLength;
                Console.WriteLine("Ширина = {0}", buildingLength);
                buildingAddress = BuildingAddress;
                Console.WriteLine("Ширина = {0}", buildingAddress);
                return buildingAddress;
            }
        }

    }
    sealed class MultiBuilding : Building
    {
        public new void Print(int buildingHeigth, int buildingWidth, int buildingLength, string buildingAddress)
        {
            base.Print (BuildingHeigth, BuildingWidth, BuildingLength, BuildingAddress);
            buildingHeigth = BuildingHeigth;
            Console.WriteLine("Высота = {0}", buildingHeigth);
            buildingWidth = BuildingWidth;
            Console.WriteLine("Ширина = {0}", buildingWidth);
            buildingLength = BuildingLength;
            Console.WriteLine("Ширина = {0}", buildingLength);
            buildingAddress = BuildingAddress;
            Console.WriteLine("Ширина = {0}", buildingAddress);

        }
    }

    
    }
    


