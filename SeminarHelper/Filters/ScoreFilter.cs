namespace SeminarHelper
{
    class ScoreFilter
    {
        public double WorstScore { get; set; } = 2.0;
        
        /* Returns true, if at least one tutor has better score than set worst score.
         * If tutors has no set score, it always pass.
         */
        public bool Pass(Seminar seminar)
        {
            foreach (var tutor in seminar.Tutors)
            {
                if (tutor.Score.Average() < WorstScore)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
