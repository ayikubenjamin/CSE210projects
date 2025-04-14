using System;

class Program
{
    static void Main(string[] args)
    {
       Assignment assignment1 = new Assignment("Jeremy Kobby", "Alphabets");
       Console.WriteLine(assignment1.GetSummary());

       MathAssigment assigment2 = new MathAssigment("Benjamin Ayiku", "Calculus", "Section 2.15", "Problems 5-10");
       Console.WriteLine(assigment2.GetSummary());
       Console.WriteLine(assigment2.HomeWorkList());

       WritingAssingment assingment3 = new WritingAssingment("Sheriff Simms", "African Literature", "In The Chest of A Woman");
       Console.WriteLine(assingment3.GetSummary());
       Console.WriteLine(assingment3.GetWritingInfo());
    }
}