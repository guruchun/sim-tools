using FcpUtils;
using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBoxSim 
 {
    public static class CBoxMessage
    {
        static readonly ILog log = LogManager.GetLogger("Console");

        public static string Protocol { get; set; }
        internal const byte STX = 0x02;
        //internal const byte STX_10k = 0x3A;
        internal const byte ETX = 0x03;
        internal const byte REQ_STATUS = 0x10;
        internal const byte REQ_MONTH = 0x20;
        internal const byte REQ_YEAR = 0x30;
        internal const byte REQ_CTRL = 0x80;
        internal const byte CTRL_FC_ON = 0x01;
        internal const byte CTRL_FC_OFF = 0x02;

        internal static byte GetSTX()
        {
            //if (Protocol.Contains("10k"))
            //    return STX_10k;
            //else
                return STX;
        }

        internal static byte[] MakeResponse(byte cmd, byte cmdData, SortedDictionary<int, MemoryMap.AddressInfo> tagInfos)
        {
            List<byte> txData = new List<byte>();
            byte msgLength = 0;

            // generate response message
            txData.Add(GetSTX());   // [0] STX
            txData.Add(0x10);       // [1] TX
            txData.Add(0x00);       // [2] message length will be updated after composing
            txData.Add(cmd);
            switch (cmd)
            {
                case REQ_STATUS:      // realtime data
                    msgLength = MakeRealtimeData(ref txData, tagInfos);
                    break;
                case REQ_MONTH:      // montly data
                    msgLength = MakeMonthData(cmdData, ref txData, tagInfos);
                    break;
                case REQ_YEAR:      // yearly data
                    msgLength = MakeYearData(cmdData, ref txData, tagInfos);
                    break;
            }
            if (msgLength > 0)
            {
                txData[2] = msgLength;
                txData.Add(ETX);
            }

            return txData.ToArray();
        }

        private static byte MakeRealtimeData(ref List<byte> txData, SortedDictionary<int, MemoryMap.AddressInfo> tagInfos)
        {
            // 앞에 4개는 16bit 데이터
            for (int i=0; i<4; i++)
            {
                UInt16 memValue = 0;
                bool isInfo = tagInfos.TryGetValue(i, out MemoryMap.AddressInfo memInfo);
                if (!isInfo)
                    log.Error("not found address " + i + " in tagInfos");

                bool isValue = isInfo ? UInt16.TryParse(tagInfos[i].Value, out memValue) : false;
                if (isInfo && isValue)
                {
                    var bytes = BitConverter.GetBytes(memValue);
                    if (BitConverter.IsLittleEndian)
                        Array.Reverse(bytes);
                    txData.AddRange(bytes);
                }
                else
                {
                    txData.Add(0x00);
                    txData.Add(0x00);
                }
                txData.Add(0x09);
            }
            // 뒤에 2개는 8bit data
            for (int i = 4; i < 6; i++)
            {
                byte memValue = 0;
                bool isInfo = tagInfos.TryGetValue(i, out MemoryMap.AddressInfo memInfo);
                if (!isInfo)
                    log.Error("not found address " + i + " in tagInfos");

                bool isValue = isInfo ? byte.TryParse(tagInfos[i].Value, out memValue) : false;
                if (isInfo && isValue)
                {
                    txData.Add(memValue);
                }
                else
                {
                    txData.Add(0x00);
                }
                txData.Add(0x09);
            }
            // 마지막 delimeter 삭제
            txData.RemoveAt(txData.Count - 1);

            return 15;
        }

        private static byte MakeMonthData(byte cmdData, ref List<byte> txData, SortedDictionary<int, MemoryMap.AddressInfo> tagInfos)
        {
            // 조회할 월(0~11)
            int month = cmdData - 0x31;
            log.Info("request, monthly data, month=" + month);

            // index 10부터 월별 5개의 데이터 항목이 저장되어 있음
            int startIndex = 10 + (month * 5);
            // 16bit 데이터
            for (int i = startIndex; i < startIndex + 5; i++)
            {
                UInt16 memValue = 0;
                bool isInfo = tagInfos.TryGetValue(i, out MemoryMap.AddressInfo memInfo);
                if (!isInfo)
                    log.Error("not found address " + i + " in tagInfos");

                bool isValue = isInfo ? UInt16.TryParse(tagInfos[i].Value, out memValue) : false;
                if (isInfo && isValue)
                {
                    var bytes = BitConverter.GetBytes(memValue);
                    if (BitConverter.IsLittleEndian)
                        Array.Reverse(bytes);
                    txData.AddRange(bytes);
                }
                else
                {
                    txData.Add(0x00);
                    txData.Add(0x00);
                }
                txData.Add(0x09);
            }
            // 마지막 delimeter 삭제
            txData.RemoveAt(txData.Count - 1);
            return 14;
        }

        private static byte MakeYearData(byte cmdData, ref List<byte> txData, SortedDictionary<int, MemoryMap.AddressInfo> tagInfos)
        {
            // 조회할 연도(0~2)
            int year = cmdData - 0x50;
            log.Info("request, yearly data, year=" + year);

            // index 100부터 연도별 5개의 데이터 항목이 저장되어 있음
            int startIndex = 100 + (year * 5);
            // 16bit 데이터
            for (int i = startIndex; i < startIndex + 5; i++)
            {
                UInt16 memValue = 0;
                bool isInfo = tagInfos.TryGetValue(i, out MemoryMap.AddressInfo memInfo);
                if (!isInfo)
                    log.Error("not found address " + i + " in tagInfos");

                bool isValue = isInfo ? UInt16.TryParse(tagInfos[i].Value, out memValue) : false;
                if (isInfo && isValue)
                {
                    var bytes = BitConverter.GetBytes(memValue);
                    if (BitConverter.IsLittleEndian)
                        Array.Reverse(bytes);
                    txData.AddRange(bytes);
                }
                else
                {
                    txData.Add(0x00);
                    txData.Add(0x00);
                }
                txData.Add(0x09);
            }
            // 마지막 delimeter 삭제
            txData.RemoveAt(txData.Count - 1);
            return 14;
        }
    }
}
