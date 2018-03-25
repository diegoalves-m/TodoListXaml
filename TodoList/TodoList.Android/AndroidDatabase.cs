using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SQLite;
using TodoList;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidDatabase))]
namespace TodoList
{
    public class AndroidDatabase : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var database = "todoList.db3";

            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), database);

            return new SQLiteConnection(path);
        }
    }
}
