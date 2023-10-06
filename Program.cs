// initialize variables - graded assignments
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\t Exam Score\t\tOverall\t Grade \t\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;
    {
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    }
    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    double StudentGrade = 0;

    // initialize/reset the calculated average of exam scores
    decimal StudentExamScore = 0;

    // initializa/reset the calculated of extra credits points
    double StudentExtraCreditsPoints; 

    // initialize/reset the sum of extra credits
    int StudentExtraCredits = 0 ;

    // initialize/reset a counter for the number of assignment 
    int gradedAssignments = 0;

    // loop through the scores array and complete calculations for currentStudent
    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;
        

        if (gradedAssignments <= examAssignments)
            // add the exam score to the sum
            sumAssignmentScores += score;

        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            StudentExtraCredits += score;
            
            
    }
    
    StudentExtraCreditsPoints = (double)(StudentExtraCredits / 10) / examAssignments ;
    StudentExamScore = sumAssignmentScores / examAssignments;

    if(gradedAssignments>examAssignments){
        StudentExtraCredits = StudentExtraCredits / (gradedAssignments - examAssignments);
    }

    StudentGrade = (sumAssignmentScores) / examAssignments + StudentExtraCreditsPoints;
switch (StudentGrade) {
        case >96:
            currentStudentLetterGrade = "A+";
            break;
        case > 92:
            currentStudentLetterGrade = "A";
            break;
        case >89:
            currentStudentLetterGrade = "A-";
            break;
        case >86:
            currentStudentLetterGrade = "B+";
            break;
        case >82:
            currentStudentLetterGrade = "B";
            break;
        case >79:
            currentStudentLetterGrade = "B-";
            break;
        case >76:
            currentStudentLetterGrade = "C+";
            break;
        case >72:
            currentStudentLetterGrade = "C";
            break;
        case >69:
            currentStudentLetterGrade = "C-";
            break;
        case >66:
            currentStudentLetterGrade = "D+";
            break;
        case >62:
            currentStudentLetterGrade = "D";
            break;
        case >59:
            currentStudentLetterGrade = "D-";
            break;
        case <60:
            currentStudentLetterGrade = "F";
            break;
    }


    //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
    Console.WriteLine($"{currentStudent}\t\t\t{StudentExamScore}\t\t{StudentGrade}\t{currentStudentLetterGrade}\t\t{StudentExtraCredits} ({StudentExtraCreditsPoints} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();