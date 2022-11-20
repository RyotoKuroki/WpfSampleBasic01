using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.Extras.Views
{
    /// <summary>
    /// LabelText.xaml の相互作用ロジック
    /// </summary>
    public partial class LabelText : UserControl
    {
        #region Title
        /// <summary>
        /// 依存関係プロパティ
        /// </summary>
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
            nameof(Title),
            typeof(string),
            typeof(LabelText),
            new PropertyMetadata(null, OnPropertyChanged));
        public string Title { get; set; }
        #endregion

        #region Content
        /// <summary>
        /// 依存関係プロパティ
        /// </summary>
        public static readonly DependencyProperty ContentProperty = DependencyProperty.Register(
            nameof(Content),
            typeof(string),
            typeof(LabelText),
            new PropertyMetadata(null, OnPropertyChanged));
        public string Content { get; set; }
        #endregion

        public LabelText()
        {
            InitializeComponent();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void OnPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            switch(e.Property.Name)
            {
                case nameof(Title):
                    break;
                case nameof(Content):
                    break;
                default:
                    break;
            }
        }
    }
}
