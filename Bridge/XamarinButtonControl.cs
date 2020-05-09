namespace Bridge
{
    public class XamarinButtonControl : Xamarin
    {
        public XamarinButtonControl(IMobileDevelopmentKit framework) : base(framework)
        {
        }

        public void AddButton()
        {
            _framework.AddButton();
        }
    }
}