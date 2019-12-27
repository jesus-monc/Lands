namespace Lands.Infrastructure
{
    using ViewModels;
    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main { get; set; }
        #endregion

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }

    }
}
