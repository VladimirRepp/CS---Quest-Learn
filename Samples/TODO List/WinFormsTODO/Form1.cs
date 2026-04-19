using TODO;

namespace WinFormsTODO
{
    public partial class Form1 : Form
    {
        private MyTaskController _myTaskController;

        public Form1()
        {
            InitializeComponent();
            _myTaskController = new MyTaskController();
        }

        private void PrintAllTask()
        {
            dataGridView.Rows.Clear();

            foreach(MyTask task in _myTaskController.Tasks)
            {
                dataGridView.Rows.Add(task.Text, task.Status);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTask.Text == "" || comboBoxStatus.Text == "")
            {
                MessageBox.Show("Не все поля введены!", "Внимане!");
                return;
            }

            MyTask newTask = new MyTask();
            newTask.Text = textBoxTask.Text;
            newTask.Status = comboBoxStatus.Text;

            _myTaskController.Add(newTask);

            PrintAllTask();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxTask.Text == "" || comboBoxStatus.Text == "")
            {
                MessageBox.Show("Не все поля введены!", "Внимане!");
                return;
            }

            int selectedIndex = dataGridView.CurrentRow.Index;
            if(selectedIndex == -1)
            {
                MessageBox.Show("Выберите строку в таблице!", "Внимане!");
                return;
            }

            MyTask newTask = new MyTask();
            newTask.Text = textBoxTask.Text;
            newTask.Status = comboBoxStatus.Text;

            _myTaskController.Edit(newTask, selectedIndex);

            PrintAllTask();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView.CurrentRow.Index;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Выберите строку в таблице!", "Внимане!");
                return;
            }

            _myTaskController.RemoveAt(selectedIndex);

            PrintAllTask();
        }
    }
}
