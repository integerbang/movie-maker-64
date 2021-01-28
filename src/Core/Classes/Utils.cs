using System;
using System.Runtime.InteropServices;

namespace MovieMaker64.Core
{
    public class Utils
    {
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.ThisCall)]
        public unsafe static extern bool ReadProcessMemory(IntPtr hProcess, long* lpBaseAddress, byte[] lpBuffer, long nSize, ref long lpNumberOfBytesRead);
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.ThisCall)]
        public unsafe static extern bool WriteProcessMemory(IntPtr hProcess, long* lpBaseAddress, byte[] lpBuffer, long nSize, ref long lpNumberOfBytesWritten);

        public static unsafe byte[] ReadBytes(long _address, long _size, IntPtr _handle, bool _swap_endianess)
        {
            long* _pointer = (long*)_address;
            byte[] _buffer = new byte[_size];
            long _bytes_read = default;

            ReadProcessMemory(_handle, _pointer, _buffer, _size, ref _bytes_read);

            if (_swap_endianess)
                Array.Reverse(_buffer);

            return _buffer;
        }

        public static unsafe void WriteBytes(long _address, byte[] _data, IntPtr _handle, bool _swap_endianess)
        {
            long* _pointer = (long*)_address;
            long _bytes_read = 0;

            if (_swap_endianess)
                Array.Reverse(_data);

            WriteProcessMemory(_handle, _pointer, _data, _data.LongLength, ref _bytes_read);
        }

        public static long ResolveBaseAddress(IntPtr _handle)
        {
            long step = 0x1000;
            long stop = 0x60000000;

            for (long _scan_address = 0; _scan_address < stop - step; _scan_address += step)
            {
                uint value = BitConverter.ToUInt32(ReadBytes(_scan_address, sizeof(uint), _handle, false), 0);

                if (value == 0x3C1A8032)
                    return _scan_address;
            }

            return 0;
        }
    }
}