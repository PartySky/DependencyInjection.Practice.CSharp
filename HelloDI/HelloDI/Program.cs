using System;

namespace HelloDI
{
    class Program
    {
        static void Main(string[] args)
        {
			//IMessageWriter writer = new ConsoleMessageWriter();
			IMessageWriter writer = new SecureMessageWriter(new ConsoleMessageWriter());
			var salutation = new Salutation(writer);
			salutation.Exclaim();
		}
    }
}

