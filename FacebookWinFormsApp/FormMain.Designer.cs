
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsAppUI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.postButton = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.listBoxGeneral = new System.Windows.Forms.ListBox();
            this.listBoxGeneralOutput = new System.Windows.Forms.ListBox();
            this.textBoxManu = new System.Windows.Forms.TextBox();
            this.pictureBoxNew = new System.Windows.Forms.PictureBox();
            this.pictureBoxPosts = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxGroups = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlbums = new System.Windows.Forms.PictureBox();
            this.pictureBoxGeneral = new System.Windows.Forms.PictureBox();
            this.pictureBoxTop3Likes = new System.Windows.Forms.PictureBox();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.pictureBoxMyApp = new System.Windows.Forms.PictureBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop3Likes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyApp)).BeginInit();
            this.SuspendLayout();
            // 
            // postButton
            // 
            this.postButton.Location = new System.Drawing.Point(1341, 23);
            this.postButton.Margin = new System.Windows.Forms.Padding(4);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(100, 28);
            this.postButton.TabIndex = 65;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(15, 585);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(399, 39);
            this.buttonLogout.TabIndex = 56;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(15, 533);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(399, 39);
            this.buttonLogin.TabIndex = 55;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += buttonLogin_Click;
            // 
            // listBoxGeneral
            // 
            this.listBoxGeneral.FormattingEnabled = true;
            this.listBoxGeneral.ItemHeight = 16;
            this.listBoxGeneral.Location = new System.Drawing.Point(437, 52);
            this.listBoxGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGeneral.Name = "listBoxGeneral";
            this.listBoxGeneral.Size = new System.Drawing.Size(644, 148);
            this.listBoxGeneral.TabIndex = 59;
            this.listBoxGeneral.SelectedIndexChanged += listBoxGeneral_SelectedIndexChanged;
            // 
            // listBoxGeneralOutput
            // 
            this.listBoxGeneralOutput.FormattingEnabled = true;
            this.listBoxGeneralOutput.ItemHeight = 16;
            this.listBoxGeneralOutput.Location = new System.Drawing.Point(747, 208);
            this.listBoxGeneralOutput.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGeneralOutput.Name = "listBoxGeneralOutput";
            this.listBoxGeneralOutput.Size = new System.Drawing.Size(335, 164);
            this.listBoxGeneralOutput.TabIndex = 60;
            this.listBoxGeneralOutput.SelectedIndexChanged += listBoxGeneralOutput_SelectedIndexChanged;
            // 
            // textBoxManu
            // 
            this.textBoxManu.Enabled = false;
            this.textBoxManu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBoxManu.Location = new System.Drawing.Point(513, 208);
            this.textBoxManu.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxManu.Name = "textBoxManu";
            this.textBoxManu.Size = new System.Drawing.Size(149, 22);
            this.textBoxManu.TabIndex = 62;
            this.textBoxManu.Text = "Double click on image";
            // 
            // pictureBoxNew
            // 
            this.pictureBoxNew.Image = global::BasicFacebookFeatures.Properties.Resources.new_icon;
            this.pictureBoxNew.Location = new System.Drawing.Point(593, 240);
            this.pictureBoxNew.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxNew.Name = "pictureBoxNew";
            this.pictureBoxNew.Size = new System.Drawing.Size(145, 145);
            this.pictureBoxNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNew.TabIndex = 63;
            this.pictureBoxNew.TabStop = false;
            this.pictureBoxNew.DoubleClick += pictureBoxNew_DoubleClick;
            // 
            // pictureBoxPosts
            // 
            this.pictureBoxPosts.Image = global::BasicFacebookFeatures.Properties.Resources.post_icon;
            this.pictureBoxPosts.Location = new System.Drawing.Point(437, 240);
            this.pictureBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPosts.Name = "pictureBoxPosts";
            this.pictureBoxPosts.Size = new System.Drawing.Size(148, 145);
            this.pictureBoxPosts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPosts.TabIndex = 61;
            this.pictureBoxPosts.TabStop = false;
            this.pictureBoxPosts.DoubleClick += pictureBoxPosts_DoubleClick;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(16, 178);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(399, 347);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 6;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pictureBoxGroups
            // 
            this.pictureBoxGroups.Image = global::BasicFacebookFeatures.Properties.Resources.group_icon;
            this.pictureBoxGroups.Location = new System.Drawing.Point(435, 544);
            this.pictureBoxGroups.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGroups.Name = "pictureBoxGroups";
            this.pictureBoxGroups.Size = new System.Drawing.Size(147, 139);
            this.pictureBoxGroups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGroups.TabIndex = 4;
            this.pictureBoxGroups.TabStop = false;
            this.pictureBoxGroups.DoubleClick += pictureBoxGroups_DoubleClick;
            // 
            // pictureBoxAlbums
            // 
            this.pictureBoxAlbums.Image = global::BasicFacebookFeatures.Properties.Resources.albums_icon;
            this.pictureBoxAlbums.Location = new System.Drawing.Point(437, 393);
            this.pictureBoxAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAlbums.Name = "pictureBoxAlbums";
            this.pictureBoxAlbums.Size = new System.Drawing.Size(147, 144);
            this.pictureBoxAlbums.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbums.TabIndex = 3;
            this.pictureBoxAlbums.TabStop = false;
            this.pictureBoxAlbums.DoubleClick += pictureBoxAlbums_DoubleClick;
            // 
            // pictureBoxGeneral
            // 
            this.pictureBoxGeneral.Location = new System.Drawing.Point(748, 393);
            this.pictureBoxGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGeneral.Name = "pictureBoxGeneral";
            this.pictureBoxGeneral.Size = new System.Drawing.Size(335, 289);
            this.pictureBoxGeneral.TabIndex = 2;
            this.pictureBoxGeneral.TabStop = false;
            this.pictureBoxGeneral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // 
            // pictureBoxTop3Likes
            // 
            this.pictureBoxTop3Likes.Image = global::BasicFacebookFeatures.Properties.Resources.top3_icon;
            this.pictureBoxTop3Likes.Location = new System.Drawing.Point(589, 544);
            this.pictureBoxTop3Likes.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxTop3Likes.Name = "pictureBoxTop3Likes";
            this.pictureBoxTop3Likes.Size = new System.Drawing.Size(149, 139);
            this.pictureBoxTop3Likes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTop3Likes.TabIndex = 1;
            this.pictureBoxTop3Likes.TabStop = false;
            this.pictureBoxTop3Likes.DoubleClick += pictureBoxTop3Likes_DoubleClick;
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.Image = global::BasicFacebookFeatures.Properties.Resources.Friends_icon;
            this.pictureBoxFriends.Location = new System.Drawing.Point(592, 393);
            this.pictureBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(148, 144);
            this.pictureBoxFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriends.TabIndex = 0;
            this.pictureBoxFriends.TabStop = false;
            this.pictureBoxFriends.DoubleClick += pictureBoxFriends_DoubleClick;
            // 
            // pictureBoxMyApp
            // 
            this.pictureBoxMyApp.Image = global::BasicFacebookFeatures.Properties.Resources.app_icon;
            this.pictureBoxMyApp.Location = new System.Drawing.Point(16, 37);
            this.pictureBoxMyApp.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxMyApp.Name = "pictureBoxMyApp";
            this.pictureBoxMyApp.Size = new System.Drawing.Size(400, 134);
            this.pictureBoxMyApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMyApp.TabIndex = 58;
            this.pictureBoxMyApp.TabStop = false;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(437, 20);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(644, 22);
            this.textBoxPost.TabIndex = 64;
            this.textBoxPost.Text = "Write somthing";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(1006, 19);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 66;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += postButton_Click;

            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 708);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.pictureBoxNew);
            this.Controls.Add(this.textBoxManu);
            this.Controls.Add(this.pictureBoxPosts);
            this.Controls.Add(this.listBoxGeneralOutput);
            this.Controls.Add(this.listBoxGeneral);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.pictureBoxGroups);
            this.Controls.Add(this.pictureBoxAlbums);
            this.Controls.Add(this.pictureBoxGeneral);
            this.Controls.Add(this.pictureBoxTop3Likes);
            this.Controls.Add(this.pictureBoxFriends);
            this.Controls.Add(this.pictureBoxMyApp);
            this.Controls.Add(this.postButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "MyApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop3Likes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxTop3Likes;
        private System.Windows.Forms.PictureBox pictureBoxGeneral;
        private System.Windows.Forms.PictureBox pictureBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxGroups;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxMyApp;
        private ListBox listBoxGeneral;
        private ListBox listBoxGeneralOutput;
        private PictureBox pictureBoxPosts;
        private TextBox textBoxManu;
        private PictureBox pictureBoxNew;
        private System.Windows.Forms.Button postButton;
        private TextBox textBoxPost;
        private Button buttonPost;
    }
}
