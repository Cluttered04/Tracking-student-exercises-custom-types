using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise nutshell = new Exercise();
            nutshell.id = 1;
            nutshell.name = "nutshell";
            nutshell.language = "Javascript";

            Exercise fitpup = new Exercise();
            fitpup.id = 2;
            fitpup.name = "fitpup";
            fitpup.language = "React";

            Exercise dictionaries = new Exercise();
            dictionaries.id = 3;
            dictionaries.name = "dictionaries";
            dictionaries.language = "C#";

            Exercise weatherData = new Exercise();
            weatherData.id = 4;
            weatherData.name = "Weather Data Challenge";
            weatherData.language = "Javascript";

            Student bobby = new Student();
            bobby.id = 1;
            bobby.firstName = "Bobby";
            bobby.lastName = "Bobby";
            bobby.slackHandle = "Bobbikins";
            bobby.cohort = 1;


            Student sable = new Student();
            sable.id = 2;
            sable.firstName = "Sable";
            sable.lastName = "Mabel";
            sable.slackHandle = "Sabikins";
            sable.cohort = 2;

            Student sydney = new Student();
            sydney.id = 3;
            sydney.firstName = "Sydney";
            sydney.lastName = "Sidders";
            sydney.slackHandle = "Siddikins";
            sydney.cohort = 3;

            Student matt = new Student();
            matt.id = 4;
            matt.firstName = "Matt";
            matt.lastName = "Matt";
            matt.slackHandle = "Mattikins";
            matt.cohort = 2;

            Cohort one = new Cohort();
            one.id = 1;
            one.name = "Cohort One";


            Cohort two = new Cohort();
            two.id = 2;
            two.name = "Cohort Two";

            Cohort three = new Cohort();
            three.id = 3;
            three.name = "Cohort Three";

            one.students.Add(bobby);
            two.students.Add(sable);
            two.students.Add(matt);
            three.students.Add(sydney);

            Instructor jordan = new Instructor();
            jordan.id = 2;
            jordan.firstName = "Jordan";
            jordan.lastName = "Castelloe";
            jordan.cohortNumber = 1;
            jordan.assignExercise(bobby, nutshell);
            jordan.assignExercise(bobby, weatherData);
            jordan.assignExercise(sable, nutshell);
            jordan.assignExercise(sable, weatherData);
            jordan.assignExercise(matt, nutshell);
            jordan.assignExercise(matt, fitpup);

            Instructor josh = new Instructor();
            josh.id = 2;
            josh.firstName = "Josh";
            josh.lastName = "Rover";
            josh.cohortNumber = 2;
            josh.assignExercise(bobby, weatherData);
            josh.assignExercise(bobby, fitpup);
            josh.assignExercise(sable, fitpup);
            josh.assignExercise(sable, dictionaries);
            josh.assignExercise(matt, fitpup);
            josh.assignExercise(matt, nutshell);

            Instructor kim = new Instructor();
            kim.id = 3;
            kim.firstName = "Kim";
            kim.lastName = "Preece";
            kim.cohortNumber = 3;
            kim.assignExercise(bobby, nutshell);
            kim.assignExercise(bobby, weatherData);
            kim.assignExercise(sable, fitpup);
            kim.assignExercise(sable, nutshell);
            kim.assignExercise(matt, nutshell);
            kim.assignExercise(matt, fitpup);

            one.instructors.Add(jordan);
            two.instructors.Add(josh);
            three.instructors.Add(kim);

        List<Student> students = new List<Student>();

        students.Add(bobby);
        students.Add(sable);
        students.Add(sydney);
        students.Add(matt);

        List<Exercise> exercises = new List<Exercise>();

        exercises.Add(nutshell);
        exercises.Add(weatherData);
        exercises.Add(dictionaries);
        exercises.Add(fitpup);

        List<Instructor> instructors = new List<Instructor>(){
            kim,
            jordan,
            josh
        };

        List<Cohort> cohorts = new List<Cohort>(){
            one,
            two,
            three
        };

        // foreach(Student student in students){
        //     Console.WriteLine(student.firstName);
        //     foreach(string exercise in student.currentExercises){
        //         Console.WriteLine(exercise);
        //     }
        // }

//         List exercises for the JavaScript language by using the Where() LINQ method.
    IEnumerable<Exercise> JSExercises = exercises.Where(e => e.language == "Javascript");

// List students in a particular cohort by using the Where() LINQ method.
    IEnumerable<Student> cohortOneStudents = students.Where(s => s.cohort == 1);
// List instructors in a particular cohort by using the Where() LINQ method.
    IEnumerable<Instructor> cohortOneInstructors = instructors.Where(i => i.cohortNumber == 1);
// Sort the students by their last name.
    IEnumerable<Student> orderedStudents = students.OrderBy(s => s.lastName);
    orderedStudents.ToList().ForEach(student => Console.WriteLine(student.firstName));
// Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
    var lazyStudents = students.Where(student => student.currentExercises.Count() == 0);
    lazyStudents.ToList().ForEach(student => Console.WriteLine($"This student is lazy! {student.firstName}"));
// Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
   IEnumerable<Student> hardWorkingStudents =  students.OrderByDescending(m => m.currentExercises.Count());

    Student hardestWorkingStudent = hardWorkingStudents.First();
//    hardestWorkingStudent.ForEach(student => Console.WriteLine(student));

// How many students in each cohort?
    one.students.Count();
    two.students.Count();
    three.students.Count();




















        }
    }
}
