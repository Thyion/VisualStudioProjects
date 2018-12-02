using System;



namespace ClassLibrary1
{
    public class Operation
    {
        public Operation(String tytul, int kwota, DateTime data)
        {
            this.tytul = tytul;
            this.kwota = kwota;
            this.data = data;
        }

        public string tytul;
        public DateTime data;
        public int kwota;
        public bool rozliczenie;

    }

}