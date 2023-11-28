using BasicAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace UnitTests
{
    public class EventsControllerTest
    {
        private readonly EventsController _eventsController;

        public EventsControllerTest()
        {
            var context = new DataContextFake();
            _eventsController = new EventsController(context);
        }
        [Fact]
        public void Get_ReturnOk()
        {
            //AAA

            //Arrange - ����� ������� ������� ������ �������� ������

            //Act - ����� �������� ������
            var result = _eventsController.Get();

            //Asser - ����� �� ������ ������
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_ReturnOk()
        {
            //AAA

            //Arrange - ����� ������� ������� ������ �������� ������
            var id = 1;

            //Act - ����� �������� ������
            var result = _eventsController.Get(id);

            //Asser - ����� �� ������ ������
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_ReturnNotFound()
        {
            //AAA

            //Arrange - ����� ������� ������� ������ �������� ������
            var id = 4;

            //Act - ����� �������� ������
            var result = _eventsController.Get(id);

            //Asser - ����� �� ������ ������
            Assert.IsType<NotFoundResult>(result);
        }
    }
}