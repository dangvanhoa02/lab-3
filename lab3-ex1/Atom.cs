using System;
using System.Dynamic;

namespace lab3_ex1
{
    public class Atom
    {
        public int Number { get; set; }
        public String Symbol { get; set; }
        public String FullName { get; set; }
        public float Weight { get; set; }

        public bool Accept()
        {
            try
            {
                Console.Write("Enter atomic number : ");
                Number = Convert.ToInt32((Console.ReadLine()));
                if (Number == 0)
                {
                    return false;
                }
                Console.Write("Enter symbol : ");
                Symbol =Console.ReadLine();
                Console.Write("Enter full name : ");
                FullName =Console.ReadLine();
                Console.Write("Enter atomic weight : ");
                Weight =float.Parse(Console.ReadLine());
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }

        public void Display()
        {
            Console.WriteLine($"{Number} {Symbol} {FullName} {Weight}");
        }
    }
}