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

            //Arrange - ארגון הנתונים הנדרשים להפעלת הפונקציה הנבדקת

            //Act - הפעלת הפונקציה הנבדקת
            var result = _eventsController.Get();

            //Asser - הכרזה מה התוצאה הרצויה
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_ReturnOk()
        {
            //AAA

            //Arrange - ארגון הנתונים הנדרשים להפעלת הפונקציה הנבדקת
            var id = 1;

            //Act - הפעלת הפונקציה הנבדקת
            var result = _eventsController.Get(id);

            //Asser - הכרזה מה התוצאה הרצויה
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_ReturnNotFound()
        {
            //AAA

            //Arrange - ארגון הנתונים הנדרשים להפעלת הפונקציה הנבדקת
            var id = 4;

            //Act - הפעלת הפונקציה הנבדקת
            var result = _eventsController.Get(id);

            //Asser - הכרזה מה התוצאה הרצויה
            Assert.IsType<NotFoundResult>(result);
        }
    }
}