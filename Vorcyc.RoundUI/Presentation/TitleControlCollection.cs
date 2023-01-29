using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Vorcyc.RoundUI.Presentation
{
    public class TitleControlCollection : ObservableCollection<FrameworkElement>
    {
        public TitleControlCollection() { }

        public TitleControlCollection(IEnumerable<FrameworkElement> controls)
        {
            if (controls == null)
                throw new ArgumentNullException("controls");

            foreach (var ctrl in controls)
                Add(ctrl);
        }

    }
}
