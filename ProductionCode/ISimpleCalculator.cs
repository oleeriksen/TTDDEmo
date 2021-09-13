using System;
namespace ProductionCode
{
    public interface ISimpleCalculator
    {
        int X { get; set; }
        int Y { get; set; }

        int Add { get; }
        int Sub { get; }
        int Div { get; }

        void Swap();
    }
}
