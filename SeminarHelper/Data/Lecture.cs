using System;

namespace SeminarHelper
{
    class Lecture
    {
        public string Code { get; set; }
        public string Room { get; set; }
        public int DayOfWeek { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public bool EvenWeek { get; set; }
        public bool OddWeek { get; set; }
        public string Type { get; set;  }

        public Lecture(string code, string room, int dayOfWeek, int start, int end, bool evenWeek, bool oddWeek, string type)
        {
            Code = code;
            Room = room;
            DayOfWeek = dayOfWeek;
            Start = start;
            End = end;
            EvenWeek = evenWeek;
            OddWeek = oddWeek;
            Type = type;
        }

        // full string
        public string ListPrint()
        {
            return $"{PrintHelper.Periodicity(EvenWeek, OddWeek)} {PrintHelper.DayToString(DayOfWeek)} v {PrintHelper.TimeToString(Start, End)} ve  {Room}" + Environment.NewLine;
        }

        // simplified string for table
        public string TablePrint()
        {
            return $"{Code} - ve  {Room}" + Environment.NewLine;
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Lecture other = (Lecture) obj;
                return Code == other.Code;
            }
        }
    }
}
