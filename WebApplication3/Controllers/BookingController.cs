using CarHire.Service;
using CarHire_.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarHire.WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private static BookingService _bookingservice { get; set; } = new BookingService();

        [HttpGet]
        public List<Booking> GetBookings()
        {
            return _bookingservice.GetBookings();
        }

        [HttpPost]
        public Booking Add(Booking booking)
        {
            bool alreadyregistered = _bookingservice.IsAlreadyRegistered(booking.BookingID);
            if (alreadyregistered)
                return null;
            _bookingservice.Add(booking);
            return booking;
        }
        [HttpPut]
        public Booking Update(Booking booking)
        {
            _bookingservice.Update(booking);
            return booking;
        }
        [HttpDelete]
        public Booking Delete(Booking booking)
        {
            _bookingservice.Delete(booking);
            return booking;
        }
    }
}
