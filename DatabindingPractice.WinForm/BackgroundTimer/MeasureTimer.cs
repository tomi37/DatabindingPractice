using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace DatabindingPractice.WinForm.BackgroundTimer
{
    internal static class MeasureTimer
    {
        private static System.Threading.Timer _timer;

        private static bool _isWork;

        private static int _count = 0;

        private static int _currentCount = 0;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        static MeasureTimer()
        {
            _timer = new System.Threading.Timer(Callback);
        }

        internal static void Start(int count)
        {
            _timer.Change(0, 100);
            _currentCount = 0;
            _count = count;
        }

        internal static void Stop()
        {
            _timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        /// <summary>
        /// コールバック
        /// </summary>
        /// <param name="o">オブジェクト</param>
        internal static void Callback(object o)
        {
            if (_isWork)
            {
                return;
            }

            try
            {
                _isWork = true;
                if (_currentCount < _count)
                {
                    Trace.WriteLine(DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss.fff"));
                    Trace.WriteLine(_currentCount.ToString());
                    Thread.Sleep(5000);
                    _currentCount++;
                }
                else
                {
                    Stop();
                }
            }
            finally
            {
                _isWork = false;
            }
        }
    }
}
