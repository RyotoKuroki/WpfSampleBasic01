using System.Collections.ObjectModel;
using WpfApp1.Extras.Views;

namespace WpfApp1.Datas
{
    internal class MockData
    {
        public static ObservableCollection<TabPageEntity> GetData()
        {
            var index = 0;
            return new ObservableCollection<TabPageEntity>()
            {
                new TabPageEntity()
                {
                    IsVisible = false, /* 非表示 */
                    Name = "へっだあ-１",
                    PageContent = new TabPageContentEntity
                    {
                        Index = ++index,
                        Age = 10,
                        SexType = Definitions.Enums.SexTypes.Male,
                        Hobbies = new ObservableCollection<string>() {
                            "なし",
                        },
                    },
                },
                new TabPageEntity()
                {
                    IsVisible = false, /* 非表示 */
                    Name = "へっだあ-２",
                    PageContent = new TabPageContentEntity
                    {
                        Index = ++index,
                        Age = 20,
                        SexType = Definitions.Enums.SexTypes.FeMale,
                        Hobbies = new ObservableCollection<string>() {
                            "ゲーム",
                            "ツーリング",
                        },

                    },
                },
                new TabPageEntity()
                {
                    IsVisible = true,
                    Name = "へっだあ-３",
                    PageContent=new TabPageContentEntity()
                    {
                        Index = ++index,
                        Age = 30,
                        SexType = Definitions.Enums.SexTypes.Male,
                        Hobbies = new ObservableCollection<string>() {
                            "ゲーム",
                            "ツーリング",
                            "釣り",
                        },
                    },
                },
                new TabPageEntity()
                {
                    IsVisible = true,
                    Name = "へっだあ-４",
                    PageContent = new TabPageContentEntity()
                    {
                        Index = ++index,
                        Age = 40,
                        SexType = Definitions.Enums.SexTypes.FeMale,
                        Hobbies = new ObservableCollection<string>() {
                            "ゲーム",
                            "ツーリング",
                            "釣り",
                            "登山",
                            "ショッピング",
                            "ネットサーフィン",
                            "映画鑑賞",
                            "読書",
                            "昼寝",
                        },
                    },
                },
            };

        }
    }
}
