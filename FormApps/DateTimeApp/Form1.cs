namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDateCount_Click(object sender, EventArgs e) {

            var today = DateTime.Today;

            TimeSpan diff = today - dtpDate.Value;

            //tbDisp.Text = "ÅZÅZì˙ñ⁄";
            tbDisp.Text = (diff.Days + 1) + "ì˙ñ⁄";

        }

        private void btDayBefore_Click(object sender, EventArgs e) {
            var past = dtpDate.Value.AddDays(-(double)nudDay.Value);
            tbDisp.Text = past.ToString("Y");
        }

        private void btDayAfter_Click(object sender, EventArgs e) {

        }
        private void btDayAfter_Click(object sender, EventArgs e) {

        }

        public static int GetAge(DateTime birthday, DateTime targeDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)).AddDays(-1)){

            }
            return age;
        }

    }
}
