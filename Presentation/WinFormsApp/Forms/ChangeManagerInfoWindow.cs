using System.Globalization;

namespace WinFormsApp.Forms
{
    public partial class ChangeManagerInfoWindow : Form
    {
        private static string _mngrPassData;
        public ChangeManagerInfoWindow()
        {
            InitializeComponent();
        }

        public void SetMngrPassData(string mngrPassData)
        {
            _mngrPassData = mngrPassData;
        }

        private void button_ChangeManagerInfoWindow_Change_Click(object sender, EventArgs e)
        {
            var mngrSalary = textBox_ChangeManagerInfoWindow_Salary_Input.Text;
            var mngrPayDate = textBox_ChangeManagerInfo_MngrPayDate_Input.Text;
            var mngrPrize = textBox_ChangeManagerInfo_MngrPrize_Input.Text;

            decimal decMngrSalary = -1;
            DateTime dateMngrPayDate = new DateTime();
            decimal decMngrPrize = -1;

            if (!String.IsNullOrWhiteSpace(mngrSalary))
            {
                if (!mngrSalary.Contains(','))
                {
                    decMngrSalary = Decimal.Parse(mngrSalary, CultureInfo.InvariantCulture);
                }
                else
                {
                    MessageBox.Show("Разедлителем между целой частью числа\n и десятичной должна быть точка ('.')");
                    return;
                }
            }

            if (!String.IsNullOrWhiteSpace(mngrPayDate))
            {
                try
                {
                    dateMngrPayDate = DateTime.Parse(mngrPayDate);
                }
                catch (Exception)
                {
                    MessageBox.Show("Формат записи даты:\n" +
                        "yyyy.mm.dd\n" +
                        "mm.dd.yyyy\n" +
                        "yyyy-mm-dd\n" +
                        "yyyy/mm/dd");
                    return;
                }
            }

            if (!String.IsNullOrWhiteSpace(mngrPrize))
            {
                if (!mngrPrize.Contains(','))
                {
                    decMngrPrize = Decimal.Parse(mngrPrize, CultureInfo.InvariantCulture);
                }
                else
                {
                    MessageBox.Show("Разедлителем между целой частью числа\n и десятичной должна быть точка ('.')");
                    return;
                }
            }


        }
    }
}
