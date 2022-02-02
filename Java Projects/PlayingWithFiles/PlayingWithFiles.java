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