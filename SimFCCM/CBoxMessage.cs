using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace CBoxSim 
 {
    public static class CogenMessage
    {
        static readonly ILog log = LogManager.GetLogger("Console");

        internal const byte STX = 0x23;     // '#'
        internal const byte ETX = 0x3A;     // ':'

        private static void SetTagValue(string tag, int value, ref DataTable dataTable)
        {
            DataRow row = dataTable.Rows.Find(tag);
            if (row != null)
            {
                int state = 0;
                if (row[1] is int)
                {
                    row[1] = value;
                }
                else
                {
                    Debug.Print("invalid value {0}", row[1].ToString());
                    return;
                }
            }
        }

        public static bool ParseResponse(List<byte> rxData, ref DataTable dataTable)
        {
            // check validation


            // get data field
            byte data1 = rxData[4];
            byte data2 = rxData[5];
            byte data3 = rxData[6];

            // parse data-1
            int isOn = (data1 & 0x01) > 0 ? 1 : 0;
            SetTagValue("Fan1", 1, ref dataTable);

            // parse data-2
            isOn = (data2 & 0x80) > 0 ? 1 : 0;
            SetTagValue("Fan2", 1, ref dataTable);
            isOn = (data2 & 0x40) > 0 ? 1 : 0;
            SetTagValue("Fan3", 1, ref dataTable);

            // parse data-3
            SetTagValue("Pmp02Des", data3, ref dataTable);

            return true;
        }

        public static byte MakeRequest(ref List<byte> txData, DataTable dataTable)
        {
            return 0;
        }
    }
}
