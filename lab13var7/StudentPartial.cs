using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13var7
{
    public partial class Student
    {
        StudentsEntities db = new StudentsEntities();

        public string BirthdayString { get
            {
                return Birthday.ToString("d");
            } 
        }

        public double AvgGrade {  get
            {
                return db.StudetnsGrade.Where(x => x.Id_Student == Id_Student).Select(x => x.Grade).Average();
            }
        }
    }
}
