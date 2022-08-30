using System.ComponentModel;
using System.Windows.Threading;

namespace DatabindingPractice.WinForm.Helpers
{
    /// <summary>
    /// 非同期で実行してもUI上にスレッドを戻す
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class BindingListAsync<T> : BindingList<T>
    {
        private Dispatcher _dispacher;

        public BindingListAsync(Dispatcher dispatcher)
        {
            _dispacher = dispatcher;
        }

        protected override void OnListChanged(ListChangedEventArgs e)
        {
            _dispacher.Invoke(() => base.OnListChanged(e));
        }
    }
}
