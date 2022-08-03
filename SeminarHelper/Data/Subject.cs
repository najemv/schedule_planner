using System;
using System.Collections.Generic;

namespace SeminarHelper
{
    class Subject
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Seminar> Seminars { get; set; }
        public Lecture Lecture { get; set; }

        public Subject(string name, string code, List<Seminar> seminars, Lecture lecture)
        {
            Name = name;
            Code = code;
            Seminars = seminars;
            Lecture = lecture;
        }

        public override string ToString()
        {
            var result = $"{Code} - {Name}" + Environment.NewLine;
            result += (Lecture == null ? "    Bez přednášky" + Environment.NewLine : Lecture.ListPrint()) + Environment.NewLine;
            if (Seminars == null)
            {
                result += "Bez cvičení" + Environment.NewLine;
                return result;
            }

            foreach (var seminar in Seminars)
            {
                result += seminar.ToString();
            }

            return result;
        }


    }
}
