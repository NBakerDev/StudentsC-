using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassProject {
    class Student {

        public string Firstname { get; set;  }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Finalgrade { get; set; }

        public string GetFullname() {
            return Firstname + " " + Lastname;
        }
        public void SetFinalGrade(int finalgrade) {
            if (finalgrade < 0) {
                Console.WriteLine("ERROR: Grade must be greater than 0");
            } else {
            Finalgrade = finalgrade;
               
            }
        }
    }

}
