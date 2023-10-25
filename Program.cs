using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static int currentId = 1;
        static void Main(string[] args)
        {
            List<Quiz> quizzes = new List<Quiz>();

            bool running = true;
            while (running)
            {
                Console.WriteLine("=========================");
                Console.WriteLine("Welcom to Quiz World");
                Console.WriteLine("=========================");
                Console.WriteLine("1. create new quiz");
                Console.WriteLine("2. Solve a quiz");
                Console.WriteLine("3. Show quizzes");
                Console.WriteLine("0. Quit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Quiz quiz1 = new Quiz();
                        quiz1.Id= currentId++;
                        Console.WriteLine("Enter quiz name:");
                        quiz1.Name = Console.ReadLine();
                        quiz1.Questions = new List<Question>();
                        Console.WriteLine("How many questions do you want add?");
                        int questionCount = int.Parse(Console.ReadLine());
                        for (int i = 0; i <= questionCount; i++)
                        {
                            Question question = new Question();
                            question.Id = i;
                            Console.WriteLine($"Enter question: {i} ");
                            question.Text = Console.ReadLine();

                            question.Variants = new List<string>();
                            for (int j = 0; j <= 3; j++)
                            {
                                Console.WriteLine($"Enter variant {j} question {i} ");
                                question.Variants.Add(Console.ReadLine());
                            }

                            Console.WriteLine("Enter correct variant: ");
                            question.CorrectVariant = int.Parse(Console.ReadLine());
                            quiz1.Questions.Add(question);
                        }
                        quizzes.Add(quiz1);
                        Console.WriteLine($"Quiz: {quiz1.Name} - ID: {quiz1.Id} yaradildi.\n");
                        break;
                    case "2":
                        Console.WriteLine("\nDaxil olmaq ucun id-i daxil edin:");
                        int quizId = int.Parse(Console.ReadLine());
                        Quiz quiz= quizzes.Find(q => q.Id == quizId);

                        if (quiz!=null)
                        {
                            int point = 0;                            
                            Console.Write($"Solving {quiz.Name} :\n");
                            foreach (var question in quiz.Questions)
                            {
                                Console.WriteLine(question.Text);
                                for (int i = 0; i < question.Variants.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {question.Variants[i]}");
                                }
                                Console.WriteLine("Your answer: ");
                                int answer = int.Parse(Console.ReadLine());
                                if (answer == question.CorrectVariant)
                                {
                                    point++;
                                }
                            }
                                Console.WriteLine($"\nPoint: {point} - {quiz.QuestionCount} ");
                        }
                        else
                        {
                            Console.WriteLine("Quiz tapilmadi.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("\nShow Quizzes: ");
                        foreach (var quiz2 in quizzes)
                        {
                            Console.WriteLine($"ID: {quiz2.Id} - Name: {quiz2.Name}");
                        }
                        Console.WriteLine();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Yanlish daxil etdiniz.");
                        break;
                }
            }
        }
    }
}