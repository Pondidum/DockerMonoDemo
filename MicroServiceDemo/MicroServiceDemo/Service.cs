using System;
using System.ServiceProcess;
using Microsoft.Owin.Hosting;
using Owin;

namespace MicroServiceDemo
{
	public partial class Service : ServiceBase
	{
		private IDisposable _app;

		public Service()
		{
			InitializeComponent();
		}

		public void StartConsole()
		{
			Console.WriteLine("Press any key to exit...");
			OnStart(new string[] { });

			Console.ReadKey();
			OnStop();
		}

		protected override void OnStart(string[] args)
		{
			_app = WebApp.Start("http://*:12345", app =>
			{
				app.UseWelcomePage("/");
			});
		}

		protected override void OnStop()
		{
			_app.Dispose();
		}
	}
}
