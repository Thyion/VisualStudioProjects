using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    

    public class Employee
    {
        

        public static int dodatekWakacyjny = 1000;
        public int id;
        public String name;
        public String surName;
        UmowaTyp umowatyp = UmowaTyp.zlecenie;
        public DateTime dataZatrudnienia;
        public Operation[] operations;
        public List<Operation> operationsList = new List<Operation>();
        public Wynagrodzenie wynagrodzenie;


        public UmowaTyp GetUmowaTyp()
        {
            return this.umowatyp;
        }

        public void setUmowaTyp(UmowaTyp umowatyp)
        {
            
        }

        public void setSurName(String surName)
        {
            if(surName.Length>=2)
             this.surName = surName;
            else
                throw new InvalidStringSizeException("You must be joking");

        }

     // akcesory to w C# jak gettery i settery


    }
}
