using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingPractice.WinForm.Helpers
{
    public sealed class MainViewModelDataGridView
    {
        public MainViewModelDataGridView(string height, string weight, string bmi, string date)
        {
            Height = height;
            Weight = weight;
            Bmi = bmi;
            Date = date;
        }

        public string Height { get; }
        public string Weight { get; }
        public string Bmi { get; }
        public string Date { get; }

    }
}
