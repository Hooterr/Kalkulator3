using System.Windows;

namespace Kalkulator3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Call the base
            base.OnStartup(e);

            // Setup the main appliaction
            AppliactionSetup();

            // Show the man window
            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();
        }

        /// <summary>
        /// Configures the appliaction ready for use
        /// </summary>
        private void AppliactionSetup()
        {
            IoC.Setup();
        }
    }
}
