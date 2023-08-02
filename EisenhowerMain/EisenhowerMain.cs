using System;

namespace EisenhowerCore
{
    public class EisenhowerMain
    {
        class Program
        {
            static void Main()
            {
                DateTime deadline1 = new DateTime(2022, 6, 12, 12, 0, 0);
                TodoItem doneItem = new TodoItem("submit assignment", deadline1);
                doneItem.Mark();

                DateTime deadline2 = new DateTime(2022, 6, 28, 12, 0, 0);
                TodoItem undoneItem = new TodoItem("submit assignment", deadline2);

                Console.WriteLine(doneItem.ToString());    // [x] 12-06 submit assignment
                Console.WriteLine(undoneItem.ToString());  // [ ] 28-06 submit assignment
            }
        }

    }
}
