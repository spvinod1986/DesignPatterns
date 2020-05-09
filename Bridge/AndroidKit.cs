using System;

namespace Bridge
{
    public class AndroidKit : IMobileDevelopmentKit
    {
        // Create instance of Android development framework using constructor
        public void AddButton()
        {
            System.Console.WriteLine("Created Android Button Control");
        }
        public void AddCheckBox()
        {
            throw new NotImplementedException();
        }
        public void AddLabel()
        {
            throw new NotImplementedException();
        }
    }
}
