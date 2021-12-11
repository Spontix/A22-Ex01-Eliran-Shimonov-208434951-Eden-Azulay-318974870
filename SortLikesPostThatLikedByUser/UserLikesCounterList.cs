using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace SortLikesPostThatLikedByUser
{
    public class UserLikesCounterList
    {
        private readonly List<UserLikesCounter> m_CountersList = new List<UserLikesCounter>();

        public List<UserLikesCounter> CountersList
        {
            get
            {
                return m_CountersList;
            }
        }

        public void addALikeCountsToUser(UserLikesCounter i_User)
        {
            i_User.Likes++;
        }

        public void addNewUserToLikeCountsList(User i_User)
        {
            UserLikesCounter newFriendToAdd = new UserLikesCounter(i_User);
            CountersList.Add(newFriendToAdd);
        }

        public int sortByLikes(UserLikesCounter i_UserOne, UserLikesCounter i_UserTwo)
        {
            return i_UserOne.Likes - i_UserTwo.Likes;
        }

        public UserLikesCounter UserExistInList(User i_User)
        {
            UserLikesCounter userLikesCounter = null;

            foreach (UserLikesCounter existentUser in CountersList)
            {
                if (existentUser.LikedByUser.Id == i_User.Id)
                {
                    userLikesCounter = existentUser;
                }
            }

            return userLikesCounter;
        }
    }

}