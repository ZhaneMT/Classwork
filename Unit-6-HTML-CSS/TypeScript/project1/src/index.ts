// typescript file goes here
console.log("Welcome to My First TypeScript");
/* This app will create, store and process a set of students
    Each student will have a Name, class, start date of the class
    Students will be stored in an array an processed from that array
    using array functions
    */

// To assure anyone wanting to reference a student has the same desscription
//      same properties and types, we will define an interface for a Student.
// Think of interface as a programmer defined type or data layout.
interface Student {
    studentName : string;
    className   : string;
    startDate   : number;   //yyyymmdd  e.g. 20250618
}
// Define a class that will hold and process all the students.
class Roster {
    // Array to hold all the students in a Roster.
    studentList : Student[];    //Aarray of Student objects
    constructor() {
        this.studentList = [];  //Initialize array to be empty by making a constructor
        
    }

    //Class method to add a student to the Roster.
    addStudent(newStudent: Student){
        this.studentList.push(newStudent);
    }

    // Class method to return the entire Roster
    getAllTheStudents(){
        return this.studentList
    }
}// End of class Roster
let classRoster = new Roster();

// Add some students to the roster
classRoster.addStudent({studentName : "Frank" , className : "Angular", startDate : 20250623})
classRoster.addStudent({studentName : "Zach" , className : "Angular", startDate : 20250623})
classRoster.addStudent({studentName : "India" , className : "Angular", startDate : 20250623})
classRoster.addStudent({studentName : "Kiana" , className : "Angular", startDate : 20250623})
classRoster.addStudent({studentName : "Youssef" , className : "of his own", startDate : 20260623})

let aStudent = {studentName : "Jay", className : "Advanced Angular", startDate: 20250723}
classRoster.addStudent(aStudent)

//Display all the students in our roster.
//Loop through the roster and display students one at a time
classRoster.getAllTheStudents().forEach(aStudent => { console.log(aStudent)}
