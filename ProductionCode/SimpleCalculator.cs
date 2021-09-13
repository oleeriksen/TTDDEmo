using System;
namespace ProductionCode
{
    public class SimpleCalculator : ISimpleCalculator
    {
        public SimpleCalculator()
        {
        }

        public int X { get; set; }
        public int Y { get; set; }

        public int Add { get { return X+Y;  }  } 

        public int Sub { get { return X-Y; } }

        public int Div { get {
                                if (Y == 0) throw new Exception();

                                return (int)Math.Round((Double)X / Y);
               
                             }
                       }

        public void Swap()
        {
            X = X + Y;
            Y = X - Y;
            X = X - Y;
        }
    }
}
