using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using FcpUtils;
using log4net;

namespace CBoxSim {
    // HMI Server Info.
    public class ServerInfo {
        [XmlElement(ElementName = "ip")]
        public string IP;
        [XmlElement(ElementName = "port")]
        public string Port;
        [XmlElement(ElementName = "protocol")]
        public string Protocol;
        [XmlElement(ElementName = "mode")]
        public string Mode;
    }

    // CBox Configuration
    public class CBoxConfig {
        public ServerInfo network = new ServerInfo();

        [XmlElement(ElementName = "mmap")]
        public string mapFile;

        [XmlArrayItem(ElementName = "watch")]
        public List<string> logView;
    }

    public class ConfigInfo {
        private static ConfigInfo _instance = null;
        public CBoxConfig config;
        private static readonly ILog log = LogManager.GetLogger("Console");

        private ConfigInfo()
        {
        }

        static public ConfigInfo GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ConfigInfo();
                _instance.LoadConfig();
            }
            return _instance;
        }

        private void LoadConfig()
        {
            // loading config by deserializing config.xml
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(CBoxConfig));
                TextReader reader = new StreamReader(Application.StartupPath + "/config/cboxsim-config.xml");
                config = (CBoxConfig)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (System.Exception e1)
            {
                log.Error("config file loading for cbox simulator, " + e1.Message);
                config = new CBoxConfig();
            }
        }
    }
}
