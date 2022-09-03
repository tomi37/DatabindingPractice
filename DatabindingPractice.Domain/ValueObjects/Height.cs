using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingPractice.Domain.ValueObjects
{
    public sealed class Height : ValueObject<Height>
    {
        public Height(float value)
        {
            Value = value;
        }

        public float Value { get; }

        public string DisplayValue => Math.Round(Value, 2).ToString();

        protected override bool EqualsCore(Height other)
        {
            return this.Value == other.Value;
        }
    }
}
