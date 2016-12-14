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

namespace App5.Model
{
    public class Person
    {
        private string m_name;

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        private string m_address;

        public string Address
        {
            get { return m_address; }
            set { m_address = value; }
        }
    }
}