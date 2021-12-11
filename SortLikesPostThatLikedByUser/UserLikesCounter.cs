using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace SortLikesPostThatLikedByUser
{
    public class UserLikesCounter
    {
        private  User m_LikedByUser;
        private int m_Likes = 0;

        public UserLikesCounter(User i_FriendOfMainUser)
        {
            LikedByUser = i_FriendOfMainUser;
        }

        public int Likes
        {
            get
            {
                return m_Likes;
            }
            set
            {
                m_Likes = value;
            }
        }

        public User LikedByUser
        {
            get
            {
                return m_LikedByUser;
            }
            set
            {
                LikedByUser = value;
            }
        }



    }
}
