/*The following code is used to find the GPA of six students in a class using their 
credit scores, test scores and credit hours/cresit units
*/


using System;
using System.ComponentModel;

// Initializing variables for student details and scores
string studentName = "";
string? studentId = "";
string mth101Score = "";
string eng101Score = "";
string gst101Score = "";
string phy101Score = "";
string csc101Score = "";
string csc102Score = "";
string eet102Score = "";
string mth102Score = "";
string stat104Score = "";
string calc101Score = "";

// Initializing credit units for each subject
int math101Credit = 3;
int eng101Credit = 2;
int gst101Credit = 3;
int phy101Credit = 3;
int csc101Credit = 3;
int csc102Credit = 4;
int eet102Credit = 2;
int mth102Credit = 3;
int stat104Credit = 3;
int calc101Credit = 4;

// Calculate total credit units for each semester
int firstSemCredits = math101Credit + eng101Credit + gst101Credit + phy101Credit + csc101Credit;
int secondSemCredits = csc102Credit + eet102Credit + mth102Credit + stat104Credit + calc101Credit;

// Code to display header and promp user to input student ID
Console.WriteLine("Tophill School Report Card Checker\t2023/2024 Academic Session");
Console.WriteLine("Please enter your School ID");
studentId = Console.ReadLine();  

// Assign student name and scores based on the entered student ID
switch (studentId)
{
    case "0390":
        studentName = "Chukwubuikem Modilim";
        mth101Score = "86";
        eng101Score = "85";
        gst101Score = "94";
        phy101Score = "93";
        csc101Score = "94";
        csc102Score = "93";
        eet102Score = "94";
        mth102Score = "84";
        stat104Score = "92";
        calc101Score = "94";
        break;
    case "7778":
        studentName = "Esther Modebe";
        mth101Score = "92";
        eng101Score = "64";
        gst101Score = "74";
        phy101Score = "84";
        csc101Score = "94";
        csc102Score = "75";
        eet102Score = "64";
        mth102Score = "75";
        stat104Score = "54";
        calc101Score = "94";
        break;
    case "6200":
        studentName = "Stanley Audu";
        mth101Score = "74";
        eng101Score = "73";
        gst101Score = "78";
        phy101Score = "74";
        csc101Score = "52";
        csc102Score = "78";
        eet102Score = "94";
        mth102Score = "85";
        stat104Score = "74";
        calc101Score = "62";
        break;
    case "6937":
        studentName = "Seyi Omoniyi";
        mth101Score = "93";
        eng101Score = "82";
        gst101Score = "92";
        phy101Score = "82";
        csc101Score = "65";
        csc102Score = "94";
        eet102Score = "94";
        mth102Score = "74";
        stat104Score = "63";
        calc101Score = "53";
        break;
    case "7759":
        studentName = "Adeleke Ali";
        mth101Score = "74";
        eng101Score = "43";
        gst101Score = "67";
        phy101Score = "75";
        csc101Score = "75";
        csc102Score = "43";
        eet102Score = "75";
        mth102Score = "65";
        stat104Score = "54";
        calc101Score = "75";
        break;
    case "0771":
        studentName = "Leo Raphael";
        mth101Score = "34";
        eng101Score = "84";
        gst101Score = "54";
        phy101Score = "43";
        csc101Score = "48";
        csc102Score = "69";
        eet102Score = "35";
        mth102Score = "58";
        stat104Score = "35";
        calc101Score = "66";
        break;
    default:
        System.Console.WriteLine("Invalid entry");
        break;
}

// Convert score from string to integer
int ConvertScore(string score)
{
    return int.TryParse(score, out int result) ? result : 0;  // Return 0 if conversion fails
}

// Determine grade points based on score
int GetGradeScoree(int score)
{
    if (score >= 70) return 5;
    else if (score >= 60) return 4;
    else if (score >= 50) return 3;
    else if (score >= 45) return 2;
    else return 0;  // scores below 45 will have a grade point of zero
}

