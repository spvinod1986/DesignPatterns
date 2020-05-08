namespace Bridge
{
    public class IphoneKit : IMobileDevelopmentKit
    {
        // Create instance of IPhone development framework using constructor
        public void AddButton()
        {
            System.Console.WriteLine("Created IOS Button Control");
        }
        public void AddCheckBox()
        {
            System.Console.WriteLine("Created IOS CheckBox Control");
        }
        public void AddLabel()
        {
            System.Console.WriteLine("Created IOS Label Control");
        }
    }
}
