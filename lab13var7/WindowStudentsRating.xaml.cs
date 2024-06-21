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

namespace lab13var7
{
    /// <summary>
    /// Логика взаимодействия для WindowStudentsRating.xaml
    /// </summary>
    public partial class WindowStudentsRating : Window
    {

        StudentsEntities db;

        public WindowStudentsRating(StudentsEntities db)
        {
            InitializeComponent();
            this.db=db;

            var students = db.Student.ToList().OrderByDescending(x => x.AvgGrade);
            dgStudents.ItemsSource = students;
        }
    }
}
