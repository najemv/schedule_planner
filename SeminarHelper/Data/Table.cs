using System.Collections.Generic;

namespace SeminarHelper
{
    /* This class represent one table
     * That means, timegrid where in each slot can be zero or more lectures.
     */
    class Table
    {
        public List<Lecture>[,] lectures { get; set; } = new List<Lecture>[5, 6];
        public List<Seminar> seminars { get; set; }

        // init empty table
        public Table()
        {
            for (int day = 0; day < 5; day++)
                for (int slot = 0; slot < 6; slot++)
                    lectures[day, slot] = new List<Lecture>();

            seminars = new List<Seminar>();
        }

        // init table with subject's lectures (which are set and cannot be altered)
        public Table(List<Subject> subjects)
        {
            for (int day = 0; day < 5; day++)
                for (int slot = 0; slot < 6; slot++)
                    lectures[day, slot] = new List<Lecture>();

            foreach (var subject in subjects)
            {
                if (subject.Lecture != null)
                {
                    AddLecture(subject.Lecture);
                }
            }

            seminars = new List<Seminar>();
        }
       
        // copy constructor
        public Table(Table other)
        {
            for (int day = 0; day < 5; day++)
                for (int slot = 0; slot < 6; slot++)
                    lectures[day, slot] = new List<Lecture>(other.lectures[day, slot]);
            seminars = new List<Seminar>(other.seminars);
        }

        private void AddLecture(Lecture lecture)
        {
            int day = lecture.DayOfWeek;
            int start = lecture.Start;
            int index = (start - 8) / 2;
            lectures[day, index].Add(lecture);
        }

        // get string for all lectures in one cell (for filling grid)
        public string GetLectureString(int day, int slot)
        {
            var result = "";
            var time_slot = lectures[day, slot];
            foreach (var lecture in time_slot)
            {
                result += lecture.TablePrint();
            }
            return result;
        }

        // get full seminars string in this table
        public string GetEnrolledSeminarsString()
        {
            var result = "";
            foreach (var seminar in seminars)
            {
                result += seminar.ToString();
            }

            return result;
        }

        // try to add new seminar to this table
        // return true if it was succesful, false otherwise (collision);
        public bool AddSeminar(Seminar seminar, bool allowIntersectionWithLectures)
        {
            var lecture = seminar.Lecture;
            if (lecture == null) // seminar has no set lecture time (but still can be added)
            {
                seminars.Add(seminar);
                return true;
            }
            int day = lecture.DayOfWeek;
            int start = lecture.Start;
            int index = (start - 8) / 2;
            
            var collisions = lectures[day, index];
            foreach (var collision in collisions)
            {
                
                if (collision.Type == "seminar")
                {
                    return false;
                }
                if (collision.Type == "subject" && !allowIntersectionWithLectures)
                {
                    return false;
                }
                    
            }

            lectures[day, index].Add(lecture);
            seminars.Add(seminar);
            return true;
        }

        // remove seminars from the table
        public void RemoveSeminar(Seminar seminar)
        {
            var lecture = seminar.Lecture;
            if (lecture == null)
            {
                seminars.Remove(seminar);
                return;
            }
            int day = lecture.DayOfWeek;
            int start = lecture.Start;
            int index = (start - 8) / 2;

            
            lectures[day, index].Remove(lecture);
            seminars.Remove(seminar);
        }
    }
}
