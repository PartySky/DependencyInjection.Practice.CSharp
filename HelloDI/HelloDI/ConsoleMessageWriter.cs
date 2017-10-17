using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDI
{
	public class ConsoleMessageWriter : IMessageWriter
	{
		public void Write(string message)
		{
			Console.WriteLine(message);
		}
	}
}
