namespace StudentExercises{


// A method to assign an exercise to a student
// Exercise
    class Instructor {
        public int id {get; set;}
        public string firstName {get; set;}
        public string lastName {get; set;}
        public int cohortNumber {get; set;}

        public void assignExercise(Student student, Exercise exercise){
            student.currentExercises.Add(exercise.name);
        }
    }


}