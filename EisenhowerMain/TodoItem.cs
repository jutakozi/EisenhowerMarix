using System;

namespace EisenhowerCore
{
    public class TodoItem
    {
    // Atrybuty
    public string Title { get; set; }
    public DateTime Deadline { get; set; }
    public bool IsDone { get; set; }

    // Konstruktor
    public TodoItem(string title, DateTime deadline)
    {
        Title = title;
        Deadline = new DateTime(2020, deadline.Month, deadline.Day, deadline.Hour, deadline.Minute, deadline.Second);
        IsDone = false; // Wartoœæ domyœlna to false
    }
    }    // Getter dla pola title
    public string GetTitle()
    {
        return title;
    }

    // Getter dla pola deadline
    public DateTime GetDeadline()
    {
        return deadline;
    }

    // Metoda do oznaczania zadania jako zrobione
    public void Mark()
    {
        isDone = true;
    }

    // Metoda do odznaczania zadania jako niezrobione
    public void Unmark()
    {
        isDone = false;
    }

    // Metoda zwracaj¹ca sformatowany string z informacjami o todoItem
    // Format deadline: 'day-month'
    public override string ToString()
    {
        string status = isDone ? "[x]" : "[ ]";
        string formattedDeadline = deadline.ToString("dd-MM");
        return $"{status} {formattedDeadline} {title}";
    }
}}