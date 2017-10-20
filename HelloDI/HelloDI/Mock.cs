using System;

namespace HelloDI
{
    internal class Mock<T>
    {
        internal IMessageWriter Object;

        public Mock()
        {
        }

        internal void Verify(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}