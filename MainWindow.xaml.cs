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
using System.Windows.Threading;
using TaskManager.Objects;

namespace TaskManager
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _aTimer;
        private List<Task> _TaskList = new List<Task>();
        public MainWindow()
        {
            InitializeComponent();
            SetTimer(); 
            _TaskList.Add(new Task("Task1", DateTime.Now, false));
            _TaskList.Add(new Task("Task2", DateTime.Now, false));
            _TaskList.Add(new Task("Task3", DateTime.Now, false));
            Console.WriteLine("dadawdaw");
            foreach (var name in _TaskList)
            {
                Tasks.Children.Add(new TaskRow(name.Name, name.Date, name.Completed));
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddTaskWindow taskWindow = new AddTaskWindow(this);
            taskWindow.ShowDialog();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString();
        }

        private void SetTimer()
        {
            _aTimer = new DispatcherTimer();
            _aTimer.Interval = new TimeSpan(0, 0, 1);
            _aTimer.Tick += new EventHandler(TimerTick);
            _aTimer.Start();
        }

        public void AddTask(String task, DateTime date)
        {
            Console.WriteLine("dadawd");
            Tasks.Children.Add(new TaskRow(task, date, false));
        }
    }
}
