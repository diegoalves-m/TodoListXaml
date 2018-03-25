using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoList.database;
using TodoList.model;

namespace TodoList.viewModel
{
    public class MainViewModel
    {

        public List<Task> Tasks { get; set; }

        public MainViewModel()
        {
            Tasks = new TaskDataAccess().GetTasks();
        }
    }
}
