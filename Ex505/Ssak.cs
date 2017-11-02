using System;

namespace Ex505
{
    class Ssak : IComparable
    {
        private string nazwa;

        public Ssak(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public int CompareTo(object obj)
        {
            if (obj is Ssak)
            {
                return this.nazwa.CompareTo((obj as Ssak).nazwa);
            }
            else if (obj is Ptak)
            {
                return -1;
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
