﻿using CarHire_.Data;
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

        public List<BookingStatus> GetBookingStatuses()
        {
            return bookingstatuslist;
        }

        public void Add(BookingStatus bookingstatus)
        {
            bookingstatuslist.Add(bookingstatus);
        }

        public void Delete(BookingStatus bookingstatus)
        {
            bookingstatuslist.Remove(bookingstatus);
        }

        public void Update(BookingStatus bookingstatus)
        {
            var selectedBookingStatus = bookingstatuslist.Where(
                a => a.BookingStatusCode == bookingstatus.BookingStatusCode).FirstOrDefault();
            bookingstatuslist.Remove(selectedBookingStatus);
            bookingstatuslist.Add(bookingstatus);
        }

        public BookingStatus? FindById(int BookingStatusCode)
        {
            return bookingstatuslist.Where(unit => unit.BookingStatusCode == BookingStatusCode).FirstOrDefault();
        }
    }
}
