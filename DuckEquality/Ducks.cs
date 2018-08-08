using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckEquality
{
    public class Ducks
    {
        public string Name { get; }
        public string Type { get; }
        public int WeightInGrams { get; }
        public int AgeInMonths { get; }

        public Ducks ( string name, string type, int weightInGrams, int ageInMonths)
        {
            Name = name;
            Type = type;
            WeightInGrams = weightInGrams;
            AgeInMonths = ageInMonths;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return WeightInGrams == ((Ducks)obj).WeightInGrams;

        }

        public bool Equals(Ducks other)
        {
            return Name == other.Name &&
                   Type == other.Type &&
                   WeightInGrams == other.WeightInGrams &&
                   AgeInMonths == other.AgeInMonths;
        }

        public override int GetHashCode()
        {
            int hash = WeightInGrams.GetHashCode();
            hash = (hash * 31) + AgeInMonths.GetHashCode();
            return hash;
        }

        public override string ToString()
        {
            return $"Name: {Name}: Type: {Type} : Weight in grams: {WeightInGrams}: Age in months: {AgeInMonths}";
        }
    }
}
