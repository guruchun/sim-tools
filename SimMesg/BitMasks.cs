using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimMesg {
    public static class BitOP {
        static readonly ulong[] BitMasking = {
            0x00, 0x01, 0x03, 0x07, 0x0F, 0x1F, 0x3F, 0x7F,
            0x00FF, 0x01FF, 0x03FF, 0x07FF, 0x0FFF, 0x1FFF, 0x3FFF, 0x7FFF,
            0x00FFFF, 0x01FFFF, 0x03FFFF, 0x07FFFF, 0x0FFFFF, 0x1FFFFF, 0x3FFFFF, 0x7FFFFF,
            0x00FFFFFF, 0x01FFFFFF, 0x03FFFFFF, 0x07FFFFFF, 0x0FFFFFFF, 0x1FFFFFFF, 0x3FFFFFFF, 0x7FFFFFFF,
            0x00FFFFFFFF, 0x01FFFFFFFF, 0x03FFFFFFFF, 0x07FFFFFFFF, 0x0FFFFFFFFF, 0x1FFFFFFFFF, 0x3FFFFFFFFF, 0x7FFFFFFFFF,
            0x00FFFFFFFFFF, 0x01FFFFFFFFFF, 0x03FFFFFFFFFF, 0x07FFFFFFFFFF,
            0x0FFFFFFFFFFF, 0x1FFFFFFFFFFF, 0x3FFFFFFFFFFF, 0x7FFFFFFFFFFF,
            0x00FFFFFFFFFFFF, 0x01FFFFFFFFFFFF, 0x03FFFFFFFFFFFF, 0x07FFFFFFFFFFFF,
            0x0FFFFFFFFFFFFF, 0x1FFFFFFFFFFFFF, 0x3FFFFFFFFFFFFF, 0x7FFFFFFFFFFFFF,
            0x00FFFFFFFFFFFFFF, 0x01FFFFFFFFFFFFFF, 0x03FFFFFFFFFFFFFF, 0x07FFFFFFFFFFFFFF,
            0x0FFFFFFFFFFFFFFF, 0x1FFFFFFFFFFFFFFF, 0x3FFFFFFFFFFFFFFF, 0x7FFFFFFFFFFFFFFF,
            0xFFFFFFFFFFFFFFFF
        };

        static readonly ulong[] BitMaskIdx = {
            0x0000000000000001, 0x0000000000000002, 0x0000000000000004, 0x0000000000000008,
            0x0000000000000010, 0x0000000000000020, 0x0000000000000040, 0x0000000000000080,
            0x0000000000000100, 0x0000000000000200, 0x0000000000000400, 0x0000000000000800,
            0x0000000000001000, 0x0000000000002000, 0x0000000000004000, 0x0000000000008000,
            0x0000000000010000, 0x0000000000020000, 0x0000000000040000, 0x0000000000080000,
            0x0000000000100000, 0x0000000000200000, 0x0000000000400000, 0x0000000000800000,
            0x0000000001000000, 0x0000000002000000, 0x0000000004000000, 0x0000000008000000,
            0x0000000010000000, 0x0000000020000000, 0x0000000040000000, 0x0000000080000000,
            0x0000000100000000, 0x0000000200000000, 0x0000000400000000, 0x0000000800000000,
            0x0000001000000000, 0x0000002000000000, 0x0000004000000000, 0x0000008000000000,
            0x0000010000000000, 0x0000020000000000, 0x0000040000000000, 0x0000080000000000,
            0x0000100000000000, 0x0000200000000000, 0x0000400000000000, 0x0000800000000000,
            0x0001000000000000, 0x0002000000000000, 0x0004000000000000, 0x0008000000000000,
            0x0010000000000000, 0x0020000000000000, 0x0040000000000000, 0x0080000000000000,
            0x0100000000000000, 0x0200000000000000, 0x0400000000000000, 0x0800000000000000,
            0x1000000000000000, 0x2000000000000000, 0x4000000000000000, 0x8000000000000000
        };

        public static bool IsBitSet(ulong src, int idx)
        {
            return (src & BitMaskIdx[idx]) > 0 ? true : false;
        }

        public static ulong BitSet(ulong src, int idx)
        {
            return (src | BitMaskIdx[idx]);
        }

        public static ulong BitClr(ulong src, int idx)
        {
            return (src & ~BitMaskIdx[idx]);
        }

        public static ulong BitRangeGet(ulong src, int start, uint len)
        {
            return (src >> start) & BitMasking[len];
        }

        public static ulong BitRangeSet(ulong value, int start, uint len)
        {
            return (value & BitMasking[len]) << start;
        }
    }
}
