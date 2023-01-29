using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Vorcyc.RoundUI.Presentation
{
    /// <summary>
    /// Provides a base implementation for objects that are displayed in the UI.
    /// </summary>
    public abstract class Displayable
        : NotifyPropertyChanged
    {
        private string displayName;

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName
        {
            get { return this.displayName; }
            set
            {
                if (this.displayName != value)
                {
                    this.displayName = value;
                    OnPropertyChanged("DisplayName");
                }
            }
        }




        //public string DisplayName
        //{
        //    get { return (string)GetValue(DisplayNameProperty); }
        //    set { SetValue(DisplayNameProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for DisplayName.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty DisplayNameProperty =
        //    DependencyProperty.Register("DisplayName", typeof(string), typeof(Displayable), new PropertyMetadata(null));


    }
}
