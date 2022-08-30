using DatabindingPractice.WinForm.Helpers;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Threading;

namespace DatabindingPractice.WinForm.ViewModels
{
    public sealed class MainViewModel : ViewModelBase
    {
        private object _settingComboBoxSelectedValue;

        public MainViewModel(Dispatcher dispatcher)
        {
            base.Dispacher = dispatcher;

            SettingComboBoxDataSource = new BindingListAsync<MainViewModelComboBox>(dispatcher);
            SettingComboBoxDataSource.Add(new MainViewModelComboBox(1, "111"));
            SettingComboBoxDataSource.Add(new MainViewModelComboBox(2, "222"));
            SettingComboBoxDataSource.Add(new MainViewModelComboBox(3, "333"));
            
        }

        // ComboBox Data Source
        public BindingListAsync<MainViewModelComboBox> SettingComboBoxDataSource { get; set; }

        // ComboBox Selected Item
        public MainViewModelComboBox SettingComboBoxSelectedItem { get; set; }

        // ComboBox 選択アイテムを変更したときはSettingComboBoxSelectedItemを更新する
        public object SettingComboBoxSelectedValue
        {
            get { return _settingComboBoxSelectedValue; }
            set
            {
                SetProperty(ref _settingComboBoxSelectedValue, value);
                SettingComboBoxSelectedItem = SettingComboBoxDataSource.FirstOrDefault(x => x.Value == (int)value);
            }
        }

        public void Update()
        {
            SettingComboBoxDataSource.Add(new MainViewModelComboBox(100, "Update Data!"));
        }

        public void Check()
        {
            string str = SettingComboBoxSelectedItem.DisplayValue.ToString();
            MessageBox.Show(str);
        }
    }
}
