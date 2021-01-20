using System;

namespace SoundIO
{
    public class Context
    {
        public int InputDeviceCount => 0;
        public int DefaultInputDeviceIndex => 0;
        public OnDevicesChangeDelegate OnDevicesChange;

        public delegate void OnDevicesChangeDelegate(IntPtr context);

        public Device GetInputDevice(int i)
        {
            if (i < 0 || i >= InputDeviceCount) return new Device(null);
            return new Device(null);
        }

        public void FlushEvents()
        {
        }

        public static Context Create()
        {
            return new Context();
        }

        public void Connect()
        {
        }
    }
}