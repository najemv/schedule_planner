namespace SeminarHelper
{
    class Tutor
    {
        public string Name { get; set; }
        public Score Score { get; set; }
        
        public Tutor(string name, Score score)
        {
            Name = name;
            Score = score;
        }

        public override string ToString()
        {
            return $"{Name} - {Score}";
        }
    }
}
