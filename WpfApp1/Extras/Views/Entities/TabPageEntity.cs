using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Extras.Views
{
    internal class TabPageEntity : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        private bool isVisible = true;
        public bool IsVisible
        {
            get
            {
                return this.isVisible;
            }
            set
            {
                this.isVisible = value;
                NotifyPropertyChanged(nameof(IsVisible));
            }
        }

        private TabPageContentEntity pageContent;
        public TabPageContentEntity PageContent{
            get
            {
                return this.pageContent;
            }
            set
            {
                this.pageContent = value;
                NotifyPropertyChanged(nameof(PageContent));
            }
        }








        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion INotifyPropertyChanged
    }
}
