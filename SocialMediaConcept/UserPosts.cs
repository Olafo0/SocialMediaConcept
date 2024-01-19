using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaConcept
{
    public class UserPosts
    {
        public int?  PostID { get; set; }
        public int UserID { get; set; }
        public byte[] PostPicture { get; set; }
        public string PostTitle { get; set; }   
        public string Descripition { get; set; }
        public int Likes { get; set; }
        public DateTime DatePosted { get; set; }

        public UserPosts(int? PostID, int UserID, byte[] PostPicture, string PostTitle, string Descripition, int Likes, DateTime DatePosted)
        {
            this.PostID = PostID;
            this.UserID = UserID;   
            this.PostPicture = PostPicture;
            this.PostTitle = PostTitle;
            this.Descripition = Descripition;
            this.Likes = Likes;
            this.DatePosted = DatePosted;
        }
    }
}
