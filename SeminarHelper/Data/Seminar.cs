using System;
using System.Collections.Generic;

namespace SeminarHelper
{
    class Seminar
    {
        public List<Tutor> Tutors { get; set; }
        public string Code { get; set; }
        public Lecture Lecture { get; set; }
        public string RegistrationLink { get; set; }

        public Seminar(List<Tutor> tutors, string code, Lecture lecture, string registrationLink)
        {
            Tutors = tutors;
            Code = code;
            Lecture = lecture;
            RegistrationLink = registrationLink;
        }

        public override string ToString()
        {
            var result = $"{Code} - " + (Lecture != null ? Lecture.ListPrint() : "Není vypsané cvičení" + Environment.NewLine);
            result += "   ";
            foreach (var tutor in Tutors)
            {
                result += " " + tutor.ToString();
            }
            result += Environment.NewLine;

            return result;
        }

    }
}
