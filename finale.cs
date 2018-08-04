using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace scanTron
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("C:\\exam.txt");
            String line;
            string[] tokens;
            int id;
            string result = lines[0];
            int l = lines.Length - 1;
            int marks = 0;
            int s = result.Length;
            int[] correct = new int[20];



            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("c:\\exam.txt");
                //Read the first line of text
                line = sr.ReadLine();
                

                line = sr.ReadLine();
                tokens = line.Split();

               /*displays first id and assigns id*/
                id = Convert.ToInt32(tokens[0]);
                

                    //output table with student number and marks
                    Console.WriteLine("**********MCQ STUDENT EXAM REPORT**********");
                Console.WriteLine("Student number \t \t Mark");


                for (int i = 0; i < 20; i++)
                    correct[i] = 0;
                for (int i = 1; i < l; i++)
                {
                    string[] scores = lines[i].Split();
                    for (int j = 0; j < 20; j++)
                    {
                        if (scores[1][j] == result[j])
                        {
                            marks += 4;
                            correct[j] += 1;
                        }
                        else if (scores[1][j] != result[j] && (!scores[1][j].Equals("X")))
                            marks -= 1;
                        else
                            marks += 0;
                    }
                    //ADDED THIS
                   line = sr.ReadLine();
                    tokens = line.Split();
                    Console.Write(" \t \t \t " + marks+"\n"+tokens[0]);

                    marks = 0;
                }
               

                //to count the entries1/2------------------------
                int counter = 0;
                /*while id is not 0*/
                while (id != 0)
                {
                    //to count the entries2/2------------------------

                    counter++;

                    //Reads the next line GOT RID OF THIS
                   // line = sr.ReadLine();
                   // tokens = line.Split();

                    //displays all ids on screen-------------------
                    //Console.WriteLine("     " + id + "\t \t ");


                    /*displays all ids except first*/
                    id = Convert.ToInt32(tokens[0]);


                }
                
                Console.WriteLine("");
                Console.WriteLine("");
                //output table with question num and answer keys
                Console.WriteLine("total number of examinations marked:" + counter);
                Console.WriteLine("number of correct responses for each question: ");

                Console.WriteLine("question: " + "1\t2\t3\t4\t5\t6\t7\t8\t9\t10");
                Console.Write("#correct: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(correct[i]+"\t");
                }
              
                Console.WriteLine("\n");

                Console.WriteLine("question: " + "11\t12\t13\t14\t15\t16\t17\t18\t19\t20");
                Console.Write("#correct: ");
                for (int i = 10; i < 20; i++)
                {
                    Console.Write(correct[i] + "\t");
                }

                
                //close the file
                sr.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            
            Console.WriteLine("\n Press any key to exit.");
            System.Console.ReadKey();




        }


    }
}