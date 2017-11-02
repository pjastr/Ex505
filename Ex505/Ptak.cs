using System;

namespace Ex505
{
    class Ptak : IComparable
    {
        private string nazwa;

        public Ptak(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public int CompareTo(object obj)
        {
            if (obj is Ptak)
            {
                return (obj as Ptak).nazwa.CompareTo(this.nazwa);
            }
            else if (obj is Ssak)
            {
                return 1;
            }
            else
            {
                throw new ArgumentException("Objekt nie jest ptakiem ani ssakiem.");
            }
        }

        public override string ToString()
        {
            return this.nazwa;
        }
    }

}
