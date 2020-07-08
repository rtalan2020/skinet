using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Identity
{
    public class Address
    {
        public int  Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string FirstAppUserIdname { get; set; }
        public string AppUser { get; set; }
    }
}