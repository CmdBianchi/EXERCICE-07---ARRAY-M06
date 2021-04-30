using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCICE_07___ARRAY_M06 {
    
    class Student {
        //---------------------------- START --------------------------------//
        public string Name { get; set; }
        public string Email { get; set; }
        //------------------------- CONSTRUCTORS ----------------------------//
        public Student(string name, string email) {
            Name = name;
            Email = email;
        }
        //------------------------- CLASS |  MET ---------------------------//
        public override string ToString() {
            return Name + ", " + Email;
        }
        //-------------------------------- END -------------------------------//
    }

}
