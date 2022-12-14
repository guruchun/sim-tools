using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimMesg
{
    public class CogenMessage
    {
        public const byte STX = 0x23;
        public const byte ETX = 0x3A;
        public const byte REQD_LEN = 24;        // request data length
        public const byte RSPD_LEN = 4;         // response data length

        //private class BitDataInfo
        //{
        //    public byte ByteIndex { get; set; }
        //    public byte BitIndex { get; set; }
        //    public byte BitWidth { get; set; }
        //    public string MappingTag { get; set; }
        //}
        private struct BitDataInfo
        {
            public uint ByteIndex;
            // TODO add DataType
            public uint BitIndex;   // BITFLD only
            public uint BitWidth;   // BITFLD only
            public uint ValScale;
            public string MappingTag;
        }

        // key: mapIndex, value: BitDataInfo
        // Cogen Data to FCell (Request)
        private static Dictionary<int, BitDataInfo> DicCogenTxDataInfo = new Dictionary<int, BitDataInfo>()
        {
            { 0, new BitDataInfo { ByteIndex=0, BitIndex = 0, BitWidth = 16,  ValScale=1, MappingTag = "TagName1" } },
            { 1, new BitDataInfo { ByteIndex=2, BitIndex = 0, BitWidth = 16,  ValScale=1, MappingTag = "TagName1" } },
            { 2, new BitDataInfo { ByteIndex=4, BitIndex = 0, BitWidth = 8,  ValScale=1, MappingTag = "TH_3" } },
            { 3, new BitDataInfo { ByteIndex=5, BitIndex = 0, BitWidth = 8,  ValScale=1, MappingTag = "TH_2" } },
            { 4, new BitDataInfo { ByteIndex=6, BitIndex = 0, BitWidth = 8,  ValScale=1, MappingTag = "TagName1" } },
            { 10, new BitDataInfo { ByteIndex=7, BitIndex = 1, BitWidth = 1,  ValScale=1, MappingTag = "FAN12" } },
            { 11, new BitDataInfo { ByteIndex=7, BitIndex = 3, BitWidth = 1,  ValScale=1, MappingTag = "NC413" } },
            { 12, new BitDataInfo { ByteIndex=7, BitIndex = 4, BitWidth = 1,  ValScale=1, MappingTag = "NC412" } },
            { 20, new BitDataInfo { ByteIndex=8, BitIndex = 1, BitWidth = 1,  ValScale=1, MappingTag = "LVL_M" } },
            { 21, new BitDataInfo { ByteIndex=8, BitIndex = 2, BitWidth = 1,  ValScale=1, MappingTag = "?" } },
            { 22, new BitDataInfo { ByteIndex=8, BitIndex = 3, BitWidth = 1,  ValScale=1, MappingTag = "LVL_L" } },
            { 23, new BitDataInfo { ByteIndex=8, BitIndex = 4, BitWidth = 1,  ValScale=1, MappingTag = "LVL_H" } },
            { 30, new BitDataInfo { ByteIndex=9, BitIndex = 0, BitWidth = 1,  ValScale=1, MappingTag = "FAN12_ON" } },
            { 31, new BitDataInfo { ByteIndex=9, BitIndex = 1, BitWidth = 1,  ValScale=1, MappingTag = "FAN_MODE" } },
            { 32, new BitDataInfo { ByteIndex=9, BitIndex = 2, BitWidth = 1,  ValScale=1, MappingTag = "NC413_ON" } },
            { 33, new BitDataInfo { ByteIndex=9, BitIndex = 3, BitWidth = 1,  ValScale=1, MappingTag = "NC413_MODE" } },
            { 34, new BitDataInfo { ByteIndex=9, BitIndex = 4, BitWidth = 1,  ValScale=1, MappingTag = "?" } },
            { 35, new BitDataInfo { ByteIndex=9, BitIndex = 5, BitWidth = 1,  ValScale=1, MappingTag = "NC412_SP" } },
            { 36, new BitDataInfo { ByteIndex=9, BitIndex = 6, BitWidth = 1,  ValScale=1, MappingTag = "?" } },
            { 37, new BitDataInfo { ByteIndex=9, BitIndex = 7, BitWidth = 1,  ValScale=1, MappingTag = "?" } },
            { 40, new BitDataInfo { ByteIndex=10, BitIndex = 0, BitWidth = 16,  ValScale=1, MappingTag = "TH_1" } },
            { 41, new BitDataInfo { ByteIndex=12, BitIndex = 0, BitWidth = 16,  ValScale=1, MappingTag = "TH_4" } },
            { 42, new BitDataInfo { ByteIndex=14, BitIndex = 0, BitWidth = 0,  ValScale=1, MappingTag = "PMP02_ON" } },
            { 42, new BitDataInfo { ByteIndex=14, BitIndex = 1, BitWidth = 0,  ValScale=1, MappingTag = "NC417_SP" } },
            { 42, new BitDataInfo { ByteIndex=14, BitIndex = 2, BitWidth = 0,  ValScale=1, MappingTag = "PMP02" } },
            { 42, new BitDataInfo { ByteIndex=14, BitIndex = 3, BitWidth = 0,  ValScale=1, MappingTag = "PMP02" } },
            { 42, new BitDataInfo { ByteIndex=14, BitIndex = 4, BitWidth = 0,  ValScale=1, MappingTag = "PMP02" } },
            { 42, new BitDataInfo { ByteIndex=14, BitIndex = 5, BitWidth = 0,  ValScale=1, MappingTag = "FC4" } },
            { 42, new BitDataInfo { ByteIndex=14, BitIndex = 6, BitWidth = 0,  ValScale=1, MappingTag = "FC5" } },
            { 42, new BitDataInfo { ByteIndex=14, BitIndex = 7, BitWidth = 0,  ValScale=1, MappingTag = "FC6" } },
            { 0, new BitDataInfo { ByteIndex=0, BitIndex = 0, BitWidth = 1,  ValScale=1, MappingTag = "TagName1" } },
            { 0, new BitDataInfo { ByteIndex=0, BitIndex = 0, BitWidth = 1,  ValScale=1, MappingTag = "TagName1" } },
            { 1, new BitDataInfo { ByteIndex=0, BitIndex = 1, BitWidth = 1,  ValScale=1, MappingTag = "TagName1" } }
        };
        private static Dictionary<string, BitDataInfo> DicFCellRxDataInfo = new Dictionary<string, BitDataInfo>()
        {
            { "TagMane1", DicCogenTxDataInfo[0] },
            { "TagName2", DicCogenTxDataInfo[1] }
        };

        // FCell Data to Cogen (Response)
        private static Dictionary<int, BitDataInfo> DicFCellTxDataInfo = new Dictionary<int, BitDataInfo>()
        {
            { 0, new BitDataInfo { ByteIndex=0, BitIndex = 0, BitWidth = 1,  ValScale=1, MappingTag = "TagName1" } },
            { 1, new BitDataInfo { ByteIndex=0, BitIndex = 1, BitWidth = 1,  ValScale=1, MappingTag = "TagName1" } }
        };
        private static Dictionary<string, BitDataInfo> DicCogenRxDataInfo = new Dictionary<string, BitDataInfo>()
        {
            { "TagMane1", DicCogenTxDataInfo[0] },
            { "TagName2", DicCogenTxDataInfo[1] }
        };

        public static string[] GetCogenTagList()
        {
            return DicCogenRxDataInfo.Keys.ToArray();
        }

        public static string[] GetFCellTagList()
        {
            return DicFCellRxDataInfo.Keys.ToArray();
        }

        public Dictionary<string, ValueType> ParseCogenRequest(byte[] reqData)
        {
            Dictionary<string, ValueType> kvReq = new Dictionary<string, ValueType>();

            int dicIndex = 0;
            for (int i = 0; i < reqData.Length; i++)
            {
                for (int j = 0; j < 8;)
                {
                    dicIndex = i * 8 + j;
                    // find tag
                    if (DicFCellTxDataInfo.TryGetValue(dicIndex, out BitDataInfo info))
                    {
                        // get value
                        int valRaw = 0;
                        if (info.BitWidth > 1)
                        {
                            valRaw = (int)BitOP.BitRangeGet(reqData[i], (int)info.BitIndex, info.BitWidth);
                        }
                        else
                        {
                            valRaw = BitOP.IsBitSet(reqData[i], j) ? 1 : 0;
                        }
                        // get scale --> add (tag, value)
                        if (info.ValScale > 1)
                        {
                            double valDbl = (double)valRaw / info.ValScale;
                            kvReq.Add(info.MappingTag, valDbl);
                        }
                        else
                        {
                            kvReq.Add(info.MappingTag, valRaw);
                        }

                        // goto next tag
                        j += (int)info.BitWidth;
                    }
                    // not found tag
                    else
                    {
                        j++;
                    }
                }
            }
            return kvReq;
        }

        public Dictionary<string, ValueType> ParseFCellResponse(byte[] respData)
        {
            Dictionary<string, ValueType> kvResp = new Dictionary<string, ValueType>();

            //int dicIndex = 0;
            //for (int i = 0; i<respData.Length; i++)
            //{
            //    for (int j = 0; j<8;)
            //    {
            //        dicIndex = i * 8 + j;
            //        // find tag
            //        if (DicFCellTxDataInfo.TryGetValue(dicIndex, out BitDataInfo info))
            //        {
            //            // get value
            //            int valRaw = 0;
            //            if (info.BitWidth > 1)
            //            {
            //                valRaw = (int)BitOP.BitRangeGet(respData[i], (int)info.BitIndex, info.BitWidth);
            //            }
            //            else
            //            {
            //                valRaw = BitOP.IsBitSet(respData[i], j) ? 1 : 0;
            //            }
            //            // get scale --> ignored

            //            // add (tag, value)
            //            kvResp.Add(info.MappingTag, valRaw);

            //            // goto next tag
            //            j += (int)info.BitWidth;
            //        }
            //        // not found tag
            //        else
            //        {
            //            j++;
            //        }
            //    }
            //}

            return kvResp;
        }

        public byte[] MakeReqData(Dictionary<string, double> values)
        {
            byte[] data = new byte[REQD_LEN] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            double dtemp = values["tCogenWtrCold"];
            UInt16 temp = (UInt16)(dtemp * 10);
            data[0] = (byte)(temp & 0xFF);
            data[1] = (byte)(temp >> 8 & 0xFF);
            
            temp = (UInt16)values["tCogenTnkMid"];
            data[2] = (byte)(temp & 0xFF);
            data[3] = (byte)(temp >> 8 & 0xFF);

            byte btmp = 0;
            if (values["swtCogenSysRun1"] > 0)
            {
                btmp = (1 << 5);
                data[5] = (byte)(data[5] | btmp);
            }
            if (values["swtCogenSysRun2"] > 0)
            {
                btmp = (1 << 6);
                data[5] = (byte)(data[5] | btmp);
            }
            if (values["swtCogenSysRun3"] > 0)
            {
                btmp = (1 << 7);
                data[5] = (byte)(data[5] | btmp);
            }
            if (values["swtCogenSysRun7"] > 0)
            {
                btmp = (1 << 3);
                data[5] = (byte)(data[5] | btmp);
            }

            // TODO
            return data;
        }

        public byte MakeCheckSum(byte[] data) 
        {
            byte checksum = 0;
            for (int i=0; i<data.Length; i++)
            {
                checksum += data[i];
            }

            return checksum;
        }

        public byte[] MakeReqMessage(byte FcId, byte[] reqData)
        {
            // make dummy data
            byte[] dummy = new byte[REQD_LEN] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            List<byte> data = new List<byte>();
            data.Add(STX);
            data.Add(1);                    // Cogen Address
            data.Add((byte)(0x30 + FcId));  // FCell Address
            data.Add((byte)reqData.Length);                   // data length
            if (reqData.Length != REQD_LEN)
            {
                Debug.WriteLine("Invalid ReqData Size = {0}", reqData.Length);
                data.AddRange(dummy);
            } else
            {
                data.AddRange(reqData);
            }
            data.Add(MakeCheckSum(data.GetRange(0, REQD_LEN+4).ToArray()));
            data.Add(ETX);

            return data.ToArray();
        }
    }   
}
