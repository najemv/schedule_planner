namespace SeminarHelper
{
    class TimeFilter
    {
        public int MondayFrom { get; set; } = 8;
        public int MondayTo { get; set; } = 20;
        public int TuesdayFrom { get; set; } = 8;
        public int TuesdayTo { get; set; } = 20;
        public int WednesdayFrom { get; set; } = 8;
        public int WednesdayTo { get; set; } = 20;
        public int ThursdayFrom { get; set; } = 8;
        public int ThursdayTo { get; set; } = 20;
        public int FridayFrom { get; set; } = 8;
        public int FridayTo { get; set; } = 20;


        /* Returns true or false, whether subject lies between set intervals.
         */
        public bool Pass(Seminar seminar)
        {
            var lecture = seminar.Lecture;
            if (lecture == null)
            {
                return true;
            }

            switch (lecture.DayOfWeek)
            {
                case 0:
                    return lecture.Start >= MondayFrom && lecture.End < MondayTo;
                case 1:
                    return lecture.Start >= TuesdayFrom && lecture.End < TuesdayTo;
                case 2:
                    return lecture.Start >= WednesdayFrom && lecture.End < WednesdayTo;
                case 3:
                    return lecture.Start >= ThursdayFrom && lecture.End < ThursdayTo;
                case 4:
                    return lecture.Start >= FridayFrom && lecture.End < FridayTo;
                default:
                    break;
            }

            return false;
        }
    }
}
