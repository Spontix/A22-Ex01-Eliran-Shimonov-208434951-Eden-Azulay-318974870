using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using CefSharp.DevTools.Fetch;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using DesktopApplication;
using SortLikesPostThatLikedByUser;

using Message = System.Windows.Forms.Message;
//Eden!
=======
//Eliran!
namespace FacebookWinFormsAppUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            //knhknkjnkjnkjnjn
        }



        public UserLikesCounterList UserLikesCounterList { get; set; }

        public User LoggedInUser { get; set; }
        
        public LoginResult LoginResult { get; set; }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("eliranshimonov@gmail.com"); /// the current password for Eliran

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

            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;
                pictureBoxProfile.LoadAsync(LoggedInUser.Albums[1].Photos[0].PictureNormalURL);//adapter?
                buttonLogin.Enabled = false;
            }
            else
            {
                MessageBox.Show("Log-in Field");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            resetAllForm();
        }

        private void resetAllForm()
        {
            buttonLogin.Enabled = true;
            pictureBoxProfile.Image = null;
            pictureBoxGeneral.Image = null;
            listBoxGeneral.Items.Clear();
            listBoxGeneralOutput.Items.Clear();
            LoggedInUser = null;
        }


        private void pictureBoxFriends_DoubleClick(object sender, System.EventArgs e)
        {
           fetchFriends();
        }

        void fetchFriends()
        {
            pictureBoxGeneral.Image = null;
            listBoxGeneral.Items.Clear();
            listBoxGeneralOutput.Items.Clear();
            if (loginHandler())
            {
                try
                {
                    foreach (User chosenFriend in LoggedInUser.Friends)
                    {
                        listBoxGeneral.Items.Add(chosenFriend);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (listBoxGeneral.Items.Count == 0)
                {
                    MessageBox.Show("No friends to retrieve :(");
                }
            }
        }

        private void pictureBoxAlbums_DoubleClick(object sender, System.EventArgs e)
        {
            fetchAlbums();
        }

        void fetchAlbums()
        {
            pictureBoxGeneral.Image = null;
            listBoxGeneral.Items.Clear();
            listBoxGeneralOutput.Items.Clear();
            if (loginHandler())
            {
                try
                {
                    foreach (Album chosenAlbum in LoggedInUser.Albums)
                    {
                        listBoxGeneral.Items.Add(chosenAlbum);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (listBoxGeneral.Items.Count == 0)
                {
                    MessageBox.Show("No albums to retrieve :(");
                }
            }
        }

        private void pictureBoxGroups_DoubleClick(object sender, System.EventArgs e)
        {
            fetchGroups();
        }

        void fetchGroups()
        {
            pictureBoxGeneral.Image = null;
            listBoxGeneral.Items.Clear();
            listBoxGeneralOutput.Items.Clear();
            if (loginHandler())
            {
                try
                {
                    foreach (Group chosenGroup in LoggedInUser.Groups)
                    {
                        pictureBoxGeneral.Visible = true;
                        listBoxGeneral.Items.Add(chosenGroup);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (listBoxGeneral.Items.Count == 0)
                {
                    MessageBox.Show("No groups to retrieve :(");
                }
            }

        }

        private void pictureBoxNew_DoubleClick(object sender, System.EventArgs e)
        {
            playGameFourInARow();
        }

        void playGameFourInARow()
        {
            pictureBoxGeneral.Image = null;
            listBoxGeneralOutput.Items.Clear();
            listBoxGeneral.Items.Clear();

            if (loginHandler())
            {
                FormGame desktopGame = new FormGame();
                desktopGame.RunGameSettings(LoggedInUser.FirstName);
            }
        }
        private void pictureBoxPosts_DoubleClick(object sender, System.EventArgs e)
        {
            fetchPosts();
        }

        void fetchPosts()
        {
            pictureBoxGeneral.Image = null;
            listBoxGeneral.Items.Clear();
            listBoxGeneralOutput.Items.Clear();

            if (loginHandler())
            {
                try
                {
                    foreach (Post chosenPost in LoggedInUser.Posts)
                    {
                        if (chosenPost.Message != null)
                        {
                            listBoxGeneral.Items.Add(chosenPost.Message);

                        }
                        else if (chosenPost.Caption != null)
                        {
                            listBoxGeneral.Items.Add(chosenPost.Caption);
                        }
                        else
                        {
                            listBoxGeneral.Items.Add(string.Format("[{0}]", chosenPost.Type));
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (listBoxGeneral.Items.Count == 0)
                {
                    MessageBox.Show("No Posts to retrieve :(");
                }
            }
        }

        private void listBoxGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxGeneral.Image = null;
            listBoxGeneralOutput.Items.Clear();

            if (listBoxGeneral.SelectedItem is Photo)
            {
                loadPhoto((listBoxGeneral.SelectedItem as Photo).PictureNormalURL);
            }
            else if (listBoxGeneral.SelectedItem is Album)
            {
                foreach (Photo image in (listBoxGeneral.SelectedItem as Album).Photos)
                {
                    listBoxGeneralOutput.Items.Add(image);
                }
            }
            else if (listBoxGeneral.SelectedItem is User)
            {
                loadPhoto((listBoxGeneral.SelectedItem as User).Albums[1].Photos[0].PictureNormalURL);
                listBoxGeneralOutput.Items.Add((listBoxGeneral.SelectedItem as User).Birthday);
                listBoxGeneralOutput.Items.Add((listBoxGeneral.SelectedItem as User).Gender);
                //listBoxGeneralOutput.Items.Add((listBoxGeneral.SelectedItem as User).Email);
                listBoxGeneralOutput.Items.Add((listBoxGeneral.SelectedItem as User).About);
                //listBoxGeneralOutput.Items.Add((listBoxGeneral.SelectedItem as User).Educations);
            }
            else if (listBoxGeneral.SelectedItem is Group)
            {
                loadPhoto((listBoxGeneral.SelectedItem as Group).PictureNormalURL);
                foreach (User goupMember in (listBoxGeneral.SelectedItem as Group).Members)
                {
                    listBoxGeneralOutput.Items.Add(goupMember);
                }
            }
            else if (listBoxGeneral.SelectedItem is String)
            {
                Post chosenPost = LoggedInUser.Posts[listBoxGeneral.SelectedIndex];
                foreach (Comment comment in chosenPost.Comments)
                {
                    listBoxGeneralOutput.Items.Add(comment);
                }
                if (chosenPost.Type == Post.eType.photo)
                {
                    loadPhoto(chosenPost.PictureURL);
                }

            }

        }

        private void pictureBoxTop3Likes_DoubleClick(object sender, System.EventArgs e)
        {
            fetchTop3Likes();
        }

        void fetchTop3Likes()
        {

            if (loginHandler())
            {
                try
                {
                    addLikeToUsersWhoLikedYou();

                    Comparison<UserLikesCounter> comparison =
                        new Comparison<UserLikesCounter>(UserLikesCounterList.sortByLikes); //ToDo rename the function
                    UserLikesCounterList.CountersList.Sort(comparison);
                    listBoxGeneral.Items.Clear();

                    showTop3Friends();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (listBoxGeneral.Items.Count == 0)
                {
                    MessageBox.Show("No Top3Likes to retrieve :(");
                }
            }
        }

        private void listBoxGeneralOutput_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listBoxGeneralOutput.SelectedItem is Photo)
            {
                loadPhoto((listBoxGeneralOutput.SelectedItem as Photo).PictureNormalURL);
            }
        }

        void loadPhoto(string i_Picture)
        {
            pictureBoxGeneral.LoadAsync(i_Picture);
        }

        void showTop3Friends()
        {
            int countToThree = 0;

            foreach (UserLikesCounter user in UserLikesCounterList.CountersList)
            {
                listBoxGeneral.Items.Add(user.LikedByUser);
                listBoxGeneral.Items.Add(user.Likes);
                countToThree++;

                if (countToThree == 3)
                {
                    break;
                }
            }
        }

        void addLikeToUsersWhoLikedYou()
        {
            foreach (Post post in LoggedInUser.Posts)
            {
                foreach (User user in post.LikedBy)
                {
                    UserLikesCounter userLikesCounter = UserLikesCounterList.UserExistInList(user);

                    if (userLikesCounter != null)
                    {
                        UserLikesCounterList.addALikeCountsToUser(userLikesCounter);
                    }
                    else
                    {
                        UserLikesCounterList.addNewUserToLikeCountsList(user);
                    }
                }
            }
        }

        private bool loginHandler()
        {
            bool userLogedin = true;
            if (LoggedInUser == null)
            {
                MessageBox.Show("Please log-in first");
                userLogedin = false;
            }

            return userLogedin;
        }

        private void postButton_Click(object sender, System.EventArgs e)
        {
            if (loginHandler())
            {
                try
                {
                    Status postedStatus = LoggedInUser.PostStatus(textBoxPost.Text);
                    MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

    }

}
