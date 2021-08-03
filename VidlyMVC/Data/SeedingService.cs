using System.Linq;
using VidlyMVC.Models;
using System;

namespace VidlyMVC.Data
{
    public class SeedingService
    {
        private VidlyMVCContext _context;

        public SeedingService(VidlyMVCContext context)
        {
            _context = context;
        }

        public void SeedData() 
        {
            if ( _context.MembershipType.Any() || _context.Customer.Any() || _context.Movie.Any())
            {
                return;
            }

            MembershipType membershipType1 = new MembershipType() {Id = 1, SignUpFree =  0, DurationInMonths = 0, DiscountRate = 0 , Name = "Pay as You Go" };
            MembershipType membershipType2 = new MembershipType() {Id = 2, SignUpFree = 30, DurationInMonths = 1, DiscountRate = 10, Name = "Monthly" };
            MembershipType membershipType3 = new MembershipType() {Id = 3, SignUpFree = 90, DurationInMonths = 3, DiscountRate = 15, Name = "Quartetly" };

            Customer customer1 = new Customer() {Name = "John Smith"    , IsSubscribedToNewsletter = false, MembershipType = membershipType1 , Birthdate = new DateTime(1987, 7, 23)};
            Customer customer2 = new Customer() {Name = "Marry Willians", IsSubscribedToNewsletter = true , MembershipType = membershipType2 };

            Movie movie1 = new Movie() {Name = "Skrek 2"};
            Movie movie2 = new Movie() { Name = "Wall-E"};

            _context.MembershipType.AddRange(membershipType1, membershipType2, membershipType3);
            _context.Customer.AddRange(customer1, customer2);
            _context.Movie.AddRange(movie1, movie2);
            _context.SaveChanges();
        }
    }
}
