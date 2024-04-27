using LiteNinja.Applications;

namespace DefaultNamespace
{
    public class GameApplication : BaseApplication
    {
        private GameApplicationSettings _demoApplicationSettings;
        
        protected override void PreSetup()
        {
            _demoApplicationSettings = _applicationSettings as GameApplicationSettings;
        }

        protected override void BindServices()
        {
            
        }

        protected override void PostSetup()
        {
            
        }
    }
}