using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}


class Student : Person
{
    private int[] testScores;
    private int[] scores { get; set; }

    public Student(string firstName, string lastName, int id, int[] scores)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        this.scores = scores;
    }

    public string Calculate()
    {

        int sum = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            sum += this.scores[i];
        }

        int avarage = sum / scores.Length;

        if (avarage <= 100 && avarage >= 90)
        {
            return "O";
        }
        else if (avarage < 90 && avarage >= 80)
        {
            return "E";
        }
        else if (avarage < 80 && avarage >= 70)
        {
            return "A";
        }
        else if (avarage < 70 && avarage >= 55)
        {
            return "P";
        }
        else if (avarage < 55 && avarage >= 40)
        {
            return "D";
        }
        else
        {
            return "T";
        }
    }
}



class Solution12
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}