using WpfApp1.Extras.Views;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    /// <summary>
    /// UIに特化したクラス
    /// View⇔Modelの橋渡し役
    /// </summary>
    internal class MainWindowViewModel
    {
        #region Properties
        /// <summary>処理に特化したモデル</summary>
        public Model Model{ get;set; }



        /// <summary>イベント処理（コマンド）</summary>
        public AddValueCommand AddValueCommand { get; set; }

        /// <summary>イベント処理（コマンド）</summary>
        public SwitchBindableCommand SwitchBindableCommand { get; set; }



        /// <summary>イベント処理（拡張コマンド）</summary>
        public EnterFocusCommand EnterFocusCommand { get; set; }
        /// <summary>イベント処理（拡張コマンド）</summary>
        public LostFocusCommand LostFocusCommand { get; set; }
        #endregion



        /// <summary>コンストラクタ</summary>
        public MainWindowViewModel()
        {
            this.Model = new Model();
            
            this.AddValueCommand = new AddValueCommand(this);
            this.SwitchBindableCommand = new SwitchBindableCommand();

            this.EnterFocusCommand = new EnterFocusCommand(this);
            this.LostFocusCommand = new LostFocusCommand(this);

            this.Model.SetTimer();

            this.Model.Data.LabelTextTitle = "たいとる";
            this.Model.Data.LabelTextContent = "こんてんと";

            this.Model.Data.TabPageEntities = this.Model.GetData();
            foreach(var tabPageEntity in this.Model.Data.TabPageEntities)
            {
                tabPageEntity.PageContent.ShowDetailAction = new GenericCommand()
                {
                    GenericAction = this.Model.ShowTabPageDetailAction,
                };
            }

            // ↓双方向バインドしているため、以下のような記述は不要
            //xaml.textbox1.Text = this.Model.Data.ValueAdded;
        }
    }
}
