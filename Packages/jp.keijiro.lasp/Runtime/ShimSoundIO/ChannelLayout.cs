using System;

namespace SoundIO
{
    public class ChannelLayout
    {
        public int ChannelCount;
    }
    
    public struct ChannelArea
    {
        public IntPtr Pointer;
        public int Step;
    }
}
