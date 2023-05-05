using CarHire.Service;
using CarHire_.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarHire.WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingStatusController : ControllerBase
    {
        private static BookingStatusService _bookingstatusservice;

        public BookingStatusController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ServerConnection");
            _bookingstatusservice = new BookingStatusService(connectionString);
        }

        [HttpGet]
        public List<BookingStatus> Get()
        {
            return _bookingstatusservice.GetBookingStatuses();
        }
        [HttpPost]
        public BookingStatus Add(BookingStatus bookingStatus)
        {
            var alreadyexist = _bookingstatusservice.IsAlreadyRegistered(bookingStatus.BookingStatusCode);
            if (alreadyexist)
                return null;
            _bookingstatusservice.Add(bookingStatus);
            return bookingStatus;
        }
        [HttpPut]
        public BookingStatus Update(BookingStatus booking)
        {
            _bookingstatusservice.Update(booking);
            return booking;
        }
        [HttpDelete]
        public BookingStatus Delete(BookingStatus bookingstatus)
        {
            _bookingstatusservice.Delete(bookingstatus);
            return bookingstatus;
        }

    }
}
