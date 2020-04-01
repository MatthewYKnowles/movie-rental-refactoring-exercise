using NUnit.Framework;
using System.Collections.Generic;

namespace MovieRentalRefactoringExercise
{
    [TestFixture]
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
        
        [Test]
        public void TestTwo()
        {
            var properResults = "Rental Record for Allan\n" +
                                "\tOnward\t4.5\n" +
                                "\tStar Wars: The Rise of Skywalker\t15\n" +
                                "Amount owed is 19.5\n" +
                                "You earned 3 frequent renter points\n";
            var rentals = new List<MovieRental> { new MovieRental("F003", 5), new MovieRental("F004", 5) };
            var customer = new Customer("Allan", rentals);
            var info = new RentalInfo();
            var actualResult = info.Statement(customer);
            Assert.That(properResults, Is.EqualTo(actualResult));
        }
        
        [Test]
        public void TestThree()
        {
            var properResults = "Rental Record for Allan\n" +
                                "\tOnward\t1.5\n" +
                                "\tStar Wars: The Rise of Skywalker\t3\n" +
                                "Amount owed is 4.5\n" +
                                "You earned 2 frequent renter points\n";
            var rentals = new List<MovieRental> { new MovieRental("F003", 1), new MovieRental("F004", 1) };
            var customer = new Customer("Allan", rentals);
            var info = new RentalInfo();
            var actualResult = info.Statement(customer);
            Assert.That(properResults, Is.EqualTo(actualResult));
        }
    }
}
