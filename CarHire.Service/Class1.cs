using CarHire_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHire.Service
{
    public class Class1
    {
        public List<Booking> bookinglist = new List<Booking> { };

        public List<Booking> GetBookings()
        {
            return bookinglist;
        }

        public void CreateBooking(Booking booking)
        {
            bookinglist.Add(booking);
        }

        public List<Booking> DeleteBooking(Booking booking)
        {
            //var finalBooking = bookinglist.Where(a => a.BookingID == booking.BookingID).FirstOrDefault();
            //return bookinglist.Remove(finalBooking);
        }
    }
}

