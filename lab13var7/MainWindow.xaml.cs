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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab13var7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        StudentsEntities db = new StudentsEntities();

        public MainWindow()
        {
            InitializeComponent();

            dgStudents.ItemsSource = db.Student.ToList();
            dgSubjects.ItemsSource = db.Subject.ToList();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            WindowAddStudent window = new WindowAddStudent(db);
            window.ShowDialog();
            dgStudents.ItemsSource = null;
            dgStudents.ItemsSource = db.Student.ToList();
        }

        private void btnAddGrade_Click(object sender, RoutedEventArgs e)
        {
            WindowAddGrade window = new WindowAddGrade(db);
            window.ShowDialog();
        }

        private void btnStudentRating_Click(object sender, RoutedEventArgs e)
        {
            WindowStudentsRating window = new WindowStudentsRating(db);
            window.ShowDialog();
        }
    }
}
