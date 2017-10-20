using UnitTestProject.Helpers;

namespace UnitTestProject.Factory
{
    class ApplicationFactory
    {

        public CommonHelper commonHelper = new CommonHelper();
        public MainPageHelper mainPageHelper = new MainPageHelper();
        public CustomerPageHelper customerPageHelper = new CustomerPageHelper();
        public AccountPageHelper accountHelper = new AccountPageHelper();
        
    }
}
