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
    /// Логика взаимодействия для WindowAddGrade.xaml
    /// </summary>
    public partial class WindowAddGrade : Window
    {

        StudentsEntities db;

        public WindowAddGrade(StudentsEntities db)
        {
            InitializeComponent();
            this.db=db;

            int[] grades = { 1, 2, 3, 4, 5 };

            cmbStudent.ItemsSource = db.Student.ToList();
            cmbSubject.ItemsSource = db.Subject.ToList();
            cmbGrade.ItemsSource = grades;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(cmbStudent.SelectedItem == null || cmbSubject.SelectedItem == null || cmbGrade.SelectedItem == null) 
            {
                MessageBox.Show("Выбраны не все параметры!");
                return;
            }

            StudetnsGrade grade = new StudetnsGrade();
            grade.Subject = cmbSubject.SelectedValue as Subject;
            grade.Student = cmbStudent.SelectedItem as Student;
            grade.Grade = (int)cmbGrade.SelectedValue;

            try
            {
                db.StudetnsGrade.Add(grade);
                db.SaveChanges();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить оценку");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
