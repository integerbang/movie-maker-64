using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MovieMaker64.Core
{
    public class Session
    {
        public bool CameraIsFrozen;
        public bool CameraIsSoftFrozen;

        public byte CameraState { get => Emulator.Read<byte>(0x33C84B); set => Emulator.Write(0x33C84B, value); }
        public byte[] SoftCameraState { get => Emulator.Read(0x33B204, 4, true); set => Emulator.Write(0x33B204, value); }

        public short InternalCourseID { get => BitConverter.ToInt16(Emulator.Read(0x32DDFA, 2), 0); }

        public Stream Emulator { get; set; }
    }

    public class Stream
    {
        public bool AttachedProcessIsRunning => (AttachedProcess != null && !AttachedProcess.HasExited);

        public IntPtr AttachedProcessHandle { get => AttachedProcess.Handle; }
        public long AttachedProcessBaseAddress { get; private set; }
        public Process AttachedProcess { get; private set; }

        public Stream(int _pid)
        {
            AttachedProcess = Process.GetProcessById(_pid);
            AttachedProcessBaseAddress = FetchBaseAddress();
        }

        public long FetchBaseAddress() => Utils.ResolveBaseAddress(AttachedProcessHandle);
        public void RefetchBaseAddress() => AttachedProcessBaseAddress = FetchBaseAddress();

        public unsafe T Read<T>(long _address, bool _swap_endianess = false) =>
            Unsafe.ReadUnaligned<T>(ref Utils.ReadBytes(AttachedProcessBaseAddress + _address,
                Unsafe.SizeOf<T>(), AttachedProcessHandle, _swap_endianess)[0]);

        public byte[] Read(long _address, long _size, bool _swap_endianess = false) =>
            Utils.ReadBytes(AttachedProcessBaseAddress + _address, _size, AttachedProcessHandle, _swap_endianess);

        public unsafe void Write<T>(long _address, T _object, bool _swap_endianess = false)
        {
            var _array = new byte[Unsafe.SizeOf<T>()];
            Unsafe.As<byte, T>(ref _array[0]) = _object;

            Utils.WriteBytes(AttachedProcessBaseAddress + _address, _array, AttachedProcessHandle, _swap_endianess);
        }

        public void Write(long _address, byte[] _data, bool _swap_endianess = false) =>
            Utils.WriteBytes(AttachedProcessBaseAddress + _address, _data, AttachedProcessHandle, _swap_endianess);
    }
}