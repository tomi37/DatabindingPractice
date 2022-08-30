using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

namespace DatabindingPractice.WinForm.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected Dispatcher Dispacher { get; set; }


        protected bool SetProperty<T>(ref T field,
            T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }

            field = value;
            var h = this.PropertyChanged;
            if (h != null)
            {
                if (Dispacher != null)
                {
                    Dispacher.Invoke(() => h(this, new PropertyChangedEventArgs(propertyName)));
                }
                else
                {
                    h(this, new PropertyChangedEventArgs(propertyName));
                }
            }

            return true;
        }
    }
}
