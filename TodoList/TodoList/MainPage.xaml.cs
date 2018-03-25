using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoList.database;
using TodoList.model;
using TodoList.viewModel;
using Xamarin.Forms;

namespace TodoList
{
	public partial class MainPage : ContentPage
	{

        public Task TaskAux { get; set; }

        public MainPage()
		{
			InitializeComponent();

            BindingContext = new MainViewModel();

            bntAdd.Clicked += delegate {

                if (TaskAux != null)
                {
                    TaskAux.Name = Task.Text;
                    new TaskDataAccess().Update(TaskAux);
                    TaskAux = null;
                }
                else
                {
                    var task = new Task(name: Task.Text, isFinalized: false);
                    new TaskDataAccess().Save(task);
                }

                BindingContext = new MainViewModel();
                Task.Text = String.Empty;
            };

        }


        public void Delete(object sender, EventArgs args)
        {
            var task = (((MenuItem)sender).CommandParameter) as Task;
            new TaskDataAccess().Delete(task);
            BindingContext = new MainViewModel();
        }

        public void Edit(object sender, EventArgs args)
        {
            var task = (((MenuItem)sender).CommandParameter) as Task;

            Task.Text = task.Name;

            TaskAux = task;

        }

        public void ChangeStatus(object sender, EventArgs args)
        {
            var task = (((Button)sender).CommandParameter) as Task;

            if (!task.IsFinalized)
            {
                task.IsFinalized = true;
            }
            else
            {
                task.IsFinalized = false;
            }
            new TaskDataAccess().Update(task);
            BindingContext = new MainViewModel();

        }

    }
}
