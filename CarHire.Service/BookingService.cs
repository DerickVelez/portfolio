using CarHire_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHire.Service
{
    public class BookingService
    {
        private List<Booking> Bookings = new List<Booking>
        {
            new Booking
            {
                BookingID = 456,
                BookingStatusCode = "FI",
                DateFrom = new DateTime(2020, 01, 32),
                DateTo = new DateTime(2021, 6, 2),
                ConfirmationLetterSent = " kldsjf",
                PaymentReceived = " dhdsfh",
            }
        };

        public List<Booking> GetBookings()
        {
            return Bookings;
        }

        public void Add(Booking booking)
        {
            Bookings.Add(booking);
        }

        public void Delete(Booking booking)
        {
            Bookings.Remove(booking);
        }

        public void Update(Booking booking)
        {
            var selectedBooking = Bookings.Where(unit => unit.BookingID == booking.BookingID).FirstOrDefault();
            selectedBooking = booking;
        }

        public Booking? FindById(int bookingId)
        {
            return Bookings.Where(unit => unit.BookingID == bookingId).FirstOrDefault();
        }
    }
}
