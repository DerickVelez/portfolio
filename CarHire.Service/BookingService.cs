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
        private List<Booking> bookinglist = new List<Booking>();
 
        //functionn for avoiding duplicates in Post method
        public string connectionString;

        public  BookingService(string connectionString)
        {
            this.connectionString = connectionString;
        }
       
        public bool IsAlreadyRegistered(int bookingID)
        {
            var bookingservice = bookinglist.Where(a => a.BookingID == bookingID).FirstOrDefault();
            return bookingservice != null;
        }

        public List<Booking> GetBookings()
        {
            return bookinglist;
        }

        public void Add(Booking booking)
        {
            bookinglist.Add(booking);
        }

        public List<Booking> Delete(Booking booking)
        {
            var selectedBooking = bookinglist.Where(
          a => a.BookingID == booking.BookingID).FirstOrDefault();
            bookinglist.Remove(selectedBooking);
            return bookinglist;
        }

        public void Update(Booking booking)
        {
           Delete(booking);
           bookinglist.Add(booking);
        }

        //public Booking? FindById(int bookingId)
        //{
        //    return bookinglist.Where(unit => unit.BookingID == bookingId).FirstOrDefault();
        //}
    }
}
