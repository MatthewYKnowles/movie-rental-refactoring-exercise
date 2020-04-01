# movie-rental-refactoring-exercise
Movie Rental Refactoring Exercise in C#


### New Functionality Requested
1. Add a new movie to the rental store
    * Movie Title: Alien
    * Movie Type: thriller
    * Thriller Type Pricing: {days rented}^2

2. Add method to get receipt as HTML
    * Example of a customer renting two movies:
```
<h1>Rental Record for {customer name}</h1>
<table>
    <tr>
        <td>{rental 1 name}</td>
        <td>{rental 1 price}</td>
    </tr>
    <tr>
        <td>{rental 2 name}</td>
        <td>{rental 2 price}</td>
    </tr>
</table>
<h2>Amount owed is {total price}</h2>
<h2>You earned {frequent renter points} frequent renter points</h2>
```