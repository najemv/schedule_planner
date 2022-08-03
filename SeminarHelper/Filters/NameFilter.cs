using System.Collections.Generic;

namespace SeminarHelper
{
    class NameFilter
    {
        public List<string> Names { get; set; } = new();

        /* For a given subject, return list of its seminar groups.
         * If some of its seminar groups are teached by favorite teachers, return only these seminar groups.
         * Otherwise returns all seminar groups.
         */
        public List<Seminar> Filter(Subject subject)
        {
            var seminars = subject.Seminars;
            var filterdSeminars = new List<Seminar>();
            foreach (var seminar in seminars)
            {
                if (CheckSeminar(seminar))
                {
                    filterdSeminars.Add(seminar);
                }
            }

            if (filterdSeminars.Count == 0)
            {
                return seminars;
            }

            return filterdSeminars;

        }

        private bool CheckName(string tutorName)
        {
            foreach (var name in Names)
            {
                if (tutorName.ToLower().Contains(name))
                    return true;
            }

            return false;
        }

        private bool CheckSeminar(Seminar seminar)
        {
            foreach (var tutor in seminar.Tutors)
            {
                foreach (var name in Names)
                {
                    if (CheckName(tutor.Name))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
