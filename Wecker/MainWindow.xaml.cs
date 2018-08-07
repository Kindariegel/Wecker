using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Wecker
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Buttonadd_Click(object sender, RoutedEventArgs e)
        {
            string title = textboxtitle.Text;
            string hoursText = textboxhours.Text;
            string minutesText = textboxminutes.Text;
            int hours;
            int minutes;
            bool result = int.TryParse(hoursText, out hours);
            result = int.TryParse(minutesText, out minutes);

            if(result && hours >= 0 && hours <=23 && minutes >=0 && minutes <=59)
            {
                Meeting m = new Meeting(title, hours, minutes);
                listBoxMeetings.Items.Add(m);
            }
            else
            {
                //this is a message
                MessageBox.Show("Fehler");
            }
       
        }

        private void Buttondel_Click(object sender, RoutedEventArgs e)
        {
            int i = listBoxMeetings.SelectedIndex;
            if (i > 0)
            {
                listBoxMeetings.Items.RemoveAt(i);
            }

        }
    }
}
