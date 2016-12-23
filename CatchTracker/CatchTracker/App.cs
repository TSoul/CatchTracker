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
using Autofac;
using CatchTracker.Classes;

namespace CatchTracker
{
    public class App : Application
    {
        public static IContainer Container { get; set; }
        public App(IntPtr h, JniHandleOwnership jho) : base(h, jho)
        {
        }

        public override void OnCreate()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<FakeUser>().As<IUser>().SingleInstance();

            //builder.RegisterType<Config>().AsSelf().AsImplementedInterfaces().SingleInstance();
            //builder.RegisterType<DeviceInfo>().AsSelf().SingleInstance();
            //builder.RegisterType<FakeSocketAPI>().As<ISocketAPI>().SingleInstance();
            //builder.RegisterType<FakeWebservice>().As<IWebService>().SingleInstance();
            //builder.RegisterInstance(new DBRepository()).AsSelf().SingleInstance();
            //builder.RegisterInstance(new LoginProvider()).AsSelf().SingleInstance();
            //builder.RegisterType<DeviceSettings>().AsSelf().SingleInstance();
            //builder.RegisterLogger(Logging.Logger.Instance);

            //builder.RegisterType<GPSManager>().AsSelf().SingleInstance();

            App.Container = builder.Build();

            base.OnCreate();
        }
    }
}