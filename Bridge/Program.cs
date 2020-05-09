using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var iPhoneFramework = new XamarinButtonControl(new IphoneKit());
            iPhoneFramework.AddButton();

            var androidFramework = new XamarinButtonControl(new AndroidKit());
            androidFramework.AddButton();

        }
    }
}
