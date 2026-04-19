namespace TODO
{
    // Контролер модели
    public class MyTaskController
    {
        private List<MyTask> _tasks;

        public List<MyTask> Tasks => _tasks;

        public MyTaskController()
        {
            _tasks = new List<MyTask>();
        }

        public void Add(MyTask task) 
        {
            if (task == null)
                return;

            _tasks.Add(task);
        }

        public void Remove(MyTask task) 
        {
            if (task == null)
                return;

            _tasks.Remove(task);
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _tasks.Count)
                return;

            _tasks.RemoveAt(index);
        }

        public void Edit(MyTask task, int index)
        {
            if (task == null)
                return;

            if (index < 0 || index >= _tasks.Count)
                return;

            _tasks[index].Text = task.Text;
            _tasks[index].Status = task.Status;
        }
    }
}
