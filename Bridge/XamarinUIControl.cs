namespace Bridge
{
    public class XamarinUIControl : Xamarin
    {
        public XamarinUIControl(IMobileDevelopmentKit framework) : base(framework)
        {
        }

        public void AddButton()
        {
            _framework.AddButton();
        }
        public void AddCheckBox()
        {
            _framework.AddCheckBox();
        }
        public void AddLabel()
        {
            _framework.AddLabel();
        }
    }
}