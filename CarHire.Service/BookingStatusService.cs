using CarHire_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHire.Service
{
    public class BookingStatusService
    {
        private List<BookingStatus> bookingstatuslist = new List<BookingStatus>
        {
            new BookingStatus
            {
                BookingStatusCode = 4164,
                BookingStatusDescription = " dfhjdh"

            }
        };
        public bool IsAlreadyRegistered(int bookingStatusCode)
        {
            var bookingStatus = bookingstatuslist.Where(a => a.BookingStatusCode == bookingStatusCode).FirstOrDefault();
            return bookingStatus != null;
        }
        public List<BookingStatus> GetBookingStatuses()
        {
            return bookingstatuslist;
        }

        public void Add(BookingStatus bookingstatus)
        {
            bookingstatuslist.Add(bookingstatus);
        }

        public List<BookingStatus> Delete(BookingStatus bookingstatus)
        {
            var selectedBookingStatus = bookingstatuslist.Where(
          a => a.BookingStatusCode == bookingstatus.BookingStatusCode).FirstOrDefault();
            bookingstatuslist.Remove(selectedBookingStatus);
            return bookingstatuslist;
        }

        public void Update(BookingStatus bookingstatus)
        {
            Delete(bookingstatus);
            bookingstatuslist.Add(bookingstatus);
        }

        //public BookingStatus? FindById(int BookingStatusCode)
        //{
        //    return bookingstatuslist.Where(unit => unit.BookingStatusCode == BookingStatusCode).FirstOrDefault();
        //}
    }
}
