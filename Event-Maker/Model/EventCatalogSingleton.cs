namespace Event_Maker.Model
{
    public class EventCatalogSingleton
    {
        private static EventCatalogSingleton _instance = null;

        private EventCatalogSingleton()
        {
            
        }

        public static EventCatalogSingleton GetInstance()
        {
            if (_instance != null)
                return _instance;
            else
            {
                _instance = new EventCatalogSingleton();
                return _instance;
            }
        }
    }
}