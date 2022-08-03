using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SeminarHelper
{
    class TimeTable
    {
        // list of subject that user has registered
        public List<Subject> Subjects { get; set; } = new();
        // reference table (only with subject's lectures in it)
        public Table Table { get; set; } = new();

        // list of tables of last search
        public List<Table> CurrentSearch { get; set; } = new();
        public int currentIndex { get; set; }

        // filters
        public bool IntersectWithLectures { get; set; } = false;
        public TimeFilter TimeFilter { get; set; } = new();
        public NameFilter NameFilter { get; set; } = new();
        public ScoreFilter ScoreFilter { get; set; } = new();

        // attach subjects to this class (after parsing from IS/file)
        public void AddSubjects(List<Subject> subjects)
        {
            Subjects = subjects;
            Table = new Table(subjects);
            CurrentSearch = new();
            currentIndex = 0;
        }

        public string SubjectsPrint()
        {
            var result = "------------------------------" + Environment.NewLine;
            foreach (var subject in Subjects)
            {
                result += subject.ToString();
                result += "------------------------------" + Environment.NewLine;
            }
            
            return result;
        }

        // returns full string of seminars in current 'view'
        public string CurrentSeminarsPrint()
        {
            if (CurrentSearch.Count == 0)
            {
                return "";
            }
            return CurrentSearch[currentIndex].GetEnrolledSeminarsString();
        }

        // fill the DataGridView with current table, so that user can see it
        public void FillGrid(DataGridView grid, int i = -1)
        {
            var currentTable = (i >= 0) ? CurrentSearch[i] : Table;
            // clear the grid
            grid.DataSource = null;
            grid.Rows.Clear();

            int height = 5;
            int width = 6;

            grid.ColumnCount = width;
            grid.Columns[0].Name = "8:00-9:50";
            grid.Columns[1].Name = "10:00-11:50";
            grid.Columns[2].Name = "12:00-13:50";
            grid.Columns[3].Name = "14:00-15:50";
            grid.Columns[4].Name = "16:00-17:50";
            grid.Columns[5].Name = "18:00-19:50";

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(grid);
                row.HeaderCell.Value = PrintHelper.DayToString(r);
                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = currentTable.GetLectureString(r, c);
                }
                grid.Rows.Add(row);
            }
        }

        public bool ShowNext(DataGridView grid)
        {
            currentIndex++;
            FillGrid(grid, currentIndex);
            if (currentIndex == CurrentSearch.Count() - 1)
            {
                return false;
            }
            return true;
        }
        public bool ShowPrev(DataGridView grid)
        {
            currentIndex--;
            FillGrid(grid, currentIndex);
            if (currentIndex == 0)
            {
                return false;
            }
            return true;
        }


        private async Task FindRec(Table currentTable, int subjectIndex, CancellationToken ct)
        {
            // stop this task
            if (ct.IsCancellationRequested)
            {
                ct.ThrowIfCancellationRequested();
            }

            // recursion base
            if (subjectIndex == Subjects.Count())
            {
                CurrentSearch.Add(new Table(currentTable));
                return;
            }

            var subject = Subjects[subjectIndex];
            // is sebject has no seminars, just skip it
            if (subject.Seminars == null)
            {
                await FindRec(currentTable, subjectIndex + 1, ct);
            }
            else
            {
                // iterate through each seminar which pass set filters
                foreach (var seminar in NameFilter.Filter(subject))
                {
                    if (TimeFilter.Pass(seminar) && ScoreFilter.Pass(seminar) && currentTable.AddSeminar(seminar, IntersectWithLectures))
                    {
                        await FindRec(currentTable, subjectIndex + 1, ct);
                        
                        currentTable.RemoveSeminar(seminar);
                    }
                }
            }

            return;
            
        }

        public void Find()
        {
            CurrentSearch = new List<Table>();
            currentIndex = 0;
            if (Subjects.Count == 0)
            {
                MessageBox.Show("Musíte první načíst předměty");
                return;
            }

            var tokenSource = new CancellationTokenSource();
            try
            {
                var ct = tokenSource.Token;
                var currentTable = new Table(Subjects);
                var task = Task.Run(() => FindRec(currentTable, 0, ct), ct);
                // cancel this task after 1 sec before it takes too much resources
                tokenSource.CancelAfter(1000);
                Task.WaitAll(task);
            }
            catch (Exception)
            {
                MessageBox.Show("Výsledků je moc. Buďte více specifičtější.");
            }
            finally
            {
                tokenSource.Dispose();
            }
        }





        
    }
}
