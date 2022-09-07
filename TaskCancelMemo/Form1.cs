using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace TaskCancelTest
{
    public partial class Form1 : Form
    {
        private static CancellationTokenSource tokenSource = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (tokenSource == null)
            {
                tokenSource = new CancellationTokenSource();
                var token = tokenSource.Token;
                StartButton.Text = "Hold";
                TestMethod(StartButton, token);
            }
            else
            {
                // 止める前に確認しない
                tokenSource.Cancel();
            }
        }

        private void TestMethod(System.Windows.Forms.Control c, CancellationToken token)
        {
            HeavyMethodDelegate d = new HeavyMethodDelegate(HeavyMethod2);
            Task.Run(() => d(token), token).ContinueWith(t =>
            {
                tokenSource.Dispose();
                tokenSource = null;
                textBox1.Invoke((MethodInvoker)(() =>
                {
                    c.Text = "Start";
                }));
                Trace.WriteLine("completed");
            });
        }

        delegate void HeavyMethodDelegate(CancellationToken token);

        void HeavyMethod(CancellationToken token)
        {
            for (int i = 0; i < 5; i++)
            {
                if (token.IsCancellationRequested) break;

                textBox1.Invoke((MethodInvoker)(() =>
                {
                    textBox1.AppendText(i.ToString() + "\r\n");
                }));

                Thread.Sleep(1000);
            }
        }

        void HeavyMethod2(CancellationToken token)
        {
            for (int i = 0; i < 5; i--)
            {
                if (token.IsCancellationRequested) break;

                textBox1.Invoke((MethodInvoker)(() =>
                {
                    textBox1.AppendText(i.ToString() + "\r\n");
                }));

                Thread.Sleep(1000);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // 止める前に確認を入れる
            StopMeasure();
        }
    
        private void StopMeasure()
        {
            var dialogResult = MessageBox.Show("測定停止？", "確認", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                if (tokenSource != null)
                {
                    tokenSource.Cancel();
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearComponent(textBox1);
        }

        private void ClearComponent(System.Windows.Forms.Control c)
        {
            if (c.Text != "")
            {
                var dialogResult = MessageBox.Show("削除しますか？", "確認", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    c.Text = "";
                }
            }
        }
    }
}
