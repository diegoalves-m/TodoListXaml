using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoList.model;
using Xamarin.Forms;

namespace TodoList.database
{
    public class TaskDataAccess
    {

        private SQLiteConnection _database;

        public TaskDataAccess()
        {
            _database = DependencyService.Get<IDatabase>().GetConnection();
            _database.CreateTable<Task>();
        }

        public List<Task> GetTasks()
        {
            return _database.Table<Task>().ToList();
        }

        public int Save(Task task)
        {
            return _database.Insert(task);
        }

        public int Update(Task task)
        {
            return _database.Update(task);
        }

        public int Delete(Task task)
        {
            return _database.Delete(task);
        }

    }
}
