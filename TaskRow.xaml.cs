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
using TaskManager.Objects;

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for TaskRow.xaml
    /// </summary>
    public partial class TaskRow : UserControl
    {
        public TaskRow(String name, DateTime time, Boolean completed)
        {
            InitializeComponent();

            Task.Text = name;
            Date.Text = time.ToString();
            if (completed)
            {
                Incompleted.Text = "Completed";
            }
            else
            {
                Incompleted.Text = "Incompleted";
            }
        }
    }
}
