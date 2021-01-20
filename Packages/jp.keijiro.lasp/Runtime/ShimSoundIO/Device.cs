using System;

namespace SoundIO
{
    public class  Device
    {
        public string Name;
        public double SoftwareLatencyMin;
        public bool IsRaw => false;

        public Device(string device)
        {
            Layouts = new ChannelLayout[]{ new ChannelLayout()};
            ID = device;
            Name = device;
            SoftwareLatencyMin = 0;
            SampleRates = new int[] {44100};
        }

        public ChannelLayout[] Layouts;
        public int[] SampleRates;
        public string ID { get; set; }

        public void Dispose()
        {
        }
    }
}