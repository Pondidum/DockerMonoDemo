using System;
using System.ServiceProcess;

namespace MicroServiceDemo
{
	static class Program
	{
		static void Main()
		{
			var service = new Service();

			if (Environment.UserInteractive)
			{
				service.StartConsole();
			}
			else
			{
				ServiceBase.Run(new ServiceBase[] { service });
			}
		}
	}
}
