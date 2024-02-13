using DeleeRefreshMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleeRefreshMonkey.ViewModels
{
    public class MonkeyDetailViewModel
    {
        [QueryProperty(nameof(SelectedMonkey), "selectedMonkey")]
        public class StudentDetailViewModel : ViewModelBase
        {
            private Monkey selectedMonkey;
            public Monkey SelectedMonkey
            {
                get
                {
                    return this.selectedMonkey;
                }
                set
                {
                    this.selectedMonkey = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
