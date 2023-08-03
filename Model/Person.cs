using System.Collections.Generic;

namespace cryspie.Model
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
    }
}
