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
            System.Console.WriteLine("Created Android CheckBox Control");
        }
        public void AddLabel()
        {
            System.Console.WriteLine("Created Android Label Control");
        }
    }
}
