using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace override_C_
{
    internal class Task3
    {
        private string _name;
        private int _population;

        public Task3(string name, int population)
        {
            _name = name;
            _population = population;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Population
        {
            get { return _population; }
            set { _population = value; }
        }

        public static Task3 operator +(Task3 city, int populationIncrease)
        {
            return new Task3(city.Name, city.Population + populationIncrease);
        }

        public static Task3 operator -(Task3 city, int populationDecrease)
        {
            return new Task3(city.Name, city.Population - populationDecrease);
        }

        public static bool operator ==(Task3 city1, Task3 city2)
        {
            if (object.ReferenceEquals(city1, city2))
                return true;

            if (object.ReferenceEquals(city1, null) ||
                object.ReferenceEquals(city2, null))
                return false;

            return city1.Population == city2.Population;
        }

        public static bool operator !=(Task3 city1, Task3 city2)
        {
            return !(city1 == city2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Task3 other = (Task3)obj;
            return this.Population == other.Population;
        }

        public override int GetHashCode()
        {
            return this.Population.GetHashCode();
        }

        public static bool operator <(Task3 city1, Task3 city2)
        {
            return city1.Population < city2.Population;
        }

        public static bool operator >(Task3 city1, Task3 city2)
        {
            return city1.Population > city2.Population;
        }
    }
}
