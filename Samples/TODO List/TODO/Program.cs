namespace TODO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyTaskController myTaskController = new MyTaskController();

            myTaskController.Add(new MyTask()
            {
                Text = "Hello",
                Status = "InWork"
            });
            myTaskController.Add(new MyTask()
            {
                Text = "Hello_1",
                Status = "Done"
            });
            myTaskController.Add(new MyTask()
            {
                Text = "Hello_2",
                Status = "InCheck"
            });

            foreach (var task in myTaskController.Tasks)
            {
                Console.WriteLine($"{task.Text} - {task.Status}");
            }

            myTaskController.RemoveAt(0);

            foreach (var task in myTaskController.Tasks)
            {
                Console.WriteLine($"{task.Text} - {task.Status}");
            }

            myTaskController.Edit(new MyTask()
            {
                Text = "Hello_NEW",
                Status = "WORK"
            }, 0);

            foreach (var task in myTaskController.Tasks)
            {
                Console.WriteLine($"{task.Text} - {task.Status}");
            }
        }
    }
}
