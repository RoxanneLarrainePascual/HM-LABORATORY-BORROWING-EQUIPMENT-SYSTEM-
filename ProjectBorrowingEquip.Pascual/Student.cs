using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBorrowingEquip.Pascual
{
    public class Student
    {
        public int UserID { get; set; }
        public string FullName { get; set; }

        
        public Student(int id, string fullName)
        {
            UserID = id;
            FullName = fullName;
        }
    }
}
