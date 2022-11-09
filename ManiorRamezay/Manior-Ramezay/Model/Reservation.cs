using Interface;

namespace Model
{
    public class Reservation:IReservation
    {
        public string ID { get; set; }       
        public double Payment { get; set; }     
        public double DownPayment { get; set; }             
        public ReservationStatus RStatus { get; set; }            
        public Reservation(string id,double payment,double downpayment,ReservationStatus rstatus)
        {
            ID = id;
            Payment = payment;
            DownPayment = downpayment;
            RStatus = rstatus;
        }
        public Reservation()
        {
            ID = IClock.GetReservID;
        }
    }
}
