using System;
using System.Collections.Generic;
using System.Text;

namespace EisenhowerCore
{
    public class TodoMatrix
    {

        private Dictionary<string, TodoQuarter> todoQuarters = new Dictionary<string, TodoQuarter>();

        public TodoMatrix()
        {
            //konstruktor
        }

        public Dictionary<string, TodoQuarter> GetQuarters()
        {
            return todoQuarters;
        }

        public TodoQuarter GetQuarter(string status)
        {
            if (todoQuarters.ContainsKey(status))
            {
                return todoQuarters[status];
            }
            return null; //je¿eli status nie istnieje
        }

        public void AddItem(string title, DateTime deadline, bool isImportant)
        {
            string quarterKey = isImportant ? "IU" : "IN";
            if (!todoQuarters.ContainsKey(quarterKey))
            {
                todoQuarters[quarterKey] = new TodoQuarter();
            }

            todoQuarters[quarterKey].AddItem(title, deadline);
        }

        public void AddItem(string title, DateTime deadline)
        {
            AddItem(title, deadline, false); //wywo³anie przeci¹¿onej metody z isimportatnt równ¹ false
        }
        public void AddItemsFromFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName)) //odczytanie danych z pliku i wrzucenie do todoquarters
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        string title = parts[0];
                        DateTime deadline = DateTime.ParseExact(parts[1], "dd-MM", null);
                        bool isImportant = !string.IsNullOrEmpty(parts[2]);
                        AddItem(title, deadline, isImportant);
                    }
                }
            }
        }

        public void SaveItemsToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName)) //wpisanie todo item do pliku
            {
                foreach (var quarter in todoQuarters.Values)
                {
                    foreach (var item in quarter.GetItems())
                    {
                        string isImportantString = item.IsImportant ? "Important" : "";
                        writer.WriteLine($"{item.Title}|{item.Deadline.ToString("dd-MM")}|{isImportantString}");
                    }
                }
            }
        }

        public void ArchiveItems()
        {
            foreach (var quarter in todoQuarters.Values)
            {
                quarter.ArchiveItems();
            }
        }

        public override string ToString()
        {
            //zwrócenie listy todoquaters jako string
        }
    }


}