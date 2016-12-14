using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using App5.Model;

namespace App5.ViewModel
{
    class MainViewModel:ViewModelBase
    {
       

        public RelayCommand<Person> AddCommand
        {
            get; 
            private set;
        }
       
        public RelayCommand<int> RemoveCommand
        {
            get;
            private set;
        }
        public ObservableCollection<Person> People { get; private set; }
        public MainViewModel()
        {
            AddCommand = new RelayCommand<Person>(AddPerson);
            RemoveCommand = new RelayCommand<int>(RemovePerson);
            People=new ObservableCollection<Person>();

        }
        public void AddPerson(Person person)
        {
            People.Add(person);
        }
        public void RemovePerson(int position)
        {
            People.RemoveAt(position);
        }
    }
}