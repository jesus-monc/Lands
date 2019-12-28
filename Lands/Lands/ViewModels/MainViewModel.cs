namespace Lands.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login { get; set; }
        #endregion

        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
    }
}
