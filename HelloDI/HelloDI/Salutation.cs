using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDI
{
	public class Salutation
	{
		private readonly IMessageWriter writer;
		public Salutation(IMessageWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			this.writer = writer;
		}
		public void Exclaim()
		{
			this.writer.Write("Hello DI!");
		}

		[Fact]
		public void ExclaimWillWriteCorrectMessageToMessageWriter()
		{
			var writerMock = new Mock<IMessageWriter>();
			var sut = new Salutation(writerMock.Object);
			sut.Exclaim();
			writerMock.Verify(w => w.Write("Hello DI!"));
		}
	}
}
