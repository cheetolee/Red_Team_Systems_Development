using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using ControllerLayer;
using Interface;
using Model;

namespace HotelManagementSystem
{

    public partial class CheckOutWindow : Window
    {
        UIController mainWindow = UIController.GetInstance();
        IReservation reservation;
        IBooking booking;
        ICustomer contract;
        IRoom room;
        List<IBooking> bookinglist = new List<IBooking>();
        List<IRoom> roomlist = new List<IRoom>();
        List<UIElement> cbxlist = new List<UIElement>();
        double roomsprice;
        double totalPrice;

        public CheckOutWindow(IRoom rm)
        {
            room = rm;
            var book = mainWindow.GetActiveBookings(null);
            foreach (IBooking bktemp in book)
            {
                if (bktemp.RoomID == room.ID)
                {
                    booking = bktemp;
                    break;
                }
            }
            InitializeComponent();
            InitializeWindowContent();
        }
        public CheckOutWindow(string bookingid)
        {
            booking = mainWindow.GetBooking(bookingid);
            room = mainWindow.GetRoom(booking.RoomID);
            InitializeComponent();
            InitializeWindowContent();
        }

        private void InitializeWindowContent()
        {
            reservation = mainWindow.GetReservation(booking.ReservationID);
            contract = mainWindow.GetCustomer(booking.ContractID);
            
            reservationNumber.Content = reservation.ID;
            checkInDate.Content = booking.StartDate.ToLongDateString().ToString();
            checkOutDate.Content = booking.EndDate.ToLongDateString().ToString();
            contracts.Content = contract.Name.ToString();
            roomType.Content = booking.Roomtype.ToString();
            contractsNum.Content = contract.Phone;
            company.Content = contract.Company;
            address.Text = contract.Address;

            roomPrice.Content = booking.ThisPrice;
            roomsprice = booking.ThisPrice;
            checkOutTime.Content = IClock.Time.GetDateTimeFormats('f')[0].ToString();
            downPayment.Content = reservation.DownPayment;

            LoadRoomList();
            CalculatePrice();
        }

        private void LoadRoomList()
        {
            bookinglist = mainWindow.GetActiveBookings(reservation.ID);
            foreach (IBooking bk in bookinglist)
            {
                if (bk.RoomID != "")
                    roomlist.Add(mainWindow.GetRoom(bk.RoomID));
            }
            int i = 0;
            try
            {
                foreach (IRoom rm in roomlist)
                {
                    UIElement cbx = NewCheckBox(++i, rm.RoomNum);
                    cbxlist.Add(cbx);
                    checkOutRoomsList.Children.Add(cbx);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private UIElement NewCheckBox(int name, string content)
        {
            var cbx = new CheckBox();
            cbx.Name = "cbx" + name;
            cbx.Content = content;
            if (content == room.RoomNum)
                cbx.IsChecked = true;
            cbx.Margin = new Thickness(5, 0, 5, 0);
            cbx.Click += new RoutedEventHandler(item_Click);
            return cbx;
        }
        private void item_Click(Object sender, RoutedEventArgs e)
        {
            roomsprice = 0;
            foreach (CheckBox cbx in cbxlist)
            {
                if (cbx.IsChecked == true)
                {
                    foreach (IBooking bk in bookinglist)
                    {
                        if (bk.RoomID != "" && mainWindow.GetRoom(bk.RoomID).RoomNum == cbx.Content.ToString())
                        {
                            roomsprice += bk.ThisPrice;
                            break;
                        }
                    }
                }
            }
            CalculatePrice();
        }

        private void CheckOutConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            reservation.Payment += totalPrice;
            reservation.RStatus = ReservationStatus.Paid;
            List<IRoom> rmlst = new List<IRoom>();
            try
            {
                foreach (CheckBox cbx in cbxlist)
                {
                    if (cbx.IsChecked == false)
                        reservation.RStatus = ReservationStatus.Confirmed;
                    else
                    {   // cbx is Checked
                        foreach (IRoom rm in roomlist)
                        {
                            if (rm.RoomNum == cbx.Content.ToString())
                                rmlst.Add(rm);
                        }
                    }
                }
                mainWindow.UpdateReservation(reservation);
                mainWindow.RefreshRooms(rmlst);
            }
            catch (Exception ex)
            {
                MessageBox.Show("参数错误！" + ex);
            }
            MessageBox.Show("离店成功！");
            mainWindow.Log_CheckOut(booking);
            this.Close();
        }

        private void CalculatePrice(object sender, TextChangedEventArgs e)
        {
            CalculatePrice();
        }
        private void CalculatePrice()
        {
            if (otherPayment.Text == "")
                otherPayment.Text = "0";
            totalPrice = roomsprice + double.Parse(otherPayment.Text.ToString());
            double finalPay = totalPrice - reservation.DownPayment;
            totalPayment.Content = totalPrice;
            finalPayment.Content = finalPay;
        }
    }
}
