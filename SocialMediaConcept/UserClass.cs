using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaConcept
{
    public class UserClass
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password_ { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public byte[]? ProfilePicture { get; set; }

        public UserClass(int userID, string username, string password_, string email, string displayName, byte[] profilePicture)
        {
            UserID = userID;
            Username = username;
            Password_ = password_;
            Email = email;
            DisplayName = displayName;
            ProfilePicture = profilePicture;
        }
    }
}
