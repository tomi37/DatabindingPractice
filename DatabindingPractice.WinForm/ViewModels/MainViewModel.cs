using DatabindingPractice.Domain.Entities;
using DatabindingPractice.WinForm.Exceptions;
using DatabindingPractice.WinForm.Helpers;
using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace DatabindingPractice.WinForm.ViewModels
{
    public sealed class MainViewModel : ViewModelBase
    {
        private ICustomMessage _message;

        public MainViewModel()
            : this(Dispatcher.CurrentDispatcher, new CustomMessage())
        {
        }

        public MainViewModel(Dispatcher dispatcher, ICustomMessage message)
        {
            base.Dispacher = dispatcher;
            
            SettingComboBoxDataSource = new BindingListAsync<MainViewModelComboBox>(dispatcher);
            SettingComboBoxDataSource.Add(new MainViewModelComboBox(1, "111"));
            SettingComboBoxDataSource.Add(new MainViewModelComboBox(2, "222"));
            SettingComboBoxDataSource.Add(new MainViewModelComboBox(3, "333"));
            _message = message;

            MedicalCheckDataGridSource = new BindingListAsync<MainViewModelDataGridView>(dispatcher);
        }

        // ComboBox Data Source
        private object _settingComboBoxSelectedValue;

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

        // Radio Button
        private bool _jpRadioButtonChecked = false;
        public bool JPRadioButtonChecked
        {
            get { return _jpRadioButtonChecked; }
            set
            {
                SetProperty(ref _jpRadioButtonChecked, value);
                if (value)
                {
                    SetProperty(ref _enRadioButtonChecked, false, nameof(ENRadioButtonChecked));
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja-JP");
                    ChangeLanguage();
                }
            }
        }

        private bool _enRadioButtonChecked = false;
        public bool ENRadioButtonChecked
        {
            get { return _enRadioButtonChecked; }
            set
            {
                SetProperty(ref _enRadioButtonChecked, value);
                if (value)
                {
                    SetProperty(ref _jpRadioButtonChecked, false, nameof(JPRadioButtonChecked));
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
                    ChangeLanguage();
                }
            }
        }

        // 言語切り替え確認
        private string _comboGroupBoxText = Properties.Resources.ComboBoxTest;
        public string ComboGroupBoxText
        {
            get { return _comboGroupBoxText; }
            set { SetProperty(ref _comboGroupBoxText, value); }
        }

        private string _exceptionGroupBoxText = Properties.Resources.ExceptionTest;
        public string ExceptionGroupBoxText
        {
            get { return _exceptionGroupBoxText; }
            set { SetProperty(ref _exceptionGroupBoxText, value); }
        }

        private string _languageGroupBoxText = Properties.Resources.SelectLanguage;
        public string LanguageGroupBoxText
        {
            get { return _languageGroupBoxText; }
            set { SetProperty(ref _languageGroupBoxText, value); }
        }

        // データグリッド
        public BindingListAsync<MainViewModelDataGridView> MedicalCheckDataGridSource { get; set; }

        // データ生成（本来はファイルやデータベースからとってくる）
        public async Task GetData()
        {
            var rand = new Random();
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    var height = (float)(rand.NextDouble() * 100 + 100); // 100cm ~ 200cm間のランダム値
                    var width = (float)(rand.NextDouble() * 50 + 50); // 50kg ~ 100kg間のランダム値
                    var date = DateTime.Now;
                    var rowdata = new MedicalCheckEntity(height, width, date.AddDays(i));
                    MedicalCheckDataGridSource.Add(new MainViewModelDataGridView(
                        rowdata.Height.DisplayValue,
                        rowdata.Weight.DisplayValue,
                        rowdata.Bmi,
                        rowdata.MeasureDate.DisplayValue));
                    System.Threading.Thread.Sleep(1000);
                }
            });
        }

        public void ClearData()
        {
            MedicalCheckDataGridSource.Clear();
        }

        public void ChangeLanguage()
        {
            ComboGroupBoxText = Properties.Resources.ComboBoxTest;
            ExceptionGroupBoxText = Properties.Resources.ExceptionTest;
            LanguageGroupBoxText = Properties.Resources.SelectLanguage;
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

        public void InfoTest()
        {
            // 自作のInfoExceptionの確認
            // Info用のアイコン
            throw new InputException("Info Message!");
        }

        public void WarningTest()
        {
            // 自作のWarningExceptionの確認
            // Warning用のアイコン
            throw new WarningException("Warning Message!");
        }

        public void ErrorTest()
        {
            // .NET標準のExceptionの確認
            // Error用のアイコン
            throw new ArgumentException("Error Message!");
        }

        public async Task ErrorTestAsync()
        {
            // 非同期でもちゃんとメッセージが表示されることを確認
            await Task.Run(() =>
            {
                throw new InputException("Error Async Message!");
            });
        }
    }
}
