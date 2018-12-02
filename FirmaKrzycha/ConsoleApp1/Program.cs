using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Employee()
            {
                name = "Kasia",
                surName = "Kozioł",
                wynagrodzenie = new Wynagrodzenie()
                {
                    zasadnicze = 5000,
                    staz = 200,
                    premia = 1000   
                }

            };
            Console.WriteLine(p1.GetUmowaTyp());
            p1.wynagrodzenie.premia = 200;
            p1.operationsList.Add(new Operation("Wypłata", 2000, new DateTime(2018,12,01)));
            Console.WriteLine(p1.operationsList.Take(0));

        }
    }
}
