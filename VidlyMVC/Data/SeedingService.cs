using System.Linq;
using VidlyMVC.Models;
using System;

namespace VidlyMVC.Data
{
    public class SeedingService
    {
        private readonly VidlyMVCContext _context;

        public SeedingService(VidlyMVCContext context)
        {
            _context = context;
        }

        public void SeedData() 
        {
            if ( _context.MembershipType.Any() || _context.Customer.Any() || _context.Movie.Any() || _context.Genre.Any())
            {
                return;
            }

            MembershipType membershipType1 = new() {Id = 1, SignUpFree =  0, DurationInMonths = 0, DiscountRate = 0 , Name = "Pay as You Go" };
            MembershipType membershipType2 = new() {Id = 2, SignUpFree = 30, DurationInMonths = 1, DiscountRate = 10, Name = "Monthly" };
            MembershipType membershipType3 = new() {Id = 3, SignUpFree = 90, DurationInMonths = 3, DiscountRate = 15, Name = "Quartetly" };

            Customer customer1 = new() {Name = "John Smith"    , IsSubscribedToNewsletter = false, MembershipType = membershipType1 , Birthdate = new DateTime(1987, 7, 23)};
            Customer customer2 = new() {Name = "Marry Willians", IsSubscribedToNewsletter = true , MembershipType = membershipType2 };

            Genre genre1 = new(){Name = "Comedy"};
            Genre genre2 = new(){Name = "Action"};
            Genre genre3 = new(){Name = "Family"};
            Genre genre4 = new(){Name = "Romance"};

            Movie movie1 = new() {Name = "Skrek 2"       , Genre = genre3, ReleaseDate = new DateTime(2004, 6, 18) , DateAdded = DateTime.Now, Stock = 5};
            Movie movie2 = new() {Name = "Wall-E"        , Genre = genre3, ReleaseDate = new DateTime(2008, 6, 27) , DateAdded = DateTime.Now, Stock = 6};
            Movie movie3 = new() {Name = "Hangover"      , Genre = genre1, ReleaseDate = new DateTime(2009, 8, 21) , DateAdded = DateTime.Now, Stock = 1};
            Movie movie4 = new() {Name = "Die Hard"      , Genre = genre2, ReleaseDate = new DateTime(1988, 12, 22), DateAdded = DateTime.Now, Stock = 3};
            Movie movie5 = new() {Name = "The Terminator", Genre = genre2, ReleaseDate = new DateTime(1985, 3, 25) , DateAdded = DateTime.Now, Stock = 2};
            Movie movie6 = new() {Name = "Toy Story"     , Genre = genre3, ReleaseDate = new DateTime(1995, 12, 22), DateAdded = DateTime.Now, Stock = 4};
            Movie movie7 = new() {Name = "Titanic"       , Genre = genre4, ReleaseDate = new DateTime(1998, 1, 16) , DateAdded = DateTime.Now, Stock = 10};

            _context.MembershipType.AddRange(membershipType1, membershipType2, membershipType3);
            _context.Customer.AddRange(customer1, customer2);
            _context.Genre.AddRange(genre1, genre2, genre3, genre4);
            _context.Movie.AddRange(movie1, movie2, movie3, movie4, movie5, movie6, movie7);
            _context.SaveChanges();
        }
    }
}
