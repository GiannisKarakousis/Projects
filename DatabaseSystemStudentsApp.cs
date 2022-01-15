using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class human
    {
        public string Fname, Lname, father, bday;
    }
    public class student
    {
        public string lesson1, lesson2, lesson3;
        public int grade1, grade2, grade3;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<human> humanlist = new List<human>();
            List<student> studentlist = new List<student>();
            bool run = true;
            string epilogi = "";

            while (run == true)
            {
                Console.WriteLine("***************************************************");
                Console.WriteLine("\tPress 1 to add a student");
                Console.WriteLine("\tPress 2 to show all students");
                Console.WriteLine("\tPress 3 to delete a student");
                Console.WriteLine("\tPress 4 to exit the app");
                Console.WriteLine("***************************************************");
                epilogi = Console.ReadLine();

                switch (epilogi)
                {
                    case "1"://insert
                        human newhuman = new human();
                        Console.WriteLine("Give me the first name");
                        newhuman.Fname = Console.ReadLine();
                        Console.WriteLine("Give me the last name");
                        newhuman.Lname = Console.ReadLine();
                        Console.WriteLine("Give me the father's name");
                        newhuman.father = Console.ReadLine();
                        Console.WriteLine("Give me the date of birth");
                        newhuman.bday = Console.ReadLine();
                        student newStudent = new student();
                        Console.WriteLine("Give me the name of the first lesson");
                        newStudent.lesson1 = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Give me the grade of the first lesson (0-20)");
                            newStudent.grade1 = Convert.ToInt32(Console.ReadLine());
                        } while (newStudent.grade1 < 0 || newStudent.grade1 > 20);

                        Console.WriteLine("Give me the name of the second lesson");
                        newStudent.lesson2 = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Give me the grade of the second lesson (0-20)");
                            newStudent.grade2 = Convert.ToInt32(Console.ReadLine());
                        } while (newStudent.grade2 < 0 || newStudent.grade2 > 20);

                        Console.WriteLine("Give me the name of the third lesson");
                        newStudent.lesson3 = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Give me the grade of the third lesson (0-20)");
                            newStudent.grade3 = Convert.ToInt32(Console.ReadLine());
                        } while (newStudent.grade3 < 0 || newStudent.grade3 > 20);

                        humanlist.Add(newhuman);
                        studentlist.Add(newStudent);
                        break;

                    case "2"://show
                        if (humanlist.Count == 0)
                            Console.WriteLine("There are no students to show");
                        for (int i = 0; i < humanlist.Count; i++)
                        {
                            Console.WriteLine("***************************************************");
                            Console.WriteLine("{0}.\tFirst name: {1}", (i + 1), humanlist[i].Fname);
                            Console.WriteLine("\tLast name: {0}", humanlist[i].Lname);
                            Console.WriteLine("\tFather's name: {0}", humanlist[i].father);
                            Console.WriteLine("\tDate of birth: {0}", humanlist[i].bday);
                            Console.WriteLine("\tLessons: {0},{1},{2}", studentlist[i].lesson1, studentlist[i].lesson2, studentlist[i].lesson3);
                            float mo = 0.0F;
                            mo = (studentlist[i].grade1 + studentlist[i].grade2 + studentlist[i].grade3) / 3;
                            Console.WriteLine("\tGrades: {0},{1},{2}, Average grade: {3}", studentlist[i].grade1, studentlist[i].grade2, studentlist[i].grade3, mo);
                        }
                        break;

                    case "3"://delete
                        if (humanlist.Count == 0)
                            Console.WriteLine("There are no students for you to delete!");
                        else
                        {
                            for (int i = 0; i < humanlist.Count; i++)
                            {
                                Console.WriteLine("***************************************************");
                                Console.WriteLine("{0}.\tFirst name: {1}", (i + 1), humanlist[i].fname);
                                Console.WriteLine("\tLast name: {0}", humanlist[i].lname);
                                Console.WriteLine("\tFather's name: {0}", humanlist[i].father);
                                Console.WriteLine("\tYear of birth: {0}", humanlist[i].bday);
                                Console.WriteLine("\tLessons: {0},{1},{2}", studentlist[i].lesson1, studentlist[i].lesson2, studentlist[i].lesson3);
                                mo = (studentlist[i].grade1 + studentlist[i].grade2 + studentlist[i].grade3) / 3;
                                Console.WriteLine("\tGrades: {0},{1},{2}, Average grade: {3}", studentlist[i].grade1, studentlist[i].grade2, studentlist[i].grade3, mo);
                            }
                            Console.WriteLine("Who do you want to delete? Give a number");
                            int epilogiMathiti = Convert.ToInt32(Console.ReadLine());

                            if (epilogiMathiti >= 1 && epilogiMathiti <= humanlist.Count)
                                humanlist.RemoveAt(epilogiMathiti - 1);
                            else
                                Console.WriteLine("This student doesn't exist");
                            Console.WriteLine("Student deleted successfully!");
                        }
                        break;

                    case "4"://exit
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Give me a number between 1 and 4!!!!");
                        break;
                }
            }
        }
    }
}