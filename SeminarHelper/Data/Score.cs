namespace SeminarHelper
{
    class Score
    {
        public double Explanation { get; set; } = 0.0;
        public double Preparedness { get; set; } = 0.0;
        public double Communication { get; set; } = 0.0;
        public double GreatPedagog { get; set; } = 0.0;

        public Score(double explanation, double preparedness, double communication, double greatPedagog)
        {
            Explanation = explanation;
            Preparedness = preparedness;
            Communication = communication;
            GreatPedagog = greatPedagog;
        }

        public double Average()
        {
            return (Explanation + Preparedness + Communication + GreatPedagog) / 4;
        }

        public override string ToString()
        {
            return $"({Explanation}, {Preparedness}, {Communication}, {GreatPedagog})";
        }


    }
}
