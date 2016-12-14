using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Helpers;
using App5.ViewModel;
using App5.Model;

namespace App5
{
    [Activity(Label = "App5", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        private EditText m_namePerson;

        public EditText NamePerson
        {
            get { return m_namePerson ?? (m_namePerson = FindViewById<EditText>(Resource.Id.nameperson)); }
            set { m_namePerson = value; }
        }
        private Button m_addPerson;

        public Button AddPerson
        {
            get { return m_addPerson ?? (m_addPerson = FindViewById<Button>(Resource.Id.addperson)); }
            set { m_addPerson = value; }
        }
        private Button m_removePerson;
        public Button RemovePerson
        {
            get { return m_removePerson ?? (m_removePerson = FindViewById<Button>(Resource.Id.removeperson)); }
            set { m_removePerson = value; }
        }
        private ListView m_listPerson;

        public ListView ListPerson
        {
            get { return m_listPerson ?? (m_listPerson = FindViewById<ListView>(Resource.Id.listperson)); }
            set { m_listPerson = value; }
        }
        private Binding<Person, Person> m_bindingPerson;
        private Binding<int, int> m_bindingPosition;
        private MainViewModel Vm = App.Locator.Main;
        public int Position
        {
            get;
            set;
        }
        public Person person{get; set;}
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
           // ListPerson.Adapter = Vm.People.GetAdapter(GetPersonView);
            // Get our button from the layout resource,
            // and attach an event to it
            m_bindingPosition = this.SetBinding(() => Position, BindingMode.TwoWay);
            m_bindingPerson=this.SetBinding<Person>(()=>person??new Person(),BindingMode.TwoWay);
            AddPerson.SetCommand("Click", Vm.AddCommand,m_bindingPerson );
            RemovePerson.SetCommand("Click", Vm.RemoveCommand, m_bindingPosition);
            ListPerson.ItemClick += (sender, e) =>
            {
                Position = e.Position;
                Toast.MakeText(this, Position + "", ToastLength.Short).Show();
            };
        }
       
    }
}

