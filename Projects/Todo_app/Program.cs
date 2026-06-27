namespace Todo_app;

using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            List<bool> isDone = new List<bool>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nTO-DO APP ");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Mark Task as Done");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter task: ");
                    string newTask = Console.ReadLine();
                    tasks.Add(newTask);
                    isDone.Add(false);
                    Console.WriteLine("Task added!");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("\n--- Your Tasks ---");
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("No tasks yet!");
                    }
                    else
                    {
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            string status = isDone[i] ? "[Done]" : "[Pending]";
                            Console.WriteLine((i + 1) + ". " + tasks[i] + " " + status);
                        }
                    }
                }
                else if (choice == "3")
                {
                    Console.Write("Enter task number to mark as done: ");
                    int doneIndex = int.Parse(Console.ReadLine()) - 1;

                    if (doneIndex >= 0 && doneIndex < tasks.Count)
                    {
                        isDone[doneIndex] = true;
                        Console.WriteLine("Marked as done!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number!");
                    }
                }
                else if (choice == "4")
                {
                    Console.Write("Enter task number to delete: ");
                    int delIndex = int.Parse(Console.ReadLine()) - 1;

                    if (delIndex >= 0 && delIndex < tasks.Count)
                    {
                        Console.WriteLine("Deleted: " + tasks[delIndex]);
                        tasks.RemoveAt(delIndex);
                        isDone.RemoveAt(delIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number!");
                    }
                }
                else if (choice == "5")
                {
                    running = false;
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid option, try again.");
                }
            }
        }
    }










