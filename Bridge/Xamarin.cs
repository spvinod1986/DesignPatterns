namespace Bridge
{
    public class Xamarin
    {
        protected readonly IMobileDevelopmentKit _framework;

        public Xamarin(IMobileDevelopmentKit framework)
        {
            _framework = framework;
        }
    }
}