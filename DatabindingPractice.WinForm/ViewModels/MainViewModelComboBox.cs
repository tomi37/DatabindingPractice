namespace DatabindingPractice.WinForm.ViewModels
{
    /// <summary>
    /// ComboBox用カスタムクラス
    /// </summary>
    public sealed class MainViewModelComboBox
    {
        public MainViewModelComboBox(int value, string displayValue)
        {
            Value = value;
            DisplayValue = displayValue;
        }

        public int Value { get; }
        public string DisplayValue { get; }
    }
}
