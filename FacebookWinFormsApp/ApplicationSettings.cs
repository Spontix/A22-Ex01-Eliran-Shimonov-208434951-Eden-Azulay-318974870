using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;
using System.Reflection;

namespace BasicFacebookFeatures
{
    public class ApplicationSettings
    {
        private static ApplicationSettings s_This;
        private static readonly string sr_NameOfFile;

        public bool AutoLogin { get; set; }
        public Size LastWindowSize { get; set; }
        public FormWindowState LastWindowState { get; set; }
        public Point LastWindowLocation { get; set; }
        public string AccessToken { get; set; }

        private ApplicationSettings()
        {
        }


        static ApplicationSettings()
        {
            sr_NameOfFile = Application.ExecutablePath + ".settings.xml";
        }

        public static ApplicationSettings Instance
        {
            get
            {
                if (s_This == null)
                {
                    s_This = ApplicationSettings.LoadFromFileOrDefault();
                }

                return s_This;
            }
        }

        public void Save()
        {
            using (FileStream stream = new FileStream(sr_NameOfFile, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                serializer.Serialize(stream, this);
            }
        }

        private static ApplicationSettings LoadFromFileOrDefault()
        {
            ApplicationSettings loadOrDefault = null;

            if (File.Exists(sr_NameOfFile))
            {
                using (FileStream stream = new FileStream(sr_NameOfFile, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                    loadOrDefault = (ApplicationSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                loadOrDefault = new ApplicationSettings()
                {
                    LastWindowState = FormWindowState.Normal,
                    LastWindowSize = new Size(831,575),
                    AutoLogin = false
                };
            }

            return loadOrDefault;
        }
    }
}
