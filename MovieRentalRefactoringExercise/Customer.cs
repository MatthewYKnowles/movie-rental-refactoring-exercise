using System.Collections.Generic;

namespace MovieRentalRefactoringExercise
{
    public class Customer
    {
        public string Name;
        public IEnumerable<MovieRental> Rentals;

        public Customer(string name, IEnumerable<MovieRental> rentals)
        {
            Name = name;
            Rentals = rentals;
        }
    }
}