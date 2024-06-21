using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для WindowAddStudent.xaml
    /// </summary>
    public partial class WindowAddStudent : Window
    {

        StudentsEntities db;
        byte[] photo;
        ImageSourceConverter converter = new ImageSourceConverter();

        public WindowAddStudent(StudentsEntities db)
        {
            InitializeComponent();
            this.db=db;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            student.Surname = txtSurname.Text;
            student.Name = txtName.Text;
            student.Father_Name = txtFatherName.Text;
            student.Phone_Number = txtPhoneNumber.Text;
            student.Birthday = Convert.ToDateTime(dpBirth.Text).Date;
            student.Weight = Convert.ToDecimal(txtWeight.Text);
            student.Height = int.Parse(txtHeight.Text);
            student.Photo = photo;
            try
            {
                db.Student.Add(student);
                db.SaveChanges();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось записать ученика");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                photo = File.ReadAllBytes(openFile.FileName);
                imgPhoto.Source = converter.ConvertFrom(openFile.FileName) as ImageSource;
            }
        }
    }
}
