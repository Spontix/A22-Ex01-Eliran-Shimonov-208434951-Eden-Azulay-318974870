using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using SortLikesPostThatLikedByUser;

namespace FacebookAPIHandler
{
    public class FacebookAPI
    {
        public UserLikesCounterList UserLikesCounterList { get; set; }
        public LoginResult LoginResult { get; set; }
        public User LoggedInUser { get; set; }

        public void facebookLogin()
        {

            LoginResult = FacebookService.Login(
                "554914478908153",
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos"
            );

        }

    }
}
