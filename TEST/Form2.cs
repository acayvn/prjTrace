using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TEST
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public override bool Equals(object obj)
            {
                //return base.Equals(obj);
                if (GetType() != obj.GetType() || obj == null)
                {
                    return false;
                }
                Student sv = obj as Student;
                return FirstName.Equals(sv.FirstName) && LastName.Equals(sv.LastName) && Age.Equals(sv.Age);
            }
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            var student1 = new Student
            {
                FirstName = "Pham",
                LastName = "Hoang",
                Age = 15,
            };

            var student2 = new Student
            {
                FirstName = "Pham",
                LastName = "Hoang",
                Age = 15,
            };
            var ax = student1.Equals(student2);
        }
        


    }
}
