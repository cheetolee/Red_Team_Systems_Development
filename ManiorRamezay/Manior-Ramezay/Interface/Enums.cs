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
        Idle, // Available       
        Occupied, // Unavailable
        NA  // Not Available (To be cleaned, being reparied)           
    }

    // Room types at Manior Ramezay
    public enum RoomType
    {
        Standard,
        Deluxe,
        FireplaceSuite,
        QueenSuite,
        KingSuite,
        RoyalSuite
    }
}
