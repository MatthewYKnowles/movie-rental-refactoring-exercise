using NUnit.Framework;
using System.Collections.Generic;

namespace MovieRentalRefactoringExercise
{
    class RentalInfoTests
    {
        [Test]
        public void TestOne()
        {
            var properResults = "Rental Record for Martin\n" +
                                "\tRan\t3.5\n" +
                                "\tTrois Couleurs: Bleu\t2\n" +
                                "Amount owed is 5.5\n" +
                                "You earned 2 frequent renter points\n";
            var rentals = new List<MovieRental> { new MovieRental("F001", 3), new MovieRental("F002", 1) };
            var customer = new Customer("Martin", rentals);
            var info = new RentalInfo();
            var actualResult = info.Statement(customer);
            Assert.That(properResults, Is.EqualTo(actualResult));
        }
    }
}
