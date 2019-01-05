using AutoFixture;
using AutoFixture.AutoMoq;
using BLL;
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
        public void GetExcelDTO_ShouldReturnExcelDto()
        {
            var excelLoaderService = _fixture.Create<ExcelLoaderService>();
            var excelDto = excelLoaderService.GetExcelDtoFromFile();
            
        }
    }
}