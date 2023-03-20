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
        private List<Booking> bookinglist = new List<Booking>
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
            return bookinglist;
        }

        public void Add(Booking booking)
        {
            bookinglist.Add(booking);
        }

        public void Delete(Booking booking)
        {
            bookinglist.Remove(booking);
        }

        public void Update(Booking booking)
        {
            var selectedBooking = bookinglist.Where(
                a => a.BookingID == booking.BookingID).FirstOrDefault();
            bookinglist.Remove(selectedBooking);
            bookinglist.Add(booking);
        }

        public Booking? FindById(int bookingId)
        {
            return bookinglist.Where(unit => unit.BookingID == bookingId).FirstOrDefault();
        }
    }
}
