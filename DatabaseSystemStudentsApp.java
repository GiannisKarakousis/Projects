package databasesystemstudentsapp;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

class Human {
    String fname, lname, father, bday;
}

class Student {
    String lesson1, lesson2, lesson3;
    int grade1, grade2, grade3;
}


public class DatabaseSystemStudentsApp {

    public static void main(String[] args) {
        List<Human> humanList = new ArrayList<Human>();
        List<Student> studentList = new ArrayList<Student>();
        Scanner input = new Scanner(System.in);
        boolean run = true;
        String choice = "";
        int average;
        
        while(run == true){
            System.out.println("***************************************************");
            System.out.println("\tPress 1 to add a student");
            System.out.println("\tPress 2 to show all students");
            System.out.println("\tPress 3 to delete a student");
            System.out.println("\tPress 4 to exit the app");
            System.out.println("***************************************************");
            choice = input.next();
            
            switch(choice){
                case "1": //add
                    Human newHuman = new Human();
                    System.out.println("Give me the first name");
                    newHuman.fname = input.next();
                    System.out.println("Give me the last name");
                    newHuman.lname = input.next();
                    System.out.println("Give me the father's name");
                    newHuman.father = input.next();
                    System.out.println("Give me the date of birth");
                    newHuman.bday = input.next();
                    Student newStudent = new Student();
                    System.out.println("Give me the name of the first lesson");
                    newStudent.lesson1 = input.next();
                    do {
                        System.out.println("Give me the grade of the first lesson (0-20)");
                        newStudent.grade1 = input.nextInt();
                    } while (newStudent.grade1 < 0 || newStudent.grade1 > 20);
                    System.out.println("Give me the name of the second lesson");
                    newStudent.lesson2 = input.next();
                    do {
                        System.out.println("Give me the grade of the second lesson (0-20)");
                        newStudent.grade2 = input.nextInt();
                    } while (newStudent.grade2 < 0 || newStudent.grade2 > 20);
                    System.out.println("Give me the name of the third lesson");
                    newStudent.lesson3 = input.next();
                    do {
                        System.out.println("Give me the grade of the third lesson (0-20)");
                        newStudent.grade3 = input.nextInt();
                    } while (newStudent.grade3 < 0 || newStudent.grade3 > 20);
                    humanList.add(newHuman);
                    studentList.add(newStudent);
                    break;
                    
                case "2": //show
                    if (humanList.size() == 0)
                        System.out.println("There are no students to show");
                    for (int i = 0; i < humanList.size(); i++){
                        System.out.println("***************************************************");
                        System.out.println((i+1) + "\tFirst name: " + humanList.get(i).fname);
                        System.out.println("\tLast name: " + humanList.get(i).lname);
                        System.out.println("\tFather's name: " + humanList.get(i).father);
                        System.out.println("\tDate of birth: " + humanList.get(i).bday);
                        System.out.println("\tLessons: " + studentList.get(i).lesson1 + ", " + studentList.get(i).lesson2 + ", " + studentList.get(i).lesson3);
                        average = (studentList.get(i).grade1 + studentList.get(i).grade2 + studentList.get(i).grade3) / 3;
                        System.out.println("\tGrades: " + studentList.get(i).grade1 + ", " + studentList.get(i).grade2 + ", " + studentList.get(i).grade3 + ", Average grade: " + average);
                    }
                    break;
                    
                case "3": //delete
                    if (humanList.size() == 0)
                        System.out.println("There are no students for you to delete");
                    else {
                        for (int i = 0; i < humanList.size(); i++){
                            System.out.println("***************************************************");
                            System.out.println((i+1) + "\tFirst name: " + humanList.get(i).fname);
                            System.out.println("\tLast name: " + humanList.get(i).lname);
                            System.out.println("\tFather's name: " + humanList.get(i).father);
                            System.out.println("\tDate of birth: " + humanList.get(i).bday);
                            System.out.println("\tLessons: " + studentList.get(i).lesson1 + ", " + studentList.get(i).lesson2 + ", " + studentList.get(i).lesson3);
                            average = (studentList.get(i).grade1 + studentList.get(i).grade2 + studentList.get(i).grade3) / 3;
                            System.out.println("\tGrades: " + studentList.get(i).grade1 + ", " + studentList.get(i).grade2 + ", " + studentList.get(i).grade3 + ", Average grade: " + average);
                        }
                        System.out.println("Who do you want to delete? Give me a number");
                        int schoice = input.nextInt();
                        
                        if (schoice >= 1 && schoice <= humanList.size())
                            humanList.remove(schoice - 1);
                        else
                            System.out.println("This student doesn't exist");
                        System.out.println("Student deleted successfully!");
                    }
                    break;
                    
                case "4": //exit
                    run = false;
                    break;
                    
                default:
                    System.out.println("Give me a number between 1 and 4!!!");
                    break;
            }
        }
    }
    
}
