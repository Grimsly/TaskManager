using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for AddTaskWindow.xaml
    /// </summary>
    public partial class AddTaskWindow : Window
    {
        private MainWindow mainWindow;
        public AddTaskWindow(MainWindow main)
        {
            InitializeComponent();
            mainWindow = main;
            DatePicker.BlackoutDates.AddDatesInPast();
            DatePicker.BlackoutDates.Add(new CalendarDateRange(DateTime.Now, DateTime.Now.AddDays(7)));
        }
        private void AddClick(object sender, RoutedEventArgs e)
        {
            mainWindow.AddTask(TaskInput.Text, DateTime.Now);
            this.Close();
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
