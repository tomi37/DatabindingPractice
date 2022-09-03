using DatabindingPractice.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingPractice.Domain.Entities
{
    // 健康診断のデータを想定
    public sealed class MedicalCheckEntity
    {
        public MedicalCheckEntity(
            float height,
            float weight,
            DateTime measureDate)
        {
            Height = new Height(height);
            Weight = new Weight(weight);
            MeasureDate = new MeasureDate(measureDate);
        }

        public Height Height { get; }
        public Weight Weight { get; }
        public string Bmi => Math.Round((Weight.Value / Math.Pow(Height.Value / 100.0f, 2)), 2).ToString();
        public MeasureDate MeasureDate { get; }
    }
}
