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
    public class FakeUser : IUser
    {
        public string Password { get; set; }

        public int UserID { get; set; }

        public string Username { get; set; }
        public List<IUser> Friends { get; set; } = new List<IUser>();


        public FakeUser()
        {
            Username = "David";
            Password = "123";
        }

        public void Login(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

    }
}