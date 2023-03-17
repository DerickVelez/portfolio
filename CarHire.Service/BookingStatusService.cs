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
        private List<BookingStatus> bookingstatuses = new List<BookingStatus>
        {
            new BookingStatus
            {
                BookingStatusCode = 4164,
                BookingStatusDescription = " dfhjdh"

            }
        };

        public List<BookingStatus> GetBookingStatuses()
        {
            return bookingstatuses;
        }

        public void Add(BookingStatus bookingstatus)
        {
            bookingstatuses.Add(bookingstatus);
        }

        public void Delete(BookingStatus bookingstatus)
        {
            bookingstatuses.Remove(bookingstatus);
        }

        public void Update(BookingStatus bookingstatus)
        {
            var selectedBookingStatus = bookingstatuses.Where(unit => unit.BookingStatusCode == bookingstatus.BookingStatusCode).FirstOrDefault();
            selectedBookingStatus = bookingstatus;
        }

        public BookingStatus? FindById(int BookingStatusCode)
        {
            return bookingstatuses.Where(unit => unit.BookingStatusCode == BookingStatusCode).FirstOrDefault();
        }
    }
}
