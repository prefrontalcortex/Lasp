using System;

namespace SoundIO
{
    public class InStream
    {
        public bool IsInvalid;
        public bool IsClosed;
        public ChannelLayout Layout;
        public int SampleRate;
        public Format Format;
        public double SoftwareLatency;
        public ReadCallbackDelegate ReadCallback;
        public OverflowCallbackDelegate OverflowCallback;
        public ErrorCallbackDelegate ErrorCallback;
        public IntPtr UserData;

        public delegate void ReadCallbackDelegate(ref InStreamData stream, int frameCountMin, int frameCountMax);
        public delegate void OverflowCallbackDelegate(ref InStreamData stream);
        public delegate void ErrorCallbackDelegate(ref InStreamData stream, Error error);

        public void Dispose()
        {
        }

        public static InStream Create(Device device)
        {
            return new InStream();
        }

        public Error Open()
        {
            return Error.None;
        }

        public void Start()
        {
        }
    }
}