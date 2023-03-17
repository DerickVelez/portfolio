namespace CarHire_.Data
{
    public class Booking
    {
        public int BookingID { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public string ConfirmationLetterSent { get; set; }

        public string PaymentReceived { get; set; }

        public int RegNumber { get; set; }

        public string BookingStatusCode { get; set; }

        public int CustomerID { get; set; }
    }
}