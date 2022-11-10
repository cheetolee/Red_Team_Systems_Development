using System;
using System.Collections.Generic;
using System.Linq;
using Interface;
using Model;

namespace ControllerLayer
{
    internal class BookingController
    {
        private SQLiteController dbCon;
        private HotelController hCon;
        private ReportController LCon;

        internal BookingController(SQLiteController db,HotelController h, ReportController l)
        {
            dbCon = db;
            hCon = h;
            LCon = l;
        }
        
        #region Customer 

        internal ICustomer CreateCustomer(string name, CustomerGender gender, int age, string phone, string idcard,string roomid, string company, string address)
        {
            var customer = new Customer();
            return dbCon.CreateCustomer(customer.ID, name, gender, age,phone, idcard, roomid, company, address);
        }

        internal ICustomer GetCustomer(string customerID)
        {
            return dbCon.GetCustomer(customerID);
        }

        internal List<ICustomer> GetCustomers()
        {
            return dbCon.GetCustomers();
        }

        internal ICustomer GetCustomerViaPhone(string customerPhone)
        { 
            var list = dbCon.GetCustomers(); 
            foreach (ICustomer customer in list) 
            { 
                if (customer.Phone == customerPhone) 
                    return customer; 
            } 
            return null; 
        }
        
        internal ICustomer UpdateCustomer(ICustomer cus)
        {
            return dbCon.UpdateCustomer(cus);
        }
        #endregion 

        #region Booking

        internal List<IBooking> CreateBookings(List<IAvaliableRoom> selectedRoomList, DateTime start, DateTime end, string reservetime, string contractid, string reservationid)
        {
            List<IBooking> bookinglist = new List<IBooking>();
            foreach (IAvaliableRoom room in selectedRoomList)
            {
                IRoomPrice roomprice = dbCon.GetRoomPrice(room.RType);
                for (int i = 1; i <= room.ChosenNum; i++)
                {
                    var booking = new Booking();
                    dbCon.UpdateClock();
                    bookinglist.Add(dbCon.CreateBooking(booking.ID, start, end, reservetime, contractid, room.RType, roomprice.Price, reservationid));
                }
            }
            LCon.Log_Booked(dbCon.GetCustomer(contractid), bookinglist);
            return bookinglist;
        }

        internal IBooking CreateBooking(DateTime start, DateTime end, string reservetime, string contractid, RoomType roomtype, string reservationid)
        {
            IRoomPrice roomprice = dbCon.GetRoomPrice(roomtype);
            var booking = new Booking();
            dbCon.UpdateClock();
            return dbCon.CreateBooking(booking.ID, start, end, reservetime, contractid, roomtype, roomprice.Price , reservationid);
        }
        
        internal List<IBooking> GetActiveBookings(string reservationID)
        {
            List<IBooking> bookings = new List<IBooking>();

            foreach (IBooking book in dbCon.GetBookings(reservationID))
            {
                if (book.BStatus != BookStatus.Canceled)
                    bookings.Add(book);
            }
            return bookings;
        }

        internal List<IBooking> GetActiveBookings()
        {
            List<IBooking> bookings = new List<IBooking>();

            foreach (IBooking book in dbCon.GetBookings())
            {
                if (book.BStatus != BookStatus.Canceled)
                    bookings.Add(book);
            }
            return bookings;
        }

        internal void CancelBooking(string BookingID)
        {
            IBooking book = dbCon.GetBooking(BookingID);
            book.BStatus = BookStatus.Canceled;
            dbCon.UpdateBooking(book);
            string reservationID = book.ReservationID;
            List<IBooking> books = dbCon.GetBookings(reservationID);
            if (books.Count() == 1)
                CancelReservation(reservationID);
        }
        
        #endregion

        #region Reservation
        internal IReservation CreateReservation()
        {
            IReservation reservation = new Reservation();
            dbCon.UpdateClock();
            return dbCon.CreateReservation(reservation.ID, 0, 0, ReservationStatus.Canceled);
        }

        internal IReservation UpdateReservation(IReservation reserv)
        {
            return dbCon.UpdateReservation(reserv);
        }

        internal IReservation GetReservation(string reservationID)
        {
            return dbCon.GetReservation(reservationID);
        }
        
        internal void CancelReservation(string reservationID)
        {
            IReservation reservation = dbCon.GetReservation(reservationID);
            reservation.RStatus = ReservationStatus.Canceled;
            dbCon.UpdateReservation(reservation);
            List<IBooking> books = dbCon.GetBookings(reservationID);
            foreach (IBooking book in books)
            {
                book.BStatus = BookStatus.Canceled;
                dbCon.UpdateBooking(book);
            }

        }
        #endregion
    }
}
