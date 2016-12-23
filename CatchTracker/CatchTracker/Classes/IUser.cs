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

namespace CatchTracker.Classes
{
    public interface IUser
    {
        int UserID { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        void Login(string usernam, string password);
        List<IUser> Friends { get; set; }
    }
}