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
using App5.ViewModel;

namespace App5
{
    class App
    {
        private static ViewModelLocator locator;

        public static ViewModelLocator Locator
        {
            get { return App.locator ?? (locator=new ViewModelLocator()); }
            
        }
    }
}