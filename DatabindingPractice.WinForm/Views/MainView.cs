using DatabindingPractice.WinForm.Helpers;
using DatabindingPractice.WinForm.ViewModels;
using System.Windows.Forms;
using System.Windows.Threading;

namespace DatabindingPractice.WinForm.Views
{
    public partial class MainView : Form
    {
        private MainViewModel _viewModel = new MainViewModel();

        public MainView()
        {
            InitializeComponent();

            // 起動時の言語を英語にする
            _viewModel.ENRadioButtonChecked = true;

            // ComboBox Binding
            SettingComboBox.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.SettingComboBoxDataSource));
            SettingComboBox.DataBindings.Add("SelectedValue", _viewModel, nameof(_viewModel.SettingComboBoxSelectedValue), false, DataSourceUpdateMode.OnPropertyChanged);
            SettingComboBox.ValueMember = nameof(MainViewModelComboBox.Value);
            SettingComboBox.DisplayMember = nameof(MainViewModelComboBox.DisplayValue);
            SettingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Update
            UpdateButton.Click += (sender, e) => _viewModel.Update();

            // Check
            CheckButton.Click += (sender, e) => _viewModel.Check();

            // Exception Test
            InfoButton.Click += (sender, e) => _viewModel.InfoTest();
            WarningButton.Click += (sender, e) => _viewModel.WarningTest();
            ErrorButton.Click += (sender, e) => _viewModel.ErrorTest();
            ErrorAsyncButton.Click += async (sender, e) => await _viewModel.ErrorTestAsync();

            // Radio Button Binding
            JPRadioButton.DataBindings.Add("Checked", _viewModel, nameof(_viewModel.JPRadioButtonChecked), false, DataSourceUpdateMode.OnPropertyChanged);
            ENRadioButton.DataBindings.Add("Checked", _viewModel, nameof(_viewModel.ENRadioButtonChecked), false, DataSourceUpdateMode.OnPropertyChanged);

            // ラジオボタンで言語を切り替える確認
            ComboGroupBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.ComboGroupBoxText));
            ExceptionGroupBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.ExceptionGroupBoxText));
            LanguageGroupBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.LanguageGroupBoxText));

            // Data Grid View
            MedicalCheckDataGridView.DataSource = _viewModel.MedicalCheckDataGridSource;
            // ヘッダー部分
            MedicalCheckDataGridView.Columns[nameof(MainViewModelDataGridView.Height)].HeaderText = "Height(cm)";
            MedicalCheckDataGridView.Columns[nameof(MainViewModelDataGridView.Weight)].HeaderText = "Weight(kg)";
            MedicalCheckDataGridView.Columns[nameof(MainViewModelDataGridView.Bmi)].HeaderText = "BMI(%)";
            MedicalCheckDataGridView.Columns[nameof(MainViewModelDataGridView.Date)].HeaderText = "Date";
            // 列幅を自動にする
            MedicalCheckDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // 縦横にスクロールバーを表示
            MedicalCheckDataGridView.ScrollBars = ScrollBars.Both;

            // Data Grid Viewにデータを追加する
            GetDataButton.Click += async (sender, e) => await _viewModel.GetData();

            // Data Grid Viewのデータをクリア
            ClearButton.Click += (sender, e) => _viewModel.ClearData();
        }
    }
}
