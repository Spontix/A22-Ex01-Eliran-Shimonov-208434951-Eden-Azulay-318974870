using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class Adapter
    {
        public Adapter(User i_User)
        {
            User = i_User;
        }

        public User User { get; set; }
        public ISelectedItem SelectedItem { get; set; }

        public void SetType(ListBox i_ListBoxGeneral, ListBox i_ListBoxGeneralOutput, PictureBox i_PictureBoxGeneral)
        {
            if (i_ListBoxGeneral.SelectedItem is Photo)
            {
                SelectedItem = new PhotoSelected(i_PictureBoxGeneral);
            }
            else if (i_ListBoxGeneral.SelectedItem is Album)
            {
                SelectedItem = new AlbumSelected(i_ListBoxGeneralOutput);

            }
            else if (i_ListBoxGeneral.SelectedItem is User)
            {
                SelectedItem = new UserSelected(i_ListBoxGeneralOutput, i_PictureBoxGeneral);

            }
            else if (i_ListBoxGeneral.SelectedItem is Group)
            {
                SelectedItem = new GroupSelected(i_ListBoxGeneralOutput, i_PictureBoxGeneral);

            }
            else if (i_ListBoxGeneral.SelectedItem is String)
            {
                SelectedItem = new PostSelected(User, i_ListBoxGeneralOutput, i_PictureBoxGeneral);

            }
            if (SelectedItem != null)
            {
                SelectedItem.ListBoxGeneral = i_ListBoxGeneral;
                SelectedItem.Show();
            }
        }

        public abstract class ISelectedItem
        {
            public System.Windows.Forms.ListBox ListBoxGeneral { get; set; }

            public abstract void Show();

        }


        public class UserSelected : ISelectedItem
        {
            public System.Windows.Forms.ListBox ListBoxGeneralOutput { get; set; }
            public System.Windows.Forms.PictureBox PictureBoxGeneral { get; set; }

            public UserSelected(ListBox listBoxGeneralOutput, PictureBox pictureBoxGeneral)
            {
                ListBoxGeneralOutput = listBoxGeneralOutput;
                PictureBoxGeneral = pictureBoxGeneral;
            }

            public override void Show()
            {
                ListBoxGeneral.Invoke(new Action(() =>
                {
                    PictureBoxGeneral.LoadAsync((ListBoxGeneral.SelectedItem as User).Albums[1].Photos[0]
                        .PictureNormalURL);
                    ListBoxGeneralOutput.Items.Add((ListBoxGeneral.SelectedItem as User).Birthday);
                    ListBoxGeneralOutput.Items.Add((ListBoxGeneral.SelectedItem as User).Gender);
                    ListBoxGeneralOutput.Items.Add((ListBoxGeneral.SelectedItem as User).About);
                }));
            }
        }

        private class PostSelected : ISelectedItem
        {
            public PostSelected(User i_User, ListBox i_ListBoxGeneralOutput, PictureBox i_PictureBoxGeneral)
            {
                User = i_User;
                ListBoxGeneralOutput = i_ListBoxGeneralOutput;
                PictureBoxGeneral = i_PictureBoxGeneral;
            }

            public System.Windows.Forms.ListBox ListBoxGeneralOutput { get; set; }
            public System.Windows.Forms.PictureBox PictureBoxGeneral { get; set; }
            public User User { get; set; }

            public override void Show()
            {
                ListBoxGeneral.Invoke(new Action(() =>
                {
                    Post chosenPost = User.Posts[ListBoxGeneral.SelectedIndex];
                    foreach (Comment comment in chosenPost.Comments)
                    {
                        ListBoxGeneralOutput.Items.Add(comment);
                    }
                    if (chosenPost.Type == Post.eType.photo)
                    {
                        PictureBoxGeneral.LoadAsync(chosenPost.PictureURL);
                    }
                }));
            }
        }

        public class AlbumSelected : ISelectedItem
        {
            public AlbumSelected(ListBox i_ListBoxGeneralOutput)
            {
                ListBoxGeneralOutput = i_ListBoxGeneralOutput;
            }

            public System.Windows.Forms.ListBox ListBoxGeneralOutput { get; set; }
            public override void Show()
            {
                ListBoxGeneral.Invoke(new Action(() =>
                {
                    foreach (Photo image in (ListBoxGeneral.SelectedItem as Album).Photos)
                    {
                        ListBoxGeneralOutput.Items.Add(image);
                    }
                }));
            }
        }

        public class PhotoSelected : ISelectedItem
        {
            public PhotoSelected(PictureBox i_PictureBoxGeneral)
            {
                PictureBoxGeneral = i_PictureBoxGeneral;
            }
            public System.Windows.Forms.PictureBox PictureBoxGeneral { get; set; }
            public override void Show()
            {
                ListBoxGeneral.Invoke(new Action(() =>
                {
                    PictureBoxGeneral.LoadAsync((ListBoxGeneral.SelectedItem as User).Albums[1].Photos[0].PictureNormalURL);
                }));
            }
        }

        public class GroupSelected : ISelectedItem
        {
            public GroupSelected(ListBox i_ListBoxGeneralOutput, PictureBox i_PictureBoxGeneral)
            {
                ListBoxGeneralOutput = i_ListBoxGeneralOutput;
                PictureBoxGeneral = i_PictureBoxGeneral;
            }

            public System.Windows.Forms.ListBox ListBoxGeneralOutput { get; set; }
            public System.Windows.Forms.PictureBox PictureBoxGeneral { get; set; }
            public override void Show()
            {
                ListBoxGeneral.Invoke(new Action(() =>
                {
                    PictureBoxGeneral.LoadAsync((ListBoxGeneral.SelectedItem as Group).PictureNormalURL);
                    foreach (User groupMember in (ListBoxGeneral.SelectedItem as Group).Members)
                    {
                        ListBoxGeneralOutput.Items.Add(groupMember);
                    }
                }));
            }
        }
    }
}

