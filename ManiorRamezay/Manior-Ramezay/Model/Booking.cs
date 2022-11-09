using System;
using Interface;

namespace Model
{

    public class Booking : IBooking
    {
        public string ID                   { get; set; }
        public DateTime StartDate          { get; set; }
        public DateTime EndDate            { get; set; }
        public string ReserveTime          { get; set; }
        public string ContractID           { get; set; }
        public RoomType Roomtype           { get; set; }    
        public double ThisPrice            { get; set; }        
        public string RoomID               { get; set; }        
        public string ReservationID        { get; set; }            
        public BookStatus BStatus          { get; set; }       
        public Booking(string id, DateTime start, DateTime end, string reserveTime,
                       string contractID, RoomType roomType, double price, string roomId,string reservationID, BookStatus bookingStatus)
        {
            ID = id;
            StartDate = start;
            EndDate = end;
            ReserveTime = reserveTime;
            ContractID = contractID;
            Roomtype = roomType;
            ThisPrice = price;
            RoomID = roomId;
            ReservationID = reservationID;
            BStatus = bookingStatus;
        }

        public Booking()
        {
            ID = IClock.GetBookingID;
        }
    }
}
