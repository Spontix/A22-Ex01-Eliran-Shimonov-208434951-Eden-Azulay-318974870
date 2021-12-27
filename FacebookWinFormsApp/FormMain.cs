using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CefSharp.DevTools.Fetch;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using DesktopApplication;
using Facebook;
using SortLikesPostThatLikedByUser;
using FacebookAPIHandler;

using Message = System.Windows.Forms.Message;
//Eden!
//Eliran!
namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            FacebookAPILogic = new FacebookAPI();
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
        }

        public FacebookAPI FacebookAPILogic { get; set; }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            ApplicationSettings.Instance.LastWindowState = this.WindowState;
            ApplicationSettings.Instance.LastWindowSize = this.ClientSize;
            ApplicationSettings.Instance.LastWindowLocation = this.Location;
            ApplicationSettings.Instance.AutoLogin = this.checkBoxRememberMe.Checked;
            ApplicationSettings.Instance.Save();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            this.ClientSize = ApplicationSettings.Instance.LastWindowSize;
            this.WindowState = ApplicationSettings.Instance.LastWindowState;
            this.Location = ApplicationSettings.Instance.LastWindowLocation;
            this.checkBoxRememberMe.Checked = ApplicationSettings.Instance.AutoLogin;

            if (ApplicationSettings.Instance.AutoLogin)
            {
                new Thread(this.autoLogin).Start();
            }
        }

        private void autoLogin()
        {
            try
            {
                LoginResult result = FacebookService.Connect(ApplicationSettings.Instance.AccessToken);
                FacebookAPILogic.LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
            }
            catch (Exception ex)
            {
                ///(OAuthException - #190) Error validating access token: Session has expired..
                if (ex.Message.Contains("#190"))
                {
                    this.Invoke((Action)loginAndInit);
                }
                else
                {
                    this.Invoke(new Action(() => MessageBox.Show("Could not connect to Facebook server. Please try again later..")));
                }
            }
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void loginAndInit()
        {
            Clipboard.SetText("eliranshimonov@gmail.com"); /// the current password for Eliran
            FacebookAPILogic.facebookLogin();
            if (!string.IsNullOrEmpty(FacebookAPILogic.LoginResult.AccessToken))
            {
                FacebookAPILogic.LoggedInUser = FacebookAPILogic.LoginResult.LoggedInUser;
                ApplicationSettings.Instance.AccessToken = FacebookAPILogic.LoginResult.AccessToken;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show("Log-in Field");
            }
        }

        private void fetchUserInfo()
        {
            new Thread(() =>
            {
                this.Invoke(new Action(() =>
                {
                    pictureBoxProfile.LoadAsync(FacebookAPILogic.LoggedInUser.Albums[1].Photos[0].PictureNormalURL);
                    buttonLogin.Enabled = false;
                }));
            }).Start();
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
            FacebookAPILogic.LoggedInUser = null;
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
                    foreach (User chosenFriend in FacebookAPILogic.LoggedInUser.Friends)
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
                    foreach (Album chosenAlbum in FacebookAPILogic.LoggedInUser.Albums)
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
                    foreach (Group chosenGroup in FacebookAPILogic.LoggedInUser.Groups)
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
                desktopGame.RunGameSettings(FacebookAPILogic.LoggedInUser.FirstName);
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
                    foreach (Post chosenPost in FacebookAPILogic.LoggedInUser.Posts)
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
                Post chosenPost = FacebookAPILogic.LoggedInUser.Posts[listBoxGeneral.SelectedIndex];
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
                        new Comparison<UserLikesCounter>(FacebookAPILogic.UserLikesCounterList.sortByLikes); //ToDo rename the function
                    FacebookAPILogic.UserLikesCounterList.CountersList.Sort(comparison);
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

            foreach (UserLikesCounter user in FacebookAPILogic.UserLikesCounterList.CountersList)
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
            foreach (Post post in FacebookAPILogic.LoggedInUser.Posts)
            {
                foreach (User user in post.LikedBy)
                {
                    UserLikesCounter userLikesCounter = FacebookAPILogic.UserLikesCounterList.UserExistInList(user);

                    if (userLikesCounter != null)
                    {
                        FacebookAPILogic.UserLikesCounterList.addALikeCountsToUser(userLikesCounter);
                    }
                    else
                    {
                        FacebookAPILogic.UserLikesCounterList.addNewUserToLikeCountsList(user);
                    }
                }
            }
        }

        private bool loginHandler()
        {
            bool userLogedin = true;
            if (FacebookAPILogic.LoggedInUser == null)
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
                    Status postedStatus = FacebookAPILogic.LoggedInUser.PostStatus(textBoxPost.Text);
                    MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            if (loginHandler())
            {

                try
                {
                    eventBindingSource.DataSource = FacebookAPILogic.LoggedInUser.Events;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (listBoxEvents.Items.Count == 0)
                {
                    MessageBox.Show("No Events to retrieve :(");
                }
            }


            /*listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in FacebookAPILogic.LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }*/
        }
    }

}
