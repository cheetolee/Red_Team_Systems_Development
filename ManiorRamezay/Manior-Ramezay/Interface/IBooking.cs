using System;

namespace Interface
{

    public interface IBooking
    {
        string ID               { get; set; }  
        DateTime StartDate      { get; set; }  
        DateTime EndDate        { get; set; }   
        string ReserveTime      { get; set; }  
        string ContractID       { get; set; }   
        RoomType Roomtype       { get; set; }   
        double ThisPrice        { get; set; }   
        string RoomID           { get; set; }   
        string ReservationID    { get; set; }   
        BookStatus BStatus      { get; set; }   
    }
}