using AutoFixture;
using AutoFixture.AutoMoq;
using NUnit.Framework;


namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private IFixture _fixture;
        [SetUp]
        public void Setup()
        {
            _fixture = new Fixture().Customize(new AutoMoqCustomization { ConfigureMembers = true });
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
            var newString = _fixture.Create<string>();
        }
    }
}