using System.Collections.Generic;

namespace VidlyMVC.Models.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipType { get; set; }
        public Customer Customer { get; set; }
    }
}
