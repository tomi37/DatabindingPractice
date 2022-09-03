using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabindingPractice.WinForm.Helpers
{
    public sealed class CustomMessage : ICustomMessage
    {
        public void OK(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult OKorCancel(string message)
        {
            return MessageBox.Show(message, "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
