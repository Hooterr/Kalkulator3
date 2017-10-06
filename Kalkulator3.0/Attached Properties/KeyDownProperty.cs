using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Kalkulator3
{
    /// <summary>
    /// The NoFrameHistory attached property for creating a <see cref="Frame"/> that never shows navigation
    /// and keeps the navigation history empty
    /// </summary>
    public class KeyDownProperty : BaseAttachedProperty<KeyDownProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // Get the window
            var Window = (sender as Window);
            Window.Loaded += ((ss, ee) => { (ss as Window).Focus(); });
            Window.KeyDown += ((ss, ee) => { MessageBox.Show(ee.Key.ToString()); });

        }
    }
}