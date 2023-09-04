using Infrastructure.DBInitialize;
using WebUI.Services;

namespace WebUI.StartUp
{
    public class StartUp
    {
        public static Initialize initialize = new();
        public static void Start()
        {
            initialize.Init();
            GlobalManager globalManager = new GlobalManager();
            globalManager.AllManager();
        }
    }
}
