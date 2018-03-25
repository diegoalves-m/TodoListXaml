using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.model
{
    [Table("Tasks")]
    public class Task
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsFinalized { get; set; }

        public Task()
        {
        }

        public Task(string name, bool isFinalized)
        {
            Name = name;
            IsFinalized = isFinalized;
        }
    }
}
