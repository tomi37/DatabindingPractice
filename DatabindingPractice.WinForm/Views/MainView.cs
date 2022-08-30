using DatabindingPractice.WinForm.ViewModels;
using System.Windows.Forms;
using System.Windows.Threading;

namespace DatabindingPractice.WinForm.Views
{
    public partial class MainView : Form
    {
        private MainViewModel _viewModel = new MainViewModel(Dispatcher.CurrentDispatcher);

        public MainView()
        {
            InitializeComponent();

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
        }
    }
}
