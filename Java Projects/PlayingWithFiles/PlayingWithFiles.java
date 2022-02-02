package playingwithfiles;

import java.io.File;
import java.util.Formatter;

public class PlayingWithFiles {

    public static void main(String[] args) {
        try {
            //File f = new File("D:\\testFiles"); //first we create the file
            //f.mkdir(); // we make it a directory
            Formatter x = new Formatter("D:\\testFiles\\test.txt"); // then we make our txt file
            x.format("%s %s %s", "1", "John", "Smith\r\n"); // and we add things in it
            x.format("%s %s %s", "2", "Amy", "Brown");
            x.close(); // its good to close the file when you finish working on it
        } catch(Exception e) {
            System.out.println("Something went wrong");
        }
      }
    
}

/*

*/










































/*
            File x = new File("C:\\Users\\johnp\\Desktop\\shit\\shit.txt");
            Scanner sc = new Scanner(x);
            System.out.println(sc.next());
            System.out.println(sc.next());
            sc.close();
     try{
            Formatter f = new Formatter("C:\\Users\\johnp\\Desktop\\shit\\shit1.txt");
            f.format("%s %s %s", "1", "amy", "bitch\r\n");
            f.format("%s %s %s", "2", "john", "shit");
            f.close();
        }catch(Exception e){
            System.out.println("Shit son, where it at?");
        }
*/