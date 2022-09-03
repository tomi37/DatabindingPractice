using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabindingPractice.WinForm.Helpers
{
    public interface ICustomMessage
    {
        void OK(string message);

        DialogResult OKorCancel(string message);
    }
}
