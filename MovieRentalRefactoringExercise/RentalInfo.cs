using System;
using System.Collections.Generic;

namespace MovieRentalRefactoringExercise
{
    public class RentalInfo
    {
        public string Statement(Customer customer)
        {
            var movies = new Dictionary<string, Movie>
            {
                {"F001", new Movie {Title = "Ran", Code = "regular"}},
                {"F002", new Movie {Title = "Trois Couleurs: Bleu", Code = "regular"}},
                {"F003", new Movie {Title = "Onward", Code = "childrens"}},
                {"F004", new Movie {Title = "Star Wars: The Rise of Skywalker", Code = "new"}}
            };
            double totalAmount = 0;
            var frequentRenterPoints = 0;
            var result = "Rental Record for " + customer.Name + "\n";
            foreach (var r in customer.Rentals)
            {
                var movie = movies[r.MovieId];
                double thisAmount = 0;
                
                // determine amount for each movie
                switch (movie.Code)
                {
                    case "regular":
                        thisAmount = 2;
                        if (r.Days > 2)
                        {
                            thisAmount = (r.Days - 2) * 1.5 + thisAmount;
                        }
                        break;
                    case "new":
                        thisAmount = r.Days * 3;
                        break;
                    case "childrens":
                        thisAmount = 1.5;
                        if (r.Days > 3)
                        {
                            thisAmount = (r.Days - 3) * 1.5 + thisAmount;
                        }
                        break;
                }

                //add frequent renter points
                frequentRenterPoints++;
                // add bonus for a two day new release rental
                if (movie.Code == "new" && r.Days > 2) frequentRenterPoints++;

                //print figures for this rental
                result += "\t" + movie.Title + "\t" + thisAmount + "\n";
                totalAmount = totalAmount + thisAmount;
            }
            // add footer lines
            result += "Amount owed is " + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points\n";
            return result;
        }
    }

    internal class Movie
    {
        public string Title { get; set; }
        public string Code { get; set; }
    }
}
