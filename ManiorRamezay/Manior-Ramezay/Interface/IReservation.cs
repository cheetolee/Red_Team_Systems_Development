namespace Interface
{
    public interface IReservation
    {
        string ID                     { get; set; }              
        double Payment                { get; set; }                 
        double DownPayment            { get; set; }              
        ReservationStatus RStatus     { get; set; }                
    }
}
