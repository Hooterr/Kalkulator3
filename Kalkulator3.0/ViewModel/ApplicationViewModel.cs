using System.Windows;
using System.Windows.Input;

namespace Kalkulator3
{
    /// <summary>
    /// A view model for the appliaction
    /// </summary>
    public class ApplicationViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The main display content
        /// </summary>
        public string MainDisplay { get; set; }

        /// <summary>
        /// The calculator history display
        /// </summary>
        public string HistoryDisplay { get; set; }

        #endregion

        public void KeyDown(Key key)
        {
            MainDisplay = key.ToString();
        }
            
    }
}
