using System;

namespace StudentSystemMatric
{
    public class StudentSystem
    {
        class Student
        {
            static void Main()
            {

                string[] studentNames = new string[100];
                string[] matriculationNumbers = new string[100];
                int counter = 0;

                static string[] getStudentNames(ref string[] studentNames, ref string[] matriculationNumbers, int counter)
                {

                    bool namesAdded = false;

                    while (!namesAdded)
                    {
                        Console.WriteLine("Please enter your name: ");
                        string studentName = Console.ReadLine();
                        if (String.IsNullOrWhiteSpace(studentName) == true && counter == 0)
                        {
                            Console.WriteLine("Error: No names added");
                        }
                        else if (String.IsNullOrWhiteSpace(studentName) == true)
                        {
                            namesAdded = true;
                            Array.Resize(ref studentNames, counter);


                        }
                        else
                        {
                            studentNames[counter] = studentName;
                            getMatriculationNumbers(ref matriculationNumbers, counter);
                            counter++;
                        }
                    }
                    return studentNames;
                }



                static string[] getMatriculationNumbers(ref string[] matriculationNumbers, int counter)
                {
                    bool isMatriculationNumberValid = false;
                    while (!isMatriculationNumberValid)
                    {
                        Console.WriteLine("Please enter your matriculation number: ");
                        string matriculationNumber = Console.ReadLine();
                        if (matriculationNumber.StartsWith("4") == false)
                        {
                            Console.WriteLine("Error: Matriculation number does not start with 4");
                        }
                        else
                        {
                            if (matriculationNumber.Length > 8)
                            {
                                Console.WriteLine("Error: Matriculation number is too long");
                            }
                            else if (matriculationNumber.Length < 8)
                            {
                                Console.WriteLine("Error: Matriculation number is too short");
                            }
                            else
                            {
                                matriculationNumbers[counter] = matriculationNumber;
                                isMatriculationNumberValid = true;

                            }
                        }
                    }
                    return matriculationNumbers;
                }



                getStudentNames(ref studentNames, ref matriculationNumbers, counter);
                Array.Resize(ref matriculationNumbers, studentNames.Length);
                string[] studentMarks = new string[studentNames.Length];

                static string[] getStudentMarks(string[] studentNames, string[] studentMarks)
                {
                    int mark = 0;
                    bool isMarkValid = false;

                    for (int i = 0; i < studentNames.Length; i++)
                    {
                        while (!isMarkValid)
                        {
                            Console.WriteLine("Please enter mark for " + studentNames[i]);
                            mark = Int32.Parse(Console.ReadLine());
                            if (mark < 0 || mark > 100)
                            {
                                Console.WriteLine("Please enter a number between 0 and 100");
                            }
                            else
                            {

                                isMarkValid = true;
                            }
                        }
                    }
                    return studentMarks;

                }

                getStudentMarks(studentNames, studentMarks);

                for (int i = 0; i < studentNames.Length; i++)
                {
                    Console.WriteLine("Student name" + studentNames[i]);
                    Console.WriteLine("Student matriculation" + matriculationNumbers[i]);
                    Console.WriteLine("Student mark" + studentMarks[i]);
                }

            }
        }
    }
}
