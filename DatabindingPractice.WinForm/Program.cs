using DatabindingPractice.WinForm.Exceptions;
using DatabindingPractice.WinForm.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabindingPractice.WinForm
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 例外キャッチ用
            Application.ThreadException += Application_ThreadException;

            Application.Run(new MainView());
        }

        // 意図せず例外が発生したときにキャッチできるように書いておく
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            var exception = e.Exception as ExceptionBase;
            if (exception != null)
            {
                if (exception.ExceptionKind == ExceptionKind.Info)
                {
                    MessageBox.Show(e.Exception.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (exception.ExceptionKind == ExceptionKind.Warning)
                {
                    MessageBox.Show(e.Exception.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (exception.ExceptionKind == ExceptionKind.Error)
                {
                    MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
