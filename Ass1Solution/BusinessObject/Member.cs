using System;

namespace BusinessObject
{
    public class Member
    {
        public Member() { }

        public int MemberID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
