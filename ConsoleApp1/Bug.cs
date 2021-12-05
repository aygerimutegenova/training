using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Bug
    {
        public int Id;
        public DateTime CreationDate;
        public Priority Priority;
        public string Precondition;
        public string Summary;
        public Status Status;
        public int TestCaseId;
        public int StepNumber;
        public string ActualResult;
        public string ExpectedResult;
        public Bug()
        {
       
            
            }
      
    }
    public enum Priority
    {
        Low,
        Medium,
        High
    }

    public enum Status
    {
        New,
        InProgress,
        Failed,
        Done
    }

}
