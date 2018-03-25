using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;
using TodoList.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(IOSDatabase))]
namespace TodoList.iOS
{
    public class IOSDatabase : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var database = "todoList.db3";
            var personalFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string libraryFolder = Path.Combine(personalFolder, "..", "Library");

            string path = Path.Combine(libraryFolder, database);

            return new SQLiteConnection(path);
        }
    }
}
