using System.Collections.Generic;
using Interface;

namespace ControllerLayer
{

    internal class LogController
    {
        private SQLiteController dbCon;

        internal LogController(SQLiteController db)
        {
            dbCon = db;
        }

        internal void Log_Booked(ICustomer customer, List<IBooking> bookings)
        {
            string rooms = null;
            foreach (IBooking bk in bookings)
            {
                rooms += (bk.Roomtype.ToString() + "(" 
                    + bk.StartDate.ToShortDateString().ToString() + " "
                    + bk.EndDate.ToShortDateString().ToString() + ");");
            }
            dbCon.CreateLog(customer.Name + " booked " + bookings.Count + " rooms: " + rooms);
        }

        internal void Log_CheckIn(List<ICustomer> customers, IBooking booking)
        {
            string temp = null;
            foreach (ICustomer cus in customers)
            {
                temp += (cus.Name + " ");
            }
            dbCon.CreateLog(temp + " checked in room: " + dbCon.GetRoom(booking.RoomID).RoomNum);
        }

        internal void Log_CheckOut(IBooking booking)
        {
            dbCon.CreateLog("customer in room " + dbCon.GetRoom(booking.RoomID).RoomNum + " checked out");
        }

        internal void Log_Cancel(IBooking booking)
        {
            dbCon.CreateLog("booking ID:" + booking.ReservationID + " canceled");
        }

        internal List<Log> GetLogs()
        {
            return dbCon.GetLogs();
        }
    }
}
