namespace MovieRentalRefactoringExercise
{
    public class MovieRental
    {
        public string MovieId;
        public int Days;

        public MovieRental(string movieId, int days)
        {
            MovieId = movieId;
            Days = days;
        }
    }
}