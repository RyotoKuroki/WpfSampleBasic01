using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static WpfApp1.Definitions.Enums;

namespace WpfApp1.Extras.Views
{
    internal class TabPageContentEntity : INotifyPropertyChanged
    {
        private GenericCommand showDetailAction { get; set; }
        public GenericCommand ShowDetailAction
        {
            get
            {
                return this.showDetailAction;
            }
            set
            {
                this.showDetailAction = value;
                NotifyPropertyChanged(nameof(ShowDetailAction));
            }
        }

        private int index;
        public int Index
        {
            get
            {
                return this.index;
            }
            set
            {
                this.index = value;
                NotifyPropertyChanged(nameof(Index));
            }
        }

        private int age;
        public int Age {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
                NotifyPropertyChanged(nameof(Age));
            }
        }

        private SexTypes sexType;

        public SexTypes SexType
        {
            get
            {
                return this.sexType;
            }
            set
            {
                this.sexType = value;
                NotifyPropertyChanged(nameof(SexType));
            }
        }

        private ObservableCollection<string> hobbies = new ObservableCollection<string>();
        public ObservableCollection<string> Hobbies
        {
            get
            {
                return this.hobbies;
            }
            set
            {
                this.hobbies = value;
                NotifyPropertyChanged(nameof(Hobbies));
            }
        }

        public string Detail
        {
            get
            {
                var text = string.Empty;
                text += $"{nameof(this.Index)}：{this.Index}\r\n";
                text += $"{nameof(this.Age)}：{this.Age}\r\n";
                text += $"{nameof(this.SexType)}：{this.SexType}\r\n";
                text += $"{nameof(this.Hobbies)}：\r\n";
                text += $"--------------------------------------\r\n";
                text += $"　{string.Join("\r\n　", this.Hobbies)}\r\n";
                text += $"--------------------------------------\r\n";
                return text;
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
