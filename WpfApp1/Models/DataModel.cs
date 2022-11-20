using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using WpfApp1.Extras.Views;

namespace WpfApp1.Models
{
    /// <summary>
    /// データに特化したモデル
    /// </summary>
    internal class DataModel : INotifyPropertyChanged
    {
        internal DataModel()
        {
        }

        public string WindowTitle { get; set; } = "WPFサンプル（基本編01）";

        public SolidColorBrush Brush01 { get; set; } = Brushes.Blue;

        public SolidColorBrush Brush02 { get; set; } = Brushes.Red;

        private string value01 = "Value01";
        public string Value01 {
            get
            {
                return this.value01;
            }
            set
            { 
                this.value01 = value;
                NotifyPropertyChanged(nameof(Value01));
            }
        }

        private int valueAdded = 3;
        public int ValueAdded
        {
            get
            {
                return this.valueAdded;
            }
            set
            {
                this.valueAdded = value;
                NotifyPropertyChanged(nameof(ValueAdded));
            }
        }

        private string valueAddedUpDown = string.Empty;
        public string ValueAddedUpDown
        {
            get
            {
                return this.valueAddedUpDown;
            }
            set
            {
                this.valueAddedUpDown = value;
                NotifyPropertyChanged(nameof(ValueAddedUpDown));
            }
        }

        private string valueBindable = "NotifyPropertyChanged";
        public string ValueBindable
        {
            get
            {
                return this.valueBindable;
            }
            set
            {
                this.valueBindable = value;
                if (this.IsBindable)
                    NotifyPropertyChanged(nameof(ValueBindable));
            }
        }

        private bool isBindable = true;

        public bool IsBindable
        {
            get
            {
                return isBindable;
            }
            set
            {
                isBindable = value;
                NotifyPropertyChanged(nameof(IsBindable));
            }
        }

        private string someValue = string.Empty;
        public string SomeValue
        {
            get
            {
                return this.someValue;
            }
            set
            {
                this.someValue = value;
                NotifyPropertyChanged(nameof(SomeValue));
            }
        }

        private string labelTextTitle = string.Empty;
        public string LabelTextTitle
        {
            get
            {
                return this.labelTextTitle;
            }
            set
            {
                this.labelTextTitle = value;
                NotifyPropertyChanged(nameof(LabelTextTitle));
            }
        }

        private string labelTextContent = string.Empty;
        public string LabelTextContent
        {
            get
            {
                return this.labelTextContent;
            }
            set
            {
                this.labelTextContent = value;
                NotifyPropertyChanged(nameof(LabelTextContent));
            }
        }

        public string PlaceholderText { get; set; } = "拾い物のプレースホルダーサンプル（DependencyProperty）";

        private ObservableCollection<TabPageEntity> tabPageEntities = new ObservableCollection<TabPageEntity>();
        public ObservableCollection<TabPageEntity> TabPageEntities
        {
            get
            {
                return this.tabPageEntities;
            }
            set
            {
                this.tabPageEntities = value;
                NotifyPropertyChanged(nameof(TabPageEntities));
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
