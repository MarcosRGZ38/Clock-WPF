using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }


    public class Time()
    {
        public int hour()
        {
            int hour = System.DateTime.Now.Hour;
            return hour;
        }
        public int minute()
        {
            int min = System.DateTime.Now.Minute;
            return min;
        }
        public int day()
        {
            int day = System.DateTime.Now.Day;
            return day;
        }

        public string parseMonth(int month)
        {
            if (month == 1) return "January";
            else if (month == 2) return "February";
            else if (month == 3) return "March";
            else if (month == 4) return "April";
            else if (month == 5) return "May";
            else if (month == 6) return "June";
            else if (month == 7) return "July";
            else if (month == 8) return "August";
            else if (month == 9) return "September";
            else if (month == 10) return "October";
            else if (month == 11) return "November";
            else if (month == 12) return "December";
            else return "N/A";
        }

        public string month()
        {
            int numericMonth = System.DateTime.Now.Month;  
            string month = parseMonth(numericMonth);
            return month;
            
        }

        public int Year()
        {
            int Year = System.DateTime.Now.Year;
            return Year;
        }
    }
}
