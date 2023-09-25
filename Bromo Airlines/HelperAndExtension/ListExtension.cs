using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bromo_Airlines.HelperAndExtension
{
    public static class ListExtension
    {
        public static BindingList<T> ToBindingList<T>(this List<T> list) where T : class
        {
            return new ObservableCollection<T>(list).ToBindingList();
        }
    }
}
