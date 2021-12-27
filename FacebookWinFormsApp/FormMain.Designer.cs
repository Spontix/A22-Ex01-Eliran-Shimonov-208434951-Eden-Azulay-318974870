
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label imageSqaureLabel;
            System.Windows.Forms.Label linkToFacebookLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
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
            this.panelEvents = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imageSqaurePictureBox = new System.Windows.Forms.PictureBox();
            this.linkToFacebookLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.linkLabelEvents = new System.Windows.Forms.LinkLabel();
            this.eventBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eventBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            endTimeLabel = new System.Windows.Forms.Label();
            imageSqaureLabel = new System.Windows.Forms.Label();
            linkToFacebookLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop3Likes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyApp)).BeginInit();
            this.panelEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSqaurePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingNavigator)).BeginInit();
            this.eventBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // endTimeLabel
            // 

            this.buttonPost.Click += postButton_Click;
            this.pictureBoxFriends.DoubleClick += pictureBoxFriends_DoubleClick;
            this.pictureBoxTop3Likes.DoubleClick += pictureBoxTop3Likes_DoubleClick;
            this.pictureBoxAlbums.DoubleClick += pictureBoxAlbums_DoubleClick;
            this.pictureBoxGroups.DoubleClick += pictureBoxGroups_DoubleClick;
            this.pictureBoxPosts.DoubleClick += pictureBoxPosts_DoubleClick;
            this.pictureBoxNew.DoubleClick += pictureBoxNew_DoubleClick;
            this.listBoxGeneralOutput.SelectedIndexChanged += listBoxGeneralOutput_SelectedIndexChanged;
            this.listBoxGeneral.SelectedIndexChanged += listBoxGeneral_SelectedIndexChanged;
            this.buttonLogin.Click += buttonLogin_Click;
            this.buttonLogout.Click += buttonLogout_Click;
            this.linkLabelEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEvents_LinkClicked);


            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(15, 268);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(72, 17);
            endTimeLabel.TabIndex = 2;
            endTimeLabel.Text = "End Time:";
            // 
            // imageSqaureLabel
            // 
            imageSqaureLabel.AutoSize = true;
            imageSqaureLabel.Location = new System.Drawing.Point(15, 67);
            imageSqaureLabel.Name = "imageSqaureLabel";
            imageSqaureLabel.Size = new System.Drawing.Size(100, 17);
            imageSqaureLabel.TabIndex = 4;
            imageSqaureLabel.Text = "Image Sqaure:";
            // 
            // linkToFacebookLabel
            // 
            linkToFacebookLabel.AutoSize = true;
            linkToFacebookLabel.Location = new System.Drawing.Point(15, 21);
            linkToFacebookLabel.Name = "linkToFacebookLabel";
            linkToFacebookLabel.Size = new System.Drawing.Size(125, 17);
            linkToFacebookLabel.TabIndex = 6;
            linkToFacebookLabel.Text = "Link To Facebook:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(15, 44);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(15, 229);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(77, 17);
            startTimeLabel.TabIndex = 10;
            startTimeLabel.Text = "Start Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(15, 140);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description:";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(12, 737);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(399, 39);
            this.buttonLogout.TabIndex = 56;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(13, 783);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(118, 21);
            this.checkBoxRememberMe.TabIndex = 67;
            this.checkBoxRememberMe.Text = "RememberMe";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 685);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(399, 39);
            this.buttonLogin.TabIndex = 55;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // listBoxGeneral
            // 
            this.listBoxGeneral.FormattingEnabled = true;
            this.listBoxGeneral.ItemHeight = 16;
            this.listBoxGeneral.Location = new System.Drawing.Point(437, 82);
            this.listBoxGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGeneral.Name = "listBoxGeneral";
            this.listBoxGeneral.Size = new System.Drawing.Size(301, 148);
            this.listBoxGeneral.TabIndex = 59;
            // 
            // listBoxGeneralOutput
            // 
            this.listBoxGeneralOutput.FormattingEnabled = true;
            this.listBoxGeneralOutput.ItemHeight = 16;
            this.listBoxGeneralOutput.Location = new System.Drawing.Point(748, 52);
            this.listBoxGeneralOutput.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGeneralOutput.Name = "listBoxGeneralOutput";
            this.listBoxGeneralOutput.Size = new System.Drawing.Size(377, 148);
            this.listBoxGeneralOutput.TabIndex = 60;
            // 
            // textBoxManu
            // 
            this.textBoxManu.Enabled = false;
            this.textBoxManu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBoxManu.Location = new System.Drawing.Point(511, 238);
            this.textBoxManu.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxManu.Name = "textBoxManu";
            this.textBoxManu.Size = new System.Drawing.Size(149, 22);
            this.textBoxManu.TabIndex = 62;
            this.textBoxManu.Text = "Double click on image";
            // 
            // pictureBoxNew
            // 
            this.pictureBoxNew.Image = global::BasicFacebookFeatures.Properties.Resources.new_icon;
            this.pictureBoxNew.Location = new System.Drawing.Point(591, 270);
            this.pictureBoxNew.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxNew.Name = "pictureBoxNew";
            this.pictureBoxNew.Size = new System.Drawing.Size(145, 145);
            this.pictureBoxNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNew.TabIndex = 63;
            this.pictureBoxNew.TabStop = false;
            // 
            // pictureBoxPosts
            // 
            this.pictureBoxPosts.Image = global::BasicFacebookFeatures.Properties.Resources.post_icon;
            this.pictureBoxPosts.Location = new System.Drawing.Point(435, 270);
            this.pictureBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPosts.Name = "pictureBoxPosts";
            this.pictureBoxPosts.Size = new System.Drawing.Size(148, 145);
            this.pictureBoxPosts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPosts.TabIndex = 61;
            this.pictureBoxPosts.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(14, 236);
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
            this.pictureBoxGroups.Location = new System.Drawing.Point(433, 574);
            this.pictureBoxGroups.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGroups.Name = "pictureBoxGroups";
            this.pictureBoxGroups.Size = new System.Drawing.Size(147, 139);
            this.pictureBoxGroups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGroups.TabIndex = 4;
            this.pictureBoxGroups.TabStop = false;
            // 
            // pictureBoxAlbums
            // 
            this.pictureBoxAlbums.Image = global::BasicFacebookFeatures.Properties.Resources.albums_icon;
            this.pictureBoxAlbums.Location = new System.Drawing.Point(435, 423);
            this.pictureBoxAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAlbums.Name = "pictureBoxAlbums";
            this.pictureBoxAlbums.Size = new System.Drawing.Size(147, 144);
            this.pictureBoxAlbums.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbums.TabIndex = 3;
            this.pictureBoxAlbums.TabStop = false;
            // 
            // pictureBoxGeneral
            // 
            this.pictureBoxGeneral.Location = new System.Drawing.Point(999, 208);
            this.pictureBoxGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGeneral.Name = "pictureBoxGeneral";
            this.pictureBoxGeneral.Size = new System.Drawing.Size(126, 104);
            this.pictureBoxGeneral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGeneral.TabIndex = 2;
            this.pictureBoxGeneral.TabStop = false;
            // 
            // pictureBoxTop3Likes
            // 
            this.pictureBoxTop3Likes.Image = global::BasicFacebookFeatures.Properties.Resources.top3_icon;
            this.pictureBoxTop3Likes.Location = new System.Drawing.Point(587, 574);
            this.pictureBoxTop3Likes.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxTop3Likes.Name = "pictureBoxTop3Likes";
            this.pictureBoxTop3Likes.Size = new System.Drawing.Size(149, 139);
            this.pictureBoxTop3Likes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTop3Likes.TabIndex = 1;
            this.pictureBoxTop3Likes.TabStop = false;
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.Image = global::BasicFacebookFeatures.Properties.Resources.Friends_icon;
            this.pictureBoxFriends.Location = new System.Drawing.Point(590, 423);
            this.pictureBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(148, 144);
            this.pictureBoxFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriends.TabIndex = 0;
            this.pictureBoxFriends.TabStop = false;
            // 
            // pictureBoxMyApp
            // 
            this.pictureBoxMyApp.Image = global::BasicFacebookFeatures.Properties.Resources.app_icon;
            this.pictureBoxMyApp.Location = new System.Drawing.Point(13, 52);
            this.pictureBoxMyApp.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxMyApp.Name = "pictureBoxMyApp";
            this.pictureBoxMyApp.Size = new System.Drawing.Size(400, 178);
            this.pictureBoxMyApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMyApp.TabIndex = 58;
            this.pictureBoxMyApp.TabStop = false;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(437, 52);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(303, 22);
            this.textBoxPost.TabIndex = 64;
            this.textBoxPost.Text = "Write somthing";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(666, 52);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 66;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            // 
            // panelEvents
            // 
            this.panelEvents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelEvents.Controls.Add(descriptionLabel);
            this.panelEvents.Controls.Add(this.descriptionTextBox);
            this.panelEvents.Controls.Add(endTimeLabel);
            this.panelEvents.Controls.Add(this.endTimeDateTimePicker);
            this.panelEvents.Controls.Add(imageSqaureLabel);
            this.panelEvents.Controls.Add(this.imageSqaurePictureBox);
            this.panelEvents.Controls.Add(linkToFacebookLabel);
            this.panelEvents.Controls.Add(this.linkToFacebookLinkLabel);
            this.panelEvents.Controls.Add(nameLabel);
            this.panelEvents.Controls.Add(this.nameLabel1);
            this.panelEvents.Controls.Add(startTimeLabel);
            this.panelEvents.Controls.Add(this.startTimeDateTimePicker);
            this.panelEvents.Location = new System.Drawing.Point(745, 499);
            this.panelEvents.Name = "panelEvents";
            this.panelEvents.Size = new System.Drawing.Size(385, 306);
            this.panelEvents.TabIndex = 68;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(165, 137);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 77);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(165, 264);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.endTimeDateTimePicker.TabIndex = 3;
            // 
            // imageSqaurePictureBox
            // 
            this.imageSqaurePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageSqaure", true));
            this.imageSqaurePictureBox.Location = new System.Drawing.Point(165, 67);
            this.imageSqaurePictureBox.Name = "imageSqaurePictureBox";
            this.imageSqaurePictureBox.Size = new System.Drawing.Size(71, 50);
            this.imageSqaurePictureBox.TabIndex = 5;
            this.imageSqaurePictureBox.TabStop = false;
            // 
            // linkToFacebookLinkLabel
            // 
            this.linkToFacebookLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "LinkToFacebook", true));
            this.linkToFacebookLinkLabel.Location = new System.Drawing.Point(165, 21);
            this.linkToFacebookLinkLabel.Name = "linkToFacebookLinkLabel";
            this.linkToFacebookLinkLabel.Size = new System.Drawing.Size(200, 23);
            this.linkToFacebookLinkLabel.TabIndex = 7;
            this.linkToFacebookLinkLabel.TabStop = true;
            this.linkToFacebookLinkLabel.Text = "linkLabel1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(165, 44);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(200, 23);
            this.nameLabel1.TabIndex = 9;
            this.nameLabel1.Text = "label1";
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(165, 225);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startTimeDateTimePicker.TabIndex = 11;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(745, 319);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(380, 164);
            this.listBoxEvents.TabIndex = 69;
            // 
            // linkLabelEvents
            // 
            this.linkLabelEvents.AutoSize = true;
            this.linkLabelEvents.Location = new System.Drawing.Point(745, 299);
            this.linkLabelEvents.Name = "linkLabelEvents";
            this.linkLabelEvents.Size = new System.Drawing.Size(51, 17);
            this.linkLabelEvents.TabIndex = 70;
            this.linkLabelEvents.TabStop = true;
            this.linkLabelEvents.Text = "Events";
            this.linkLabelEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEvents_LinkClicked);
            // 
            // eventBindingNavigator
            // 
            this.eventBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventBindingNavigator.BindingSource = this.eventBindingSource;
            this.eventBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.eventBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eventBindingNavigatorSaveItem});
            this.eventBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventBindingNavigator.Name = "eventBindingNavigator";
            this.eventBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventBindingNavigator.Size = new System.Drawing.Size(1146, 27);
            this.eventBindingNavigator.TabIndex = 71;
            this.eventBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // eventBindingNavigatorSaveItem
            // 
            this.eventBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventBindingNavigatorSaveItem.Enabled = false;
            this.eventBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventBindingNavigatorSaveItem.Image")));
            this.eventBindingNavigatorSaveItem.Name = "eventBindingNavigatorSaveItem";
            this.eventBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.eventBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 844);
            this.Controls.Add(this.eventBindingNavigator);
            this.Controls.Add(this.linkLabelEvents);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.panelEvents);
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
            this.Controls.Add(this.checkBoxRememberMe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "MyApp";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop3Likes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyApp)).EndInit();
            this.panelEvents.ResumeLayout(false);
            this.panelEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSqaurePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingNavigator)).EndInit();
            this.eventBindingNavigator.ResumeLayout(false);
            this.eventBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxTop3Likes;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
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
        private TextBox textBoxPost;
        private Button buttonPost;
        private Panel panelEvents;
        private BindingSource eventBindingSource;
        private DateTimePicker endTimeDateTimePicker;
        private PictureBox imageSqaurePictureBox;
        private LinkLabel linkToFacebookLinkLabel;
        private Label nameLabel1;
        private DateTimePicker startTimeDateTimePicker;
        private ListBox listBoxEvents;
        private LinkLabel linkLabelEvents;
        private BindingNavigator eventBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton eventBindingNavigatorSaveItem;
        private TextBox descriptionTextBox;
    }
}
