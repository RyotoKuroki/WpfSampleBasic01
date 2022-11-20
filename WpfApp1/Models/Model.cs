using System;
using System.Collections.ObjectModel;
using System.Timers;
using WpfApp1.Datas;
using WpfApp1.Extras.Views;

namespace WpfApp1.Models
{
    /// <summary>
    /// 処理に特化したモデル
    /// </summary>
    internal class Model
    {
        /// <summary>データに特化したモデル</summary>
        public DataModel Data { get; set; }

        /// <summary>コンストラクタ</summary>
        public Model()
        {
            this.Data = new DataModel();
        }

        /// <summary>処理</summary>
        public void AddValue(int param)
        {
            this.Data.ValueAdded = this.Data.ValueAdded + param;
        }

        /// <summary>処理</summary>
        public void SetNow()
        {
            this.Data.ValueBindable = DateTime.Now.ToString();
        }

        public void SetTimer()
        {
            var timer = new Timer(1000);
            // タイマーの処理
            timer.Elapsed += (sender, e) =>
                this.Data.Value01 = DateTime.Now.ToString();

            // タイマーを開始する
            timer.Start();
        }

        public void ShowTabPageDetailAction(object? parameter)
        {
            if (parameter == null)
            {
                throw new NotImplementedException($"コマンドパラメータを正しく実装して下さい。\r\n{Environment.StackTrace}");
            }

            var detail = parameter.ToString();
            System.Windows.MessageBox.Show(detail);
        }

        public ObservableCollection<TabPageEntity> GetData()
        {
            // ex)get from DB.
            var mockDatas = MockData.GetData();
            return mockDatas;
        }
    }
}
