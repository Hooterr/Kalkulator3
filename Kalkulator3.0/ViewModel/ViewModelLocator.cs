namespace Kalkulator3
{
    /// <summary>
    /// Locates view model from the IoC for use in XAML files
    /// </summary>
    public class ViewModelLocator
    {
        #region Public Properties

        /// <summary>
        /// Singletone instance of the locator
        /// </summary>
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();

        /// <summary>
        /// The appliaction view model
        /// </summary>
        public static ApplicationViewModel ApplicationViewModel => IoC.Application;

        #endregion
    }
}
