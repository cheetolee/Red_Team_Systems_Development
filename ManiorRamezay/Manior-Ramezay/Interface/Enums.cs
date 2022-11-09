namespace Interface
{
    public enum CustomerGender
    {
        Male,
        Female,
        Other
    }

    // Booking status
    public enum BookStatus
    {
        Confirmed,  
        Timeout,    
        Canceled    
    }

    // Reservation status
    public enum ReservationStatus
    {
        Confirmed,     
        Default,    
        Canceled,   
        Paid        
    }

    // Room status
    public enum RoomStatus
    {
        Idle,       
        Occupied,   
        NA          
    }

    // Room type
    public enum RoomType
    {
        Junior,
        Double,
        Triple,
        OneBed,
        TwoBed,
        EconTwin
    }
}
