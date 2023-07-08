using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using mcordovaS5a.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly:Xamarin.Forms.Dependency(typeof(MensajeAndroid))]

namespace mcordovaS5a.Droid
{
    internal class MensajeAndroid : Mensaje
    {
        public void longAlert(string mensaje)
        {
            //metodo
           Toast.MakeText(Application.Context,mensaje, ToastLength.Long).Show();   
        }

        public void shortAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Short).Show();
        }
    }
}