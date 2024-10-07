using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace TimeLogger
{
    public partial class TimeEntryForm : Form
    {
        public Regex IsNonNumbers;

        public TimeSheet TimeSheet;

        public TimeEntryForm()
        {
            InitializeComponent();
            IsNonNumbers = new Regex("[^0-9]");
            TimeSheet = new TimeSheet();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            int sunHr, monHr, tuesHr, wedHr, thurHr, friHr, satHr;

            try
            {

           
            if (int.TryParse(sundayHrBox.Text, out sunHr))
            {
                TimeSheet.SubmitHours(Day.Sunday, sunHr);
            }

            if (int.TryParse(mondayHrBox.Text, out monHr))
            {
                TimeSheet.SubmitHours(Day.Monday, monHr);
            }

            if (int.TryParse(tuesdayHrBox.Text, out tuesHr))
            {
                TimeSheet.SubmitHours(Day.Tuesday, tuesHr);
            }

            if (int.TryParse(wednesdayHrBox.Text, out wedHr))
            {
                TimeSheet.SubmitHours(Day.Wednesday, wedHr);
            }

            if (int.TryParse(thursdayHrBox.Text, out thurHr))
            {
                TimeSheet.SubmitHours(Day.Thursday, thurHr);
            }

            if (int.TryParse(fridayHrBox.Text, out friHr))
            {
                TimeSheet.SubmitHours(Day.Friday, friHr);
            }

            if (int.TryParse(saturdayHrBox.Text, out satHr))
            {
                TimeSheet.SubmitHours(Day.Saturday, satHr);
            }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Their are only up to 24 hours in a day. You cannot work more than that");
                throw ex;
            }

            ClearTextInput();
           

        }
        private void DayBoxs_TextChanged(object sender, EventArgs e)
        {
            ParseTextBox(sundayHrBox);
            ParseTextBox(mondayHrBox);
            ParseTextBox(tuesdayHrBox);
            ParseTextBox(wednesdayHrBox);
            ParseTextBox(thursdayHrBox);
            ParseTextBox(fridayHrBox);
            ParseTextBox(saturdayHrBox);
        }
        private void ParseTextBox(TextBox textBox)
        {

            if (IsNonNumbers.IsMatch(textBox.Text))
            {
                textBox.Text = IsNonNumbers.Replace(textBox.Text, string.Empty);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            TimeSheet = new TimeSheet();
            ClearTextInput();

        }
        private void ClearTextInput()
        {
            sundayHrBox.Text = string.Empty;
            mondayHrBox.Text = string.Empty;
            tuesdayHrBox.Text = string.Empty;
            wednesdayHrBox.Text = string.Empty;
            thursdayHrBox.Text = string.Empty;
            fridayHrBox.Text = string.Empty;
            saturdayHrBox.Text = string.Empty;

            searchOutput.Text = string.Empty;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            Day? selectedDay = (Day?)dayDropdown.SelectedItem;
           if(selectedDay is null)
            {
                return;
            }
            int hoursWorkedThatDay = TimeSheet.GetHoursWorkedOn((Day)selectedDay);

            searchOutput.Text = $"On This Day, You Worked {hoursWorkedThatDay} Hours.";
        }
    }
}
