namespace Singleton
{
    public class UniqueManager
    {
        static UniqueManager _instance;

        public static UniqueManager GetInstance()
        {
            if (_instance == null)
                _instance = new UniqueManager();

            return _instance;
        }

        private UniqueManager()
        {
            
        }
    }
}