// Determine grade remark based on score
string GetGradeRemark(int score)
{
    if (score >= 70) return "Excellent";
    if (score >= 60) return "Very Good";
    if (score >= 50) return "Good";
    if (score >= 45) return "Fair";
    else return "Carry Over"; // Courses with scores below 45 will be carried over
}

// Calculate CGPA based on scores and credits and total credits
decimal CalculateCGPA(int[] scores, int[] credits, int totalCredits)
{
    int totalGradePoints = 0;
    for (int i = 0; i < scores.Length; i++)
    {
        totalGradePoints += GetGradeScoree(scores[i]) * credits[i];  // Calculate total grade points
    }
    return (decimal)totalGradePoints / totalCredits;  // Return CGPA
}

// Arrays to store scores and credits for each semester
int[] firstSemScores = new int[] { ConvertScore(mth101Score), ConvertScore(eng101Score), ConvertScore(gst101Score), ConvertScore(phy101Score), ConvertScore(csc101Score) };

int[] secondSemScores = new int[] { ConvertScore(csc102Score), ConvertScore(eet102Score), ConvertScore(mth102Score), ConvertScore(stat104Score), ConvertScore(calc101Score) };

int[] firstSemCreditsArr = new int[] { math101Credit, eng101Credit, gst101Credit, phy101Credit, csc101Credit };

int[] secondSemCreditsArr = new int[]
{csc102Credit,eet102Credit,mth102Credit,stat104Credit,calc101Credit};

// Calculate CGPA for each semester and overall CGPA
decimal firstSemCGPA = CalculateCGPA(firstSemScores, firstSemCreditsArr, firstSemCredits);
decimal secondSemCGPA = CalculateCGPA(secondSemScores, secondSemCreditsArr, secondSemCredits);
decimal overallCGPA = (firstSemCGPA + secondSemCGPA) / 2;  // Average of both semesters

// Display student information and grades
decimal truncatedFirstSem = Math.Round(firstSemCGPA,2);
System.Console.WriteLine($"ID Number: {studentId} Student Name: {studentName}");
System.Console.WriteLine($"First Semester Courses and Grades\t\tGPA: {truncatedFirstSem} out of 5.0\n");
System.Console.WriteLine($"S/N\tSubjects\tScore\tGrade\tCredit\tRemark\n");
for (int i = 0; i < firstSemScores.Length; i++)
{
    string subjectCode = i switch
    {
        0 => "MTH 101",
        1 => "ENG 101",
        2 => "GST 101",
        3 => "PHY 101",
        4 => "CSC 101",
        _ => ""
    };
    string grade = firstSemScores[i] switch
    {
        5 => "A",
        4 => "B",
        3 => "C",
        2 => "D",
        0 => "F",
        _ => ""
    };
    string remark = GetGradeRemark(firstSemScores[i]);
    System.Console.WriteLine($"{i + 1}.\t{subjectCode}:\t{firstSemScores[i]}\t{grade}\t{firstSemCreditsArr[i]}\t{remark}");
}

// Display second semester information and grades
decimal truncatedSecSem = Math.Round(secondSemCGPA, 2); 
System.Console.WriteLine($"Second Semester Courses\t\tGPA: {truncatedSecSem} out of 5.0\n");
System.Console.WriteLine($"S/N\tSubjects\tScore\tGrade\tCredit\tRemark\n");
for (int i = 0; i < secondSemScores.Length; i++)
{
    string subjectCode = i switch
    {
        0 => "CSC 102",
        1 => "EET 102",
        2 => "MTH 102",
        3 => "STA 104",
        4 => "CAL 101",
        _ => ""
    };
    string grade = GetGradeScoree(secondSemScores[i]) switch
    {
        5 => "A",
        4 => "B",
        3 => "C",
        2 => "D",
        0 => "F",
        _ => ""
    };
    string remark = GetGradeRemark(secondSemScores[i]);
    System.Console.WriteLine($"{i + 1}.\t{subjectCode}\t\t{secondSemScores[i]}\t{grade}\t{secondSemCreditsArr[i]}\t{remark}");
}
decimal truncatedOverallCGPA = Math.Round(overallCGPA, 3);
System.Console.WriteLine($"OVERALL GPA: {truncatedOverallCGPA}/5");


