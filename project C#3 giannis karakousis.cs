using System;
using System.Collections.Generic;

namespace project3_giannis_karakousis
{
    public class human
    {
        public string Fname, Lname, father, bday;
    }
    public class student
    {
        public string lesson1, lesson2, lesson3;
        public int vath1, vath2, vath3;
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
                Console.WriteLine("\tDwse 1 gia eisagwgi mathiti");
                Console.WriteLine("\tDwse 2 gia proboli olwn twn mathitwn");
                Console.WriteLine("\tDwse 3 gia diagrafi enos mathiti");
                Console.WriteLine("\tDwse 4 gia exodo apo tin efarmogi");
                Console.WriteLine("***************************************************");
                epilogi = Console.ReadLine();

                switch (epilogi)
                {
                    case "1"://insert
                        human newhuman = new human();
                        Console.WriteLine("Dwse to onoma tou mathiti");
                        newhuman.Fname = Console.ReadLine();
                        Console.WriteLine("Dwse to epitheto tou mathiti");
                        newhuman.Lname = Console.ReadLine();
                        Console.WriteLine("Dwse to onoma tou patros");
                        newhuman.father = Console.ReadLine();
                        Console.WriteLine("Dwse to etos gennisis");
                        newhuman.bday = Console.ReadLine();
                        student newstudent = new student();
                        Console.WriteLine("Dwse to onoma tou 1ou mathimatos");
                        newstudent.lesson1 = Console.ReadLine();
                        Console.WriteLine("Dwse tin bathmologia tou 1ou mathimatos");
                        newstudent.vath1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dwse to onoma tou 2ou mathimatos");
                        newstudent.lesson2 = Console.ReadLine();
                        Console.WriteLine("Dwse tin bathmologia tou 2ou mathimatos");
                        newstudent.vath2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dwse to onoma tou 3ou mathimatos");
                        newstudent.lesson3 = Console.ReadLine();
                        Console.WriteLine("Dwse tin bathmologia tou 3ou mathimatos");
                        newstudent.vath3 = Convert.ToInt32(Console.ReadLine());
                        humanlist.Add(newhuman);
                        studentlist.Add(newstudent);
                        break;

                    case "2"://show
                        if (humanlist.Count == 0)
                            Console.WriteLine("Den uparxei kanenas mathitis gia proboli");
                        for (int i = 0; i < humanlist.Count; i++)
                        {
                            Console.WriteLine("******************************************");
                            Console.WriteLine("{0}.\tFirst name: {1}", i, humanlist[i].Fname);
                            Console.WriteLine("\tLast name: {0}", humanlist[i].Lname);
                            Console.WriteLine("\tFather's name: {0}", humanlist[i].father);
                            Console.WriteLine("\tYear of birth: {0}", humanlist[i].bday);
                            Console.WriteLine("\tLessons: {0},{1},{2}", studentlist[i].lesson1, studentlist[i].lesson2, studentlist[i].lesson3);
                            float mo = 0.0F;
                            mo = (studentlist[i].vath1 + studentlist[i].vath2 + studentlist[i].vath3) / 3;
                            Console.WriteLine("\tGrades: {0},{1},{2}, Average grade: {3}", studentlist[i].vath1, studentlist[i].vath2, studentlist[i].vath3, mo);
                            Console.WriteLine("******************************************");
                        }
                        break;

                    case "3"://delete
                        if (humanlist.Count == 0)
                            Console.WriteLine("Den uparxei kanenas mathitis gia na diagrapseis");
                        else
                        {
                            for (int i = 0; i < humanlist.Count; i++)
                            {
                                Console.WriteLine("******************************************");
                                Console.WriteLine("{0}.\tFirst name: {1}", i, humanlist[i].Fname);
                                Console.WriteLine("\tLast name: {0}", humanlist[i].Lname);
                                Console.WriteLine("\tFather's name: {0}", humanlist[i].father);
                                Console.WriteLine("\tYear of birth: {0}", humanlist[i].bday);
                                Console.WriteLine("\tLessons: {0},{1},{2}", studentlist[i].lesson1, studentlist[i].lesson2, studentlist[i].lesson3);
                                float mo = 0.0F;
                                mo = (studentlist[i].vath1 + studentlist[i].vath2 + studentlist[i].vath3) / 3;
                                Console.WriteLine("\tGrades: {0},{1},{2}, Average grade: {3}", studentlist[i].vath1, studentlist[i].vath2, studentlist[i].vath3, mo);
                                Console.WriteLine("******************************************");
                            }
                            Console.WriteLine("Poion mathiti theleis na diagrapseis? Dwse arithmo:");
                            int epilogiMathiti = Convert.ToInt32(Console.ReadLine());

                            if (epilogiMathiti >= 1 && epilogiMathiti <= humanlist.Count)
                                humanlist.RemoveAt(epilogiMathiti - 1);
                            else
                                Console.WriteLine("Den uparxei autos o mathitis");
                        }
                        break;

                    case "4"://exit
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Dwse enan arithmo apo to 1 ews to 4!!!!");
                        break;
                }
            }
        }
    }
}
