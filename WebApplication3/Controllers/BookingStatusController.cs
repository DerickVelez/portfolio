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
        private static BookingStatusService _bookingstatusservice { get; set; } = new BookingStatusService();

        [HttpGet]
        public List<BookingStatus> Get()
        {
            return _bookingstatusservice.GetBookingStatuses();
        }
        [HttpPost]
        public BookingStatus Add(BookingStatus bookingStatus)
        {
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
