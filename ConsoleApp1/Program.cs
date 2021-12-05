using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            Bug bug = new Bug();


            Fill(ref bug.Id, 
                ref bug.CreationDate,
            ref bug.Priority,
            ref bug.Summary,
            ref bug.Precondition,
            ref bug.Status,
            ref bug.TestCaseId,
            ref bug.StepNumber,
            ref bug.ActualResult,
            ref bug.ExpectedResult);

            Print(bug.Id,
             bug.CreationDate,
             bug.Priority,
             bug.Summary,
             bug.Precondition,
             bug.Status,
             bug.TestCaseId,
             bug.StepNumber,
             bug.ActualResult,
             bug.ExpectedResult);

        }
        public static void Fill( ref int id,
        ref DateTime creationDate,
        ref Priority priority,
        ref string precondition,
        ref string summary,
        ref Status status,
        ref int testCaseId,
        ref int stepNumber,
        ref string actualResult,
        ref string expectedResult) 
        {
            Console.Write("Enter ID: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Creation Date in format 'dd.mm.yyyy 00:00:00': ");
            DateTime CreationDate = (DateTime) Enum.Parse(typeof(DateTime),Console.ReadLine());
            Console.Write("Enter Priority (High, Low Medium): ");
            Priority Priority = (Priority)Enum.Parse(typeof(Priority), Console.ReadLine());
            Console.Write("Enter Precondition: ");
            string Precondition = Console.ReadLine();
            Console.Write("Enter Summary: ");
            string Summary = Console.ReadLine();
            Console.Write("Enter Status(New,InProgress,Failed,Done): ");
            Status Status = (Status)Enum.Parse(typeof(Status), Console.ReadLine());
            Console.Write("Enter Test Case Id: ");
            int TestCaseId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Step Number: ");
            int StepNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Actual Result: ");
            string ActualResult = Console.ReadLine();
            Console.Write("Enter Expected Result: ");
            string ExpectedResul = Console.ReadLine();
        }
        public static void Print(int id,
             DateTime creationDate,
             Priority priority,
             string summary,
             string precondition,
             Status status,
             int testCaseId,
             int stepNumber,
             string actualResult,
             string expectedResult)

               
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Creation Date: " + creationDate);
            Console.WriteLine("Precondition: " + precondition);
            Console.WriteLine("Priority: " + priority);
            Console.WriteLine("Summary: " + summary);
            Console.WriteLine("Status: " + status);
            Console.WriteLine("Test Case Id:" + testCaseId);
            Console.WriteLine("Step Number: " + stepNumber);
            Console.WriteLine("Actual Result: " + actualResult);
            Console.WriteLine("Expected Result:" + expectedResult);

        }

        
    }
            
          
        }
    

