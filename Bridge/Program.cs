using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var iPhoneFramework = new XamarinUIControl(new IphoneKit());
            iPhoneFramework.AddButton();
            iPhoneFramework.AddCheckBox();
            iPhoneFramework.AddLabel();
            
            var androidFramework = new XamarinUIControl(new AndroidKit());
            androidFramework.AddButton();
            androidFramework.AddCheckBox();
            androidFramework.AddLabel();
        }
    }
}
