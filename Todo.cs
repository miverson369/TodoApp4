using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp4
{
    internal class Todo
        {
            public static int ObjectCounter = 0;
            public int Id { get; set; }
            public string TaskDescription { get; set; }
            public DateTime DueDate { get; set; }
            public bool IsDone { get; set; }

            public Todo(string description, DateTime date, bool doneState)
        {
            ObjectCounter++;
            Id = ObjectCounter;
            TaskDescription = description;
            DueDate = date;
            IsDone = doneState;
        }

        public Todo(ReadOnlySpan<char> newTextBox, DateTime dateTime, bool v)
        {
        }

        public override string? ToString()
        {
            return $"{Id} - {DueDate} - {TaskDescription}";

        }
    }
}

   
