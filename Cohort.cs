using System.Collections.Generic;

namespace StudentExercises{
    class Cohort {
        public string name {get; set;}
        public int id {get; set;}
        public List<Student> students = new List<Student>();
        public List<Instructor> instructors = new List<Instructor>();
    }



}