using System;

namespace SoundIO
{
    public class InStreamData
    {
        public IntPtr UserData;
        public int BytesPerFrame;

        public unsafe void BeginRead(out ChannelArea* areas, ref int count)
        {
            // TODO how to get Unity microphone input in here?
            areas = null;
        }

        public void EndRead()
        {
        }
    }
}