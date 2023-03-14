using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Diagnostics;


namespace   Quiz.ConsoleApp
{
  class Program
  {
    static void Main(string[]args)
    {

      Console.WriteLine("Activity Quiz");
      Thread.Sleep(1000);
      Console.WriteLine("Instruction : Answer the following question using your knowledge");
      Thread.Sleep(1000);
      Console.WriteLine("There will be 10 question only");
      Thread.Sleep(1000);
      Console.WriteLine("Goodluck!!");
      Thread.Sleep(1000);
      Console.WriteLine("");



        Stopwatch timer = new Stopwatch();


        string[] answer = {"Lyra", 
                            "Scorpius", 
                            "Gemini", 
                            "Canis Major", 
                            "Aries", 
                            "Virgo", 
                            "Cancer", 
                            "Leo", 
                            "Pisces", 
                            "Taurus"};

        string answer1; string answer2; string answer3; string answer4; string answer5;
        string answer6; string answer7; string answer8; string answer9; string answer10;
        var points = 0;

        Console.WriteLine("1. The constellation is associated with the myth of the Greek musician and poet Orpheus.");
        Console.Write("answer :");
        timer.Start();
        answer1 = Console.ReadLine();
        long time = timer.ElapsedMilliseconds;
        if(answer1  ==  answer[0] && time < 60000)
        {
            points += 1;
            Console.WriteLine("Your answer is correct!");
            timer.Stop();
        }
        else if (answer1 != answer[0] && time < 60000)
        {
            Console.WriteLine("Incorrect!");
            timer.Stop();
        }
        else
        {
            Console.WriteLine("You're run out of time.");
            timer.Stop();
        }
//second question
        Console.WriteLine("2. It represents the scorpion and is associated with the story of Orion in Greek mythology.");
        Console.Write("answer :");
        timer.Restart();
        answer2 = Console.ReadLine();
        long time1 = timer.ElapsedMilliseconds;
        if(answer2  ==  answer[1] && time1 < 60000)
        {
            points += 1;
            Console.WriteLine("Your answer is correct!");
            timer.Stop();
        }
        else if (answer2 != answer[1] && time1 < 60000)
        {
            Console.WriteLine("Incorrect!");
            timer.Stop();
        }
        else
        {
            Console.WriteLine("You're run out of time.");
            timer.Stop();
        }
//third question
        Console.WriteLine("3. It is located in the northern celestial hemisphere. Its name means “the twins” in Latin.");
        Console.Write("answer :");
        timer.Restart();
        answer3 = Console.ReadLine();
        long time2 = timer.ElapsedMilliseconds;
        if(answer3  ==  answer[2] && time2 < 60000)
        {
            points += 1;
            Console.WriteLine("Your answer is correct!");
            timer.Stop();
        }
        else if (answer3 != answer[2] && time2 < 60000)
        {
            Console.WriteLine("Incorrect!");
            timer.Stop();
        }
        else
        {
            Console.WriteLine("You're run out of time.");
            timer.Stop();
        }
//four question
        Console.WriteLine("4. Its name means “the greater dog” in Latin, and represents the bigger dog following Orion, the hunter in Greek mythology.");
        Console.Write("answer :");
        timer.Restart();
        answer4 = Console.ReadLine();
        long time3 = timer.ElapsedMilliseconds;
        if(answer4  ==  answer[3] && time3 < 60000)
        {
            points += 1;
            Console.WriteLine("Your answer is correct!");
            timer.Stop();
        }
        else if (answer4 != answer[3] && time3 < 60000)
        {
            Console.WriteLine("Incorrect!");
            timer.Stop();
        }
        else
        {
            Console.WriteLine("You're run out of time.");
            timer.Stop();
        }
//fifth question
        Console.WriteLine("5. It is usually associated with the story of the Golden Fleece in Greek mythology.");
        Console.Write("answer :");
        timer.Restart();
        answer5 = Console.ReadLine();
        long time4 = timer.ElapsedMilliseconds;
        if(answer5  ==  answer[4] && time4 < 60000)
        {
            points += 1;
            Console.WriteLine("Your answer is correct!");
            timer.Stop();
        }
        else if (answer5 != answer[4] && time4 < 60000)
        {
            Console.WriteLine("Incorrect!");
            timer.Stop();
        }
        else
        {
            Console.WriteLine("You're run out of time.");
            timer.Stop();
        }
//sixth question
        Console.WriteLine("6. Its is a constellation lies in the southern sky. Its name means “virgin” in Latin.");
        Console.Write("answer :");
        timer.Restart();
        answer6 = Console.ReadLine();
        long time5 = timer.ElapsedMilliseconds;
        if(answer6  ==  answer[5] && time5 < 60000)
        {
            points += 1;
            Console.WriteLine("Your answer is correct!");
            timer.Stop();
        }
        else if (answer6 != answer[5] && time5 < 60000)
        {
            Console.WriteLine("Incorrect!");
            timer.Stop();
        }
        else
        {
            Console.WriteLine("You're run out of time.");
            timer.Stop();
        }
//seventh question
        Console.WriteLine("7. Contains a number of famous deep sky objects, among them the open cluster Praesepe, also known as the Beehive Cluster");
        Console.Write("answer :");
        timer.Restart();
        answer7 = Console.ReadLine();
        long time6 = timer.ElapsedMilliseconds;
        if(answer7  ==  answer[6] && time6 < 60000)
        {
            points += 1;
            Console.WriteLine("Your answer is correct!");
            timer.Stop();
        }
        else if (answer7 != answer[6] && time6 < 60000)
        {
            Console.WriteLine("Incorrect!");
            timer.Stop();
        }
        else
        {
            Console.WriteLine("You're run out of time.");
            timer.Stop();
        }
//eight question
        Console.WriteLine("8. This constellation lies in the northern sky. It is one of the zodiac constellations and one of the largest constellations in the sky.");
        Console.Write("answer :");
        timer.Restart();
        answer8 = Console.ReadLine();
        long time7 = timer.ElapsedMilliseconds;
        if(answer8  ==  answer[7] && time7 < 60000)
        {
            points += 1;
            Console.WriteLine("Your answer is correct!");
            timer.Stop();
        }
        else if (answer8 != answer[7] && time7 < 60000)
        {
            Console.WriteLine("Incorrect!");
            timer.Stop();
        }
        else
        {
            Console.WriteLine("You're run out of time.");
            timer.Stop();
        }
//nine question
        Console.WriteLine("9. I lies between Aries constellation to the east and Aquarius to the west.");
        Console.Write("answer :");
        timer.Restart();
        answer9 = Console.ReadLine();
        long time8 = timer.ElapsedMilliseconds;
        if(answer9  ==  answer[8] && time8 < 60000)
        {
            points += 1;
            Console.WriteLine("Your answer is correct!");
            timer.Stop();
        }
        else if (answer9 != answer[8] && time8 < 60000)
        {
            Console.WriteLine("Incorrect!");
            timer.Stop();
        }
        else
        {
            Console.WriteLine("You're run out of time.");
            timer.Stop();
        }
//Ten Question
        Console.WriteLine("10. A large constellation in the northern sky. Its name means “bull” in Latin.");
        Console.Write("answer :");
        timer.Restart();
        answer10 = Console.ReadLine();
        long time9 = timer.ElapsedMilliseconds;
        if(answer10  ==  answer[9] && time9 < 60000)
        {
            points += 1;
            Console.WriteLine("Your answer is correct!");
            timer.Stop();
        }
        else if (answer10 != answer[9] && time9 < 60000)
        {
            Console.WriteLine("Incorrect!");
            timer.Stop();
        }
        else
        {
            Console.WriteLine("You're run out of time.");
            timer.Stop();
        }
        Console.WriteLine("Your Final points is " + points);


    }
  }  
}
