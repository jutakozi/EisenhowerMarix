using System;
using System.Collections.Generic;
using System.Text;

namespace EisenhowerCore {

    namespace Eisenhower_Matrix
    {
        internal class ToDoQuarter
        {

            private List<string> ToDoItems = new List<string>();
            ToDoItem todoItem = new ToDoItem();

            public ToDoQuarter()
            {
                List<string> ToDoQuarter = new List<string>();
            }

            public void AddItem(string title, string deadline)
            {
                var toDoItem = todoItem.CreateToDoItem(title, deadline);
                ToDoItems.Add(toDoItem);
            }

            public void RemoveItem(int index)
            {

            }
            public void ArchiveItems()
            {

            }

            public void GetItem(int index)
            {

            }

            public void GetItems()
            {

            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < ToDoItems.Count; i++)
                {
                    sb.AppendLine($"{i + 1}. {ToDoItems[i]}");
                }
                return sb.ToString();
            }

        }
    }