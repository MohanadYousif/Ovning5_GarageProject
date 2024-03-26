using System.Collections;

namespace GarageApplication
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[] vehicles;
        private int capacity;

        public Garage(int capacity)
        {
            this.capacity = capacity;
            vehicles = new T[capacity];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)vehicles).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return vehicles.GetEnumerator();
        }

        public T[] Vehicles
        {
            get { return vehicles; }
            set { vehicles = value; }
        }
    }
}
