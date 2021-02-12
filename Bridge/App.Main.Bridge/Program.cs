using System;
using Base.Interfaces;
using Imp.Quizzes;

namespace App.Main.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Take a Spin The Wheel Quiz.....");
            IQuiz quiz = new SpinTheWheelQuiz();
            quiz.TakeQuiz();
            Console.WriteLine();


            Console.WriteLine("Lets Take a TRUE or FALSE Quiz.....");
            IQuiz quiz2 = new TrueOrFalseQuiz();
            quiz2.TakeQuiz();
            Console.WriteLine();
        }
    }
}
