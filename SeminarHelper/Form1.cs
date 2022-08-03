using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;

namespace SeminarHelper
{
    public partial class Application : Form
    {
        ChromeDriver driver;
        TimeTable table;
        bool isLogged = false;

        public Application(ChromeDriver driver)
        {
            this.driver = driver;
            table = new TimeTable();
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.FillGrid(tableGrid);
        }

        void SetPrevNextButtons()
        {
            btnPrev.Enabled = false;
            btnNext.Enabled = table.CurrentSearch.Count() > 1;
            labelCurrentIndex.Text = (table.CurrentSearch.Count > 0) ? "1" : "0";
            labelMaxIndex.Text = table.CurrentSearch.Count.ToString();
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            table.FillGrid(tableGrid);
            table.CurrentSearch = new();
            table.currentIndex = 0;
            SetPrevNextButtons();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            table.Find();
            if (table.CurrentSearch.Count() == 0)
            {
                MessageBox.Show("Nenašli se žádné výsledky.");
                table.FillGrid(tableGrid, -1);
            }
            else
            {
                table.FillGrid(tableGrid, 0);
            }

            SetPrevNextButtons();

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            btnPrev.Enabled = table.ShowPrev(tableGrid);
            btnNext.Enabled = true;
            
            labelCurrentIndex.Text = (table.currentIndex + 1).ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = table.ShowNext(tableGrid);
            if (btnNext.Enabled)
            btnPrev.Enabled = true;
            
            labelCurrentIndex.Text = (table.currentIndex + 1).ToString();
        }

        private void btnSubjectList_Click(object sender, EventArgs e)
        {
            new PopupTextWindow(table.SubjectsPrint()).Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (new LoginForm(driver).ShowDialog() == DialogResult.OK)
            {
                isLogged = true;
                MessageBox.Show("Přihlášení bylo úspěšné.");
                
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            if (dialog.ShowDialog(this.ParentForm) != DialogResult.OK)
            {
                return;
            }

            var subjects = Parser.FromFile(dialog.FileName);
            table.AddSubjects(subjects);
            table.FillGrid(tableGrid, -1);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();

            if (dialog.ShowDialog(this.ParentForm) != DialogResult.OK)
            {
                return;
            }
            Parser.ToFile(dialog.FileName, table.Subjects);
        }

        private void btnOverrideNo_CheckedChanged(object sender, EventArgs e)
        {
            table.IntersectWithLectures = false;
            if (btnOverrideNo.Checked)
                Console.WriteLine("NO WAS CHECKED");
            else
                Console.WriteLine("NO WAS UNCHECKED");
        }

        private void btnOverrideYes_CheckedChanged(object sender, EventArgs e)
        {
            table.IntersectWithLectures = true;
            if (btnOverrideYes.Checked)
                Console.WriteLine("YES WAS CHECKED");
            else
                Console.WriteLine("YES WAS UNCHECKED");
        }

        #region Scrollbars
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            table.TimeFilter.MondayFrom = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
            table.TimeFilter.TuesdayFrom = trackBar2.Value;

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = trackBar3.Value.ToString();
            table.TimeFilter.WednesdayFrom = trackBar3.Value;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            textBox4.Text = trackBar4.Value.ToString();
            table.TimeFilter.ThursdayFrom = trackBar4.Value;
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            textBox5.Text = trackBar5.Value.ToString();
            table.TimeFilter.FridayFrom = trackBar5.Value;
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            textBox6.Text = trackBar6.Value.ToString();
            table.TimeFilter.MondayTo = trackBar6.Value;
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            textBox7.Text = trackBar7.Value.ToString();
            table.TimeFilter.TuesdayTo = trackBar7.Value;
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            textBox8.Text = trackBar8.Value.ToString();
            table.TimeFilter.WednesdayTo = trackBar8.Value;
        }

        private void trackBar9_Scroll(object sender, EventArgs e)
        {
            textBox9.Text = trackBar9.Value.ToString();
            table.TimeFilter.ThursdayTo = trackBar9.Value;
        }

        private void trackBar10_Scroll(object sender, EventArgs e)
        {
            textBox10.Text = trackBar10.Value.ToString();
            table.TimeFilter.FridayTo = trackBar10.Value;
        }

        #endregion

        private void btnNamesUpdate_Click(object sender, EventArgs e)
        {
            var names = textBoxNames.Text.Split(',');
            for (int i = 0; i < names.Length; ++i)
            {
                names[i] = names[i].Trim().ToLower();
                Console.WriteLine(names[i]);
            }

            table.NameFilter.Names = new List<string>(names);
        }

        private void trackBarScore_Scroll(object sender, EventArgs e)
        {
            double value = (double)trackBarScore.Value / 10;
            textBoxScore.Text = value.ToString();
            table.ScoreFilter.WorstScore = value;
        }

        private void btnCurrentSeminars_Click(object sender, EventArgs e)
        {
            new PopupTextWindow(table.CurrentSeminarsPrint()).Show();
        }

        private async void btnISLoad_Click(object sender, EventArgs e)
        {
            if (!isLogged)
            {
                MessageBox.Show("Musíte se nejdřív přihlásit");
                return;
            }
            
            var subjects = await Parser.FromIS(driver);
            table.AddSubjects(subjects);
            table.FillGrid(tableGrid, -1);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!isLogged)
            {
                MessageBox.Show("Musíte se nejdřív přihlásit");
                return;
            }

            if (table.CurrentSearch.Count() == 0)
            {
                MessageBox.Show("Najděte první nějaký rozvrh.");
                return;
            }
            var date = dateTimePicker1.Value;

            if (date < DateTime.Now.AddMinutes(1.0))
            {
                MessageBox.Show("Datum je moc staré.");
                return;
            }

            var seminars = table.CurrentSearch[table.currentIndex].seminars;
            _ = Registrator.Register(driver, date, seminars, checkBoxOpenWindows.Checked);
        }
    }
}
