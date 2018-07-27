using NUnit.Framework;

namespace UnityDotNetLibrary
{
    public class LibraryTests
    {
        [Test]
        public void LibraryTestsSimplePasses()
        {
            var a = 5.5f;
            var b = -103f;
            var actual = Library.Add(a, b);
            var expected = a + b;
            Assert.That(actual, Is.EqualTo(expected).Within(float.Epsilon));
        }
    }
}
