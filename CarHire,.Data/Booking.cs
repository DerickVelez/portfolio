namespace CarHire_.Data
{
    public record Booking
    (
        int BookingID,
         DateTime DateFrom,
         DateTime DateTo,
         string ConfirmationLetterSent,
         string PaymentReceived,
         int RegNumber,
         string BookingStatusCode,
         int CustomerID
    );
        